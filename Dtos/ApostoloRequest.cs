 
using System.ComponentModel.DataAnnotations;
 

namespace api_novo_testamento.Dtos
{
    public class ApostoloRequest
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

    }
}