namespace TaskGarageBackend.DTOs
{
    // Base class with common vehicle properties
    public class VehicleBaseDto
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string LicensePlate { get; set; } = string.Empty;
        public int? Year { get; set; }
        public int? Mileage { get; set; }
    }

    // For creating new vehicles
    public class VehicleCreateDto : VehicleBaseDto
    {
    }

    // For reading vehicles
    public class VehicleReadDto : VehicleBaseDto
    {
        public int Id { get; set; }
    }

    // For updating vehicles
    public class VehicleUpdateDto : VehicleBaseDto
    {
        // You can make properties nullable for partial updates
    }
}
