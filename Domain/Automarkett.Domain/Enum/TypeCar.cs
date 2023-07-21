using System.ComponentModel.DataAnnotations;

namespace Automarkett.Domain.Enum;

public enum TypeCar
{
    [Display(Name = "Легковой автомобиль")]
    PassengerCar = 0,
        
    [Display(Name = "Седан")]
    Sedan = 1,
    
    [Display(Name = "Легковой автомобиль")]
    HatchBack = 2,
    
    [Display(Name = "Легковой автомобиль")]
    Minivan = 3,
    
    [Display(Name = "Легковой автомобиль")]
    SportsCar = 4,
    
    [Display(Name = "Легковой автомобиль")]
    Suv = 5
    
}