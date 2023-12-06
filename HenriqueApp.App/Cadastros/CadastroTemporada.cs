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
    public partial class CadastroTemporada : CadastroBase
    {
        private readonly IBaseService<Temporada> _temporadaService;

        private List<Temporada>? temporada;
        public CadastroTemporada(IBaseService<Temporada> temporadaService)
        {
            _temporadaService = temporadaService;
            InitializeComponent();
        }

        private void PreencheObjeto(Temporada temporada)
        {
            temporada.Ano = txtAno.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var temporada = _temporadaService.GetById<Temporada>(id);
                        PreencheObjeto(temporada);
                        temporada = _temporadaService.Update<Temporada, Temporada, TemporadaValidator>(temporada);
                    }
                }
                else
                {
                    var temporada = new Temporada();
                    PreencheObjeto(temporada);
                    _temporadaService.Add<Temporada, Temporada, TemporadaValidator>(temporada);

                }

                materialTabControl.SelectedIndex = 1;
                if (CadastroCampeonatoTemporadaTempCamp.instance != null)
                {
                    CadastroCampeonatoTemporadaTempCamp.instance.CarregarCombo();
                }
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
                _temporadaService.Delete(id);
                if (CadastroCampeonatoTemporadaTempCamp.instance != null)
                {
                    CadastroCampeonatoTemporadaTempCamp.instance.CarregarCombo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Henrique App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            temporada = _temporadaService.Get<Temporada>().ToList();
            dataGridViewConsulta.DataSource = temporada;
            dataGridViewConsulta.Columns["Ano"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Id"].Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtAno.Text = linha?.Cells["Ano"].Value.ToString();
        }
    }
}
