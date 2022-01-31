using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeEmrpesas.Models
{
    public class Emrpesa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Razão Social")]
        public String RazaoSocial { get; set; }
        [Required]
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }
        [Required]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        [Required]
        [DisplayName("CEP")]
        public string Cep { get; set; }
        [Required]
        public string Localidade { get; set; }
        [Required]
        [DisplayName("Número")]
        public string Numero { get; set; }
        public string Complemento { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        [DisplayName("Data de Inclusão")]
        public DateTime DataDeInclusao { get; set; } = DateTime.Now;
    }
}
