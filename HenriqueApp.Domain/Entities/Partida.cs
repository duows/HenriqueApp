using HenriqueApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.Domain.Entities
{
    public class Partida : BaseEntity<int>
    {
        public Partida()
        {

        }

        public Partida(int id, DateTime? data, int? gol1, int? gol2, Times? time1, Times? time2, TempCamp? tempCamp) : base(id)
        {
            Data = data;
            Gol1 = gol1;
            Gol2 = gol2;
            Time1 = time1;
            Time2 = time2;
            TempCampId = tempCamp;
        }
        public DateTime? Data { get; set; }
        public int? Gol1 { get; set; }
        public int? Gol2 { get; set; }
        public Times? Time1 { get; set; }
        public Times? Time2 { get; set; }
        public TempCamp? TempCampId { get; set; }
    }
}
