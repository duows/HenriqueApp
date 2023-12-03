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
    public partial class CadastroJogadores : CadastroBase
    {

        private readonly IBaseService<Jogadores> _jogadorService;

        private List<Jogadores>? jogadores;

        public CadastroJogadores(IBaseService<Jogadores> jogadorService)
        {
            _jogadorService = jogadorService;
            InitializeComponent();
        }
        private void PreencheObjeto(Jogadores jogador)
        {
            jogador.Nome = txtNome.Text;
            jogador.Idade = Convert.ToInt32(txtIdade.Text);
            jogador.Time = (Times)cboTime.SelectedItem;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var jogador = _jogadorService.GetById<Jogadores>(id);
                        PreencheObjeto(jogador);
                        jogador = _jogadorService.Update<Jogadores, Jogadores, JogadoresValidator>(jogador);
                    }
                }
                else
                {
                    var jogador = new Jogadores();
                    PreencheObjeto(jogador);
                    _jogadorService.Add<Jogadores, Jogadores, JogadoresValidator>(jogador);

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
                _jogadorService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Henrique AP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            jogadores = _jogadorService.Get<Jogadores>().ToList();
            dataGridViewConsulta.DataSource = jogadores;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
        }

        private void materialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedRadioButton = (RadioButton)sender;

            if (clickedRadioButton.Checked)
            {
                if (clickedRadioButton == rbtCapitao)
                {
                    rbtJogador.Checked = false;
                }
                else if (clickedRadioButton == rbtJogador)
                {
                    rbtCapitao.Checked = false;
                }
            }
        }
    }
}
