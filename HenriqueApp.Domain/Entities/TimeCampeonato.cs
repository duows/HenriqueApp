using HenriqueApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.Domain.Entities
{
    public class TimeCampeonato : BaseEntity<int>
    {
        public TimeCampeonato()
        {

        }

        public TimeCampeonato(int id, Times? time, TempCamp? temp, int? pontos, int? posicao, int? golpro, int? golcon) : base(id)
        {
            Time = time;
            Temp = temp;
            Pontos = pontos;
            Posicao = posicao;
            Golpro = golpro;
            Golcon = golcon;
        }
        public Times? Time { get; set; }
        public TempCamp? Temp { get; set; }
        public int? Pontos { get; set; }
        public int? Posicao { get; set; }
        public int? Golpro { get; set; }
        public int? Golcon { get; set; }
    }
}