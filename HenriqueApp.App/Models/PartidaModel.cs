using HenriqueApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.App.Models
{
    public class PartidaModel
    {
        public int Id { get; set; }
        public int? Gol1 { get; set; }
        public int? Gol2 { get; set; }
        //public Times? Time1 { get; set; }
        public int IdTime1 { get; set; }
        public string ?NomeTime1 { get; set; }
        //public Times? Time2 { get; set; }
        public int IdTime2 { get; set; }
        public string ?NomeTime2 { get; set; }
        //public TempCamp? TempCampId { get; set; }
        public int IdTempCamp { get; set; }
        public string ?NomeCamp { get; set; }
        public string ?AnoTemporada { get; set; }
    }
}
