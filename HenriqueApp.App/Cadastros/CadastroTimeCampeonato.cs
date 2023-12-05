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
        private readonly IBaseService<TimeCampeonato> _timeCampeonatoService;
        private readonly IBaseService<Times> _timesService;
        private readonly IBaseService<Campeonato> _campeonatoService;
        private readonly IBaseService<Temporada> _temporadaService;
        private readonly IBaseService<TempCamp> _tempCampService;

        private List<TimeCampeonato>? timeCampeonato;
        public CadastroTimeCampeonato(IBaseService<TimeCampeonato> timeCampeonatoService,
                                      IBaseService<Times> vendaService,
                                      IBaseService<Campeonato> campeonatoService,
                                      IBaseService<Temporada> temporadaService,
                                      IBaseService<TempCamp> tempCampService)
        {
            _timeCampeonatoService = timeCampeonatoService;
            _timesService = vendaService;
            _campeonatoService = campeonatoService;
            _temporadaService = temporadaService;
            _tempCampService = tempCampService;
            InitializeComponent();
            CarregarCombo();
        }
        private void CarregarCombo()
        {
            cboTime.ValueMember = "Id";
            cboTime.DisplayMember = "Nome";
            cboTime.DataSource = _timesService.Get<Times>().ToList();

            cboCampeonato.ValueMember = "Id";
            cboCampeonato.DisplayMember = "Nome";
            cboCampeonato.DataSource = _campeonatoService.Get<Campeonato>().ToList();

            cboTemporada.ValueMember = "Id";
            cboTemporada.DisplayMember = "Ano";
            cboTemporada.DataSource = _temporadaService.Get<Temporada>().ToList();
        }

        private void PreencheObjeto(TimeCampeonato timeCampeonato)
        {
            timeCampeonato.Time = (Times)cboTime.SelectedItem;
            //timeCampeonato.Campeonato = (Campeonato)cboCampeonato.SelectedItem;
            //timeCampeonato.Temporada = (Temporada)cboTemporada.SelectedItem;
        }

        
    }
}
