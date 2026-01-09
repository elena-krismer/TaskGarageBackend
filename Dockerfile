# ---------- Build stage ----------
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

# ---------- Runtime stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Create a writable folder for SQLite DB
RUN mkdir -p /app/data

# Run as non-root
RUN useradd -m appuser && chown -R appuser:appuser /app
USER appuser

# Avoid "undefined var" warnings at build time by giving PORT a default.
# Render will override PORT at runtime.
ENV PORT=10000
ENV ASPNETCORE_URLS=http://0.0.0.0:${PORT}

COPY --from=build /app/publish .

EXPOSE 10000

ENTRYPOINT ["dotnet", "TaskGarageBackend.dll"]
