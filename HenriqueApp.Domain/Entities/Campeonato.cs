using HenriqueApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.Domain.Entities
{
    public class Campeonato : BaseEntity<int>
    {
        public Campeonato()
        {

        }

        public Campeonato(int id, string? nome) : base(id)
        {
            Nome = nome;
        }
        public string? Nome { get; set; }
    }
}