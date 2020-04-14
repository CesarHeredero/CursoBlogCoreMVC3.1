using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogCore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de categoría es obligatorio")]
        [Display(Name = "Nombre categoría")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El oreden es obligatorio")]
        [Display(Name ="Orden categoría")]
        public int Orden { get; set; }
    }
}
