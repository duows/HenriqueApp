using HenriqueApp.App.Base;
using HenriqueApp.App.Models;
using HenriqueApp.Domain.Base;
using HenriqueApp.Domain.Entities;
using HenriqueApp.Service.Validators;
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

        private List<TimeCampeonatoModel>? timeCampeonato;
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

            cboCamp.ValueMember = "Id";
            cboCamp.DisplayMember = "Nome";
            cboCamp.DataSource = _campeonatoService.Get<Campeonato>().ToList();
        }

        private void PreencheObjeto(TimeCampeonato timeCampeonato)
        {
            var camp = (Campeonato)cboCamp.SelectedItem;
            var temp = (Temporada)cboTemp.SelectedItem;
            var tempCamp = _tempCampService.Get<TempCamp>(new List<string>() { "Camp", "Temp" }).Where(x => x.Camp!.Id == camp.Id && x.Temp!.Id == temp.Id).FirstOrDefault();

            timeCampeonato.Pontos = 0;
            timeCampeonato.Vitoria = 0;
            timeCampeonato.Derrota = 0;
            timeCampeonato.Empate = 0;
            timeCampeonato.Posicao = 0;
            timeCampeonato.Temp = tempCamp;
            timeCampeonato.Time = (Times)cboTime.SelectedItem;
            timeCampeonato.Golpro = 0;
            timeCampeonato.Golcon = 0;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        _timeCampeonatoService.Delete(id);
                        var timeCampeonato = new TimeCampeonato();
                        PreencheObjeto(timeCampeonato);
                        _timeCampeonatoService.Add<TimeCampeonato, TimeCampeonato, TimeCampeonatoValidator>(timeCampeonato);
                    }
                }
                else
                {
                    var timeCampeonato = new TimeCampeonato();
                    PreencheObjeto(timeCampeonato);
                    _timeCampeonatoService.Add<TimeCampeonato, TimeCampeonato, TimeCampeonatoValidator>(timeCampeonato);
                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Henrique APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _timeCampeonatoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Henrique App", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
        protected override void CarregaGrid()
        {
            var tempCamp = _tempCampService.Get<TempCamp>(new List<string> { "Camp", "Temp" }).ToList();


            timeCampeonato = _timeCampeonatoService.Get<TimeCampeonatoModel>(new List<string> { "Time" }).ToList();
            dataGridViewConsulta.DataSource = timeCampeonato;
            dataGridViewConsulta.Columns["Id"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Id"].Visible = false;
            dataGridViewConsulta.Columns["Time"].Visible = false;
            dataGridViewConsulta.Columns["IdTime"].Visible = false;
            dataGridViewConsulta.Columns["Temp"].Visible = false;
            dataGridViewConsulta.Columns["IdTempCamp"].Visible = false;
            dataGridViewConsulta.Columns["Golpro"].HeaderText = "Gols marcados";
            dataGridViewConsulta.Columns["NomeTime"].HeaderText = "Time";
            dataGridViewConsulta.Columns["Golcon"].HeaderText = "Gols sofridos";
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            cboTime.SelectedValue = linha?.Cells["NomeTime"].Value;
        }

    }
}
