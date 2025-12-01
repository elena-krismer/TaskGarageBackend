namespace TaskGarageBackend.DTOs
{
    public class ResourceBaseDto
    {
        public required string Name { get; set; }
        public string? Type { get; set; }
        public int? Quantity { get; set; }
        public double? Cost { get; set; }
    }

    public class ResourceCreateDto : ResourceBaseDto
    {
        // Additional properties specific to creation can go here
    }

    public class ResourceUpdateDto : ResourceBaseDto
    {
        // You can make properties nullable for partial updates
    }

    public class ResourceReadDto : ResourceBaseDto
    {
        public int? Id { get; set; }
    }
}