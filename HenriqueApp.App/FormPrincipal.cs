using HenriqueApp.App.Infra;
using HenriqueApp.App.Cadastros;
using HenriqueApp.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
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

namespace HenriqueApp.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroTimes>();
        }

        private void jogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroJogadores>();
        }

        private void campeonatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCampeonatoTemporadaTempCamp>();
        }

        private void partidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroPartida>();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
