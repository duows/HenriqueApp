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

        public Jogadores(int id, string? nome, int? idade, int? camisa, Times? time, bool? capitao) : base(id)
        {
            Nome = nome;
            Idade = idade;
            Time = time;
            Capitao = capitao;
        }
        public string? Nome { get; set; }
        public int? Idade { get; set; }
        public Times? Time { get; set; }
        public bool? Capitao { get; set; }
    }
}
