using HenriqueApp.App.Base;
using HenriqueApp.Domain.Base;
using HenriqueApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HenriqueApp.App.Cadastros
{
    public partial class CadastroTimeCampeonato : CadastroBase
    {
        private readonly IBaseService<TimeCampeonato> _TimeCampeonatoService;
        private readonly IBaseService<Times> _TimesService;
        private readonly IBaseService<Campeonato> _CampeonatoService;
        private readonly IBaseService<Temporada> _TemporadaService;
        private readonly IBaseService<TempCamp> _TempCampService;

        private List<TimeCampeonato>? produtos;
        public CadastroTimeCampeonato()
        {
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            
        }
    }
}
