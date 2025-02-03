using System.ComponentModel.DataAnnotations;
 

namespace ApiNovoTestamento.Models 
{ 
    public class Apostolo 
    {          
        public int Id { get; set; } 
      [Required]
      [StringLength(100)]
        public string Nome { get; set; } 
    } 
} 
