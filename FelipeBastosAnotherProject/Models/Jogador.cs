using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FelipeBastosAnotherProject.Models
{
    public class Jogador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Idade é obrigatório.")]
        public int Idade { get; set; }

        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
    }
}
