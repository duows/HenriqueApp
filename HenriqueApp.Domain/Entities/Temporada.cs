using HenriqueApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.Domain.Entities
{
    public class Temporada : BaseEntity<int>
    {
        public Temporada()
        {

        }

        public Temporada(int id, string? ano) : base(id)
        {
            Ano = ano;
        }
        public string? Ano { get; set; }
    }
}
