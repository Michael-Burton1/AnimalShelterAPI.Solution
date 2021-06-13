using System.ComponentModel.DataAnnotations;

namespace Shelter.Models
{
  public class Animal
  {
    public int AnimalId {get; set;}
    [Required]
    public string Name {get; set;}
    [Required]
    public int Age {get; set;}
    [Required]
    public string Type {get; set;}
    [Required]
    public string Sex {get; set;}
  }
}