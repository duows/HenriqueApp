using HenriqueApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.App.Models
{
    public class TempCampModel
    {
        public int Id { get; set; }
        public string? Premio { get; set; }
        //public Temporada? Temp { get; set; }
        public int IdTemporada { get; set; }
        public int AnoTemporada { get; set; }
        //public Campeonato? Camp { get; set; }
        public int IdCampeonato { get; set; }
        public string? NomeCampeonato { get; set; }
        public string? Campeao { get; set; }
    }
}
