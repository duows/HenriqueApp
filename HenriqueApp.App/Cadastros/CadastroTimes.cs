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
    public partial class CadastroTimes : CadastroBase
    {
        private readonly IBaseService<Times> _timeService;

        private List<TimesModel>? times;

        public CadastroTimes(IBaseService<Times> timeService)
        {
            _timeService = timeService;
            InitializeComponent();
        }

        private void PreencheObjeto(Times time)
        {
            time.Nome = txtNome.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var times = _timeService.GetById<Times>(id);
                        PreencheObjeto(times);
                        times = _timeService.Update<Times, Times, TimesValidator>(times);
                    }
                }
                else
                {
                    var times = new Times();
                    PreencheObjeto(times);
                    _timeService.Add<Times, Times, TimesValidator>(times);

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
                _timeService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Henrique App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            times = _timeService.Get<TimesModel>().ToList();
            dataGridViewConsulta.DataSource = times;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Id"].Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
        }

        private void tabPageCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
