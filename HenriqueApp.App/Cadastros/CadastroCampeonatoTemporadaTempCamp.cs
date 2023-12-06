using HenriqueApp.App.Base;
using HenriqueApp.App.Infra;
using HenriqueApp.App.Models;
using HenriqueApp.Domain.Base;
using HenriqueApp.Domain.Entities;
using HenriqueApp.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class CadastroCampeonatoTemporadaTempCamp : CadastroBase
    {
        private readonly IBaseService<TempCamp> _tempCampService;
        private readonly IBaseService<Campeonato> _campeonatoService;
        private readonly IBaseService<Temporada> _temporadaService;

        private List<TempCamp>? tempCamp;

        public static CadastroCampeonatoTemporadaTempCamp instance = null;
        public CadastroCampeonatoTemporadaTempCamp(IBaseService<TempCamp> tempCampService,
                                                   IBaseService<Campeonato> campeonatoService,
                                                   IBaseService<Temporada> temporadaService)
        {
            _tempCampService = tempCampService;
            _campeonatoService = campeonatoService;
            _temporadaService = temporadaService;
            InitializeComponent();
            CarregarCombo();
            instance = this;
        }

        public void CarregarCombo()
        {
            cboCampeonato.ValueMember = "Id";
            cboCampeonato.DisplayMember = "Nome";
            cboCampeonato.DataSource = _campeonatoService.Get<Campeonato>().ToList();

            cboTemporada.ValueMember = "Id";
            cboTemporada.DisplayMember = "Ano";
            cboTemporada.DataSource = _temporadaService.Get<Temporada>().ToList();
        }

        private void PreencheObjeto(TempCamp tempCamp)
        {
            var camp = (Campeonato)cboCampeonato.SelectedItem;
            var temp = (Temporada)cboTemporada.SelectedItem;
            var nome = (camp.Nome + " " + temp.Ano).ToString();
            tempCamp.Camp = camp;
            tempCamp.Temp = temp;
            tempCamp.Premio = txtPremio.Text;
            tempCamp.Campeao = "Nenhum";
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var tempCamp = _tempCampService.GetById<TempCamp>(id);
                        PreencheObjeto(tempCamp);
                        tempCamp = _tempCampService.Update<TempCamp, TempCamp, TempCampValidator>(tempCamp);
                    }
                }
                else
                {
                    var tempCamp = new TempCamp();
                    PreencheObjeto(tempCamp);
                    _tempCampService.Add<TempCamp, TempCamp, TempCampValidator>(tempCamp);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Henrique App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _tempCampService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Henrique App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        protected override void CarregaGrid()
        {
            tempCamp = _tempCampService.Get<TempCamp>(new List<string> { "Camp", "Temp" }).ToList();
            dataGridViewConsulta.DataSource = tempCamp;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            if (linha != null)
            {
                txtId.Text = linha.Cells["Id"].Value?.ToString();
                cboCampeonato.SelectedValue = linha.Cells["Camp"].Value;
                cboTemporada.SelectedValue = linha.Cells["Temp"].Value;
                txtPremio.Text = linha.Cells["Premio"].Value?.ToString();
            }
        }

        private void tabPageCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnNCamp_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCampeonato>();
        }

        private void btnNTemp_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroTemporada>();
        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.ShowDialog();
            }
        }
    }
}
