using HenriqueApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.Domain.Entities
{
    public class TempCamp : BaseEntity<int>
    {
        public TempCamp()
        {

        }

        public TempCamp(int id, string? premio, Temporada? temp, Campeonato? camp, string? campeao) : base(id)
        {
            Premio = premio;
            Temp = temp;
            Camp = camp;
            Campeao = campeao;
        }
        public string? Premio { get; set; }
        public Temporada? Temp { get; set; }
        public Campeonato? Camp { get; set; }
        public string? Campeao { get; set; }
    }
}
