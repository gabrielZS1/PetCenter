using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetCenterPTCC.Models
{
    [Table("Consulta")]
    public class Consulta
    {
        [Key]
        public int ConsultaId { get; set; }
        public string NomeVeterinaria { get; set; }
        public DateTime DataHora { get; set; }

        public bool TemTosa { get; set; }
        public bool TemBanho { get; set; }
        public bool TemVacinacao { get; set; }

        public int PetId { get; set; }
        [ForeignKey("PetId")]
        public Pet PetPaciente { get; set; }
    }
}