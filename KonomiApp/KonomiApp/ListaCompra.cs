﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonomiApp
{
    public class ListaCompra
    {
        public ListaCompra()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public String NomeLista { get; set; }

    }
}
