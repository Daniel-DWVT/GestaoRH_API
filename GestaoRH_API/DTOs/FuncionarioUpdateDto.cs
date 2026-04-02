using System.ComponentModel.DataAnnotations;

namespace GestaoRH_API.DTOs
{
    public class FuncionarioUpdateDto
    {
        [Required(ErrorMessage = "O nome do funcionário é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do funcionário não pode exceder 100 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O cargo do funcionário é obrigatório.")]
        [StringLength(50, ErrorMessage = "O cargo do funcionário não pode exceder 50 caracteres.")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "O salário do funcionário é obrigatório.")]
        [Range(1000, 100000, ErrorMessage = "O salário do funcionário deve estar entre 1.000 e 100.000.")]
        public decimal Salario { get; set; }



    }
}
