using HenriqueApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.App.Models
{
    public class JogadoresModel
    {
        public string? Nome { get; set; }
        public int? Idade { get; set; }
        public int? Gols { get; set; }
        public int? Assist { get; set; }
        //public Times? Time { get; set; }
        public int IdTime { get; set; }
        public string NomeTime { get; set; }
        public int? Capitao { get; set; }
    }
}
