using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FelipeBastosAnotherProject.Models
{
    public class Placar
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Pontos é obrigatório."), Range(0, 999999999999999999, ErrorMessage = "O campo Pontos não pode ser negativo.")]
        public int pontos { get; set; }

        public Jogador jogador { get; set; }
        
        [Required(ErrorMessage = "O campo Jogador é obrigatório.")]
        public int jogadorId { get; set; }

        [Required(ErrorMessage = "O campo Data é obrigatório."), DataType(DataType.Date)]
        public DateTime data { get; set; }
    }
}
