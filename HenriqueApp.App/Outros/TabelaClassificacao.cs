using HenriqueApp.App.Models;
using HenriqueApp.Domain.Base;
using HenriqueApp.Domain.Entities;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HenriqueApp.App.Outros
{
    public partial class TabelaClassificacao : MaterialForm
    {
        private readonly IBaseService<TempCamp> _tempCampService;
        private readonly IBaseService<Campeonato> _campeonatoService;
        private readonly IBaseService<Temporada> _temporadaService;
        private readonly IBaseService<TimeCampeonato> _timeCampeonatoService;

        private List<TimeCampeonatoModel>? timeCampeonato;
        public TabelaClassificacao(IBaseService<TempCamp> tempCampService,
                                   IBaseService<Campeonato> campeonatoService,
                                   IBaseService<Temporada> temporadaService,
                                   IBaseService<TimeCampeonato> timeCampeonatoService)
        {
            _tempCampService = tempCampService;
            _campeonatoService = campeonatoService;
            _temporadaService = temporadaService;
            _timeCampeonatoService = timeCampeonatoService;
            InitializeComponent();
            CarregaCombo();
        }

        private void CarregaCombo()
        {
            cboCamp.ValueMember = "Id";
            cboCamp.DisplayMember = "Nome";
            cboCamp.DataSource = _campeonatoService.Get<Campeonato>().ToList();
        }

        protected void CarregaGrid()
        {
            var camp = (Campeonato)cboCamp.SelectedItem;
            var temp = (Temporada)cboTemp.SelectedItem;
            var tempCamp = _tempCampService.Get<TempCamp>(new List<string>() { "Camp", "Temp" })
            .Where(x => x.Camp!.Id == camp.Id && x.Temp!.Id == temp.Id).FirstOrDefault();
            if (tempCamp != null)
            {
                var timeCamp = _timeCampeonatoService.Get<TimeCampeonatoModel>(new List<string>() { "Time", "Temp" })
                    .Where(x => x.Temp!.Id == tempCamp.Id).ToList();

                var timesOrdenados = timeCamp
                    .OrderByDescending(x => x.Pontos)
                    .ThenByDescending(x => x.Vitoria)
                    .ThenByDescending(x => x.Golpro - x.Golcon)
                    .ToList();

                dataGridView1.DataSource = timesOrdenados;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Time"].Visible = false;
                dataGridView1.Columns["IdTime"].Visible = false;
                dataGridView1.Columns["Temp"].Visible = false;
                dataGridView1.Columns["Posicao"].Visible = false;
                dataGridView1.Columns["IdTempCamp"].Visible = false;
                dataGridView1.Columns["Golpro"].HeaderText = "Gols marcados";
                dataGridView1.Columns["NomeTime"].HeaderText = "Time";
                dataGridView1.Columns["Golcon"].HeaderText = "Gols sofridos";

            }
            else
            {
                dataGridView1.DataSource = null;
            }
            
        }

        private void cboCamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var camp = (Campeonato)cboCamp.SelectedItem;
            var tempCamp = _tempCampService.Get<TempCamp>(new List<string> { "Camp", "Temp" })
                    .Where(x => x.Camp!.Id == camp.Id).ToList();

            var temporadas = new List<Temporada>();

            foreach (var temp in tempCamp)
            {
                temporadas.Add(temp.Temp!);
            }

            cboTemp.ValueMember = "Id";
            cboTemp.DisplayMember = "Ano";
            cboTemp.DataSource = temporadas;

            CarregaGrid();
        }

        private void TabelaClassificacao_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void cboTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
