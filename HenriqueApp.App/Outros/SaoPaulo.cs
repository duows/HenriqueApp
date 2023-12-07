using HenriqueApp.App.Cadastros;
using Microsoft.VisualBasic.ApplicationServices;
using ReaLTaiizor.Forms;
using System;
using System.Media;
using System.Resources;
using System.Windows.Forms;

namespace HenriqueApp.App.Outros
{
    public partial class SaoPaulo : MaterialForm
    {
        private SoundPlayer player;

        public SaoPaulo()
        {
            InitializeComponent();
        }

        private void SaoPaulo_Load(object sender, EventArgs e)
        {
            string caminhoMusica = "C:\\Users\\Henrique\\Desktop\\Nova pasta (3)\\HenriqueApp\\HenriqueApp.App\\Resources\\hino.wav";

            if (System.IO.File.Exists(caminhoMusica))
            {
                player = new SoundPlayer(caminhoMusica);
                player.Play();
            }
            else
            {
                MessageBox.Show("Arquivo de música não encontrado!");
            }
        }

        private void SaoPaulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Certifique-se de parar a música ao fechar o formulário
            if (player != null)
            {
                player.Stop();
            }
            if (FormPrincipal.instance != null)
            {
                FormPrincipal.instance.tocaMusica();
            }
        }


    }
}
