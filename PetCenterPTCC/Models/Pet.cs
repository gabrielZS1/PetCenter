using PetCenterPTCC.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetCenterPTCC.Models
{
    [Table("Pet")]
    public class Pet
    {
        [Key]
        public int PetId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Raca { get; set; }

        // Chave Estrangeira
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Dono { get; set; }
    }
}