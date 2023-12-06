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

        public TimeCampeonato(int id, Times? time, TempCamp? temp, int? pontos,
                              int? posicao, int? vitoria, int? derrota, int? empate, int? golpro, int? golcon) : base(id)
        {
            Time = time;
            Temp = temp;
            Pontos = pontos;
            Posicao = posicao;
            Vitoria = vitoria;
            Derrota = derrota;
            Empate = empate;
            Golpro = golpro;
            Golcon = golcon;
        }
        public Times? Time { get; set; }
        public TempCamp? Temp { get; set; }
        public int? Pontos { get; set; }
        public int? Posicao { get; set; }
        public int? Vitoria { get; set; }
        public int? Derrota { get; set; }
        public int? Empate { get; set; }
        public int? Golpro { get; set; }
        public int? Golcon { get; set; }
    }
}