﻿using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Marca
    {
        public Marca()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdMarca { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Producto>? Productos { get; set; }
    }
}
