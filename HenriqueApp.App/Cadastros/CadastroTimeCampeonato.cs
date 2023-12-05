using HenriqueApp.App.Base;
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

            cboCamp.ValueMember = "Id";
            cboCamp.DisplayMember = "Nome";
            cboCamp.DataSource = _campeonatoService.Get<Campeonato>().ToList();

            cboTemp.ValueMember = "Id";
            cboTemp.DisplayMember = "Ano";
            cboTemp.DataSource = _temporadaService.Get<Temporada>().ToList();
        }

        private void PreencheObjeto(TimeCampeonato timeCampeonato)
        {
            var camp = (Campeonato)cboCamp.SelectedItem;
            var temp = (Temporada)cboTemp.SelectedItem;
            var tempCamp = _tempCampService.Get<TempCamp>(new List<string>() { "Camp", "Temp" }).Where(x => x.Camp!.Id == camp.Id && x.Temp!.Id == temp.Id).FirstOrDefault();

            timeCampeonato.Pontos = 0;
            timeCampeonato.Vitoria = 0;
            timeCampeonato.Derrota = 0;
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
                        var timeCampeonato = _timeCampeonatoService.GetById<TimeCampeonato>(id);
                        PreencheObjeto(timeCampeonato);
                        timeCampeonato = _timeCampeonatoService.Update<TimeCampeonato, TimeCampeonato, TimeCampeonatoValidator>(timeCampeonato);
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

        protected override void CarregaGrid()
        {
            /*timeCampeonato = _timeCampeonatoService.Get<TimeCampeonato>().ToList();
            dataGridViewConsulta.DataSource = timeCampeonato;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            /*txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            cboCidade.SelectedValue = linha?.Cells["IdCidade"].Value;*/
        }

    }
}
