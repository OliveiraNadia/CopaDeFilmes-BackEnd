using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeFilmes.Models
{
    public class FilmeModel 
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public double Nota { get; set; }
        public bool Campeao { get; set; }
    }
}
