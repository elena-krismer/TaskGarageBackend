using System.ComponentModel.DataAnnotations;

namespace TaskGarageBackend.Models
{

public class Vehicle
{
    [Key]
    public int Id { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public required string LicensePlate { get; set; }    
    public int? Year { get; set; }   
    public int? Mileage { get; set; }
}
}