using HenriqueApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.App.Models
{
    public class TimeCampeonatoModel
    {
        public int Id { get; set; }
        public Times? Time { get; set; }
        public int IdTime { get; set; }
        public string ?NomeTime { get; set; }
        public TempCamp? Temp { get; set; }
        public int IdTempCamp { get; set; }
        public int? Pontos { get; set; }
        public int? Posicao { get; set; }
        public int? Golpro { get; set; }
        public int? Golcon { get; set; }
    }
}
