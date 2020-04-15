using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogCore.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "Nombre slaid")]
        public string Nombre { get; set; }
        [Display(Name = "Estado")]
        public bool Estodo { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen slide")]
        public string UrlImagen { get; set; }
    }
}
