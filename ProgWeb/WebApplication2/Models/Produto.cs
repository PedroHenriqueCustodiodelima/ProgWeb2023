﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Produto
    {

        public long? ProdutoId { get; set; }
        public string Nome { get; set; }

        public long? CategoriaId { get; set; }
        public long? FabricanteId { get; set; } //esse ? é pq é opisional

        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }

    }
}
