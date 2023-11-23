using HenriqueApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.Domain.Entities
{
    public class Times : BaseEntity<int>
    {
        public Times()
        {

        }

        public Times(int id, string? nome) : base(id)
        {
            Nome = nome;
        }
        public string? Nome { get; set; }

    }
}
