﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Slider { get; set; }

        public IEnumerable<Articulo> ListaArticulo { get; set; }

        public IEnumerable<Categoria> Categoria { get; set; }
    }
}
 