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
    public partial class CadastroJogadores : CadastroBase
    {

        // private readonly IBaseService<Jogadores> _jogadorService;

        //private List<Jogadores>? jogadores;
        //IBaseService<Jogadores> jogadorService
        public CadastroJogadores()
        {
            //_jogadorService = jogadorService;
            InitializeComponent();
        }
        private void PreencheObjeto(Jogadores jogador)
        {
            jogador.Nome = txtNome.Text;
            jogador.Idade = Convert.ToInt32(txtIdade.Text);
            jogador.Time = (Times)cboTime.SelectedItem;
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
