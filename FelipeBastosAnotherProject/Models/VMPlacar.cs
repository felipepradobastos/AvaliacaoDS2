using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FelipeBastosAnotherProject.Models
{
    public class VMPlacar
    {
        public Placar Placar { get; set; }
        public IEnumerable<Jogador> Jogadors { get; set; }
    }
}
