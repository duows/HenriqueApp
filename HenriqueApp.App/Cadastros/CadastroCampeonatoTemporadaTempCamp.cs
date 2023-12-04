using HenriqueApp.App.Base;
using HenriqueApp.App.Infra;
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
        public CadastroCampeonatoTemporadaTempCamp()
        {
            InitializeComponent();
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
                cad.MdiParent = this;
                cad.ShowDialog();
            }
        }
    }
}
