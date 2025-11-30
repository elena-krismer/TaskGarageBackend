
using System.ComponentModel.DataAnnotations;
using TaskGarageBackend.Models;

namespace TaskGarageBackend.DTOs
{
    public class VehicleCreateDto
    {
        public string Brand { get; set; } = string.Empty; 
        public string Model { get; set; } = string.Empty;
        public string LicensePlate { get; set; } = string.Empty;
    }
}

