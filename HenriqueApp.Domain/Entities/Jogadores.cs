using HenriqueApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.Domain.Entities
{
    public class Jogadores : BaseEntity<int>
    {
        public Jogadores()
        {

        }

        public Jogadores(int id, string? nome, int? idade, int? gols, int? assist, int? camisa, Times? time, int? capitao) : base(id)
        {
            Nome = nome;
            Idade = idade;
            Gols = gols;
            Assist = assist;
            Time = time;
            Capitao = capitao;
        }
        public string? Nome { get; set; }
        public int? Idade { get; set; }
        public int? Gols { get; set; }
        public int? Assist { get; set; }
        public Times? Time { get; set; }
        public int? Capitao { get; set; }
    }
}
