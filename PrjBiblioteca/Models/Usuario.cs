using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrjBiblioteca.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public int? CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }       

        public ICollection<SistemaUsuario> SistUsuarios { get; set; }
    }
}