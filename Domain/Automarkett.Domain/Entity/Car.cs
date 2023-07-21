using Automarkett.Domain.Enum;

namespace Automarkett.Domain.Entity;

public class Car
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public string Model { get; set; }
    
    public string Speed { get; set; }
    
    public string Price { get; set; }
    
    public DateTime DateCreate  { get; set; }
    
    public TypeCar TypeCar { get; set; }
}