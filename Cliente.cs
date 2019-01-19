using System.ComponentModel.DataAnnotations;

namespace CRUDASP.NETMVA
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Cidade { get; set; }
    }
}