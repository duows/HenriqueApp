using HenriqueApp.App.Base;
using HenriqueApp.App.Models;
using HenriqueApp.Domain.Base;
using HenriqueApp.Domain.Entities;
using HenriqueApp.Service.Validators;

namespace HenriqueApp.App.Cadastros
{
    public partial class CadastroJogadores : CadastroBase
    {

        private readonly IBaseService<Jogadores> _jogadorService;
        private readonly IBaseService<Times> _timeService;

        private List<JogadoresModel>? jogadores;

        public CadastroJogadores(IBaseService<Jogadores> jogadorService, IBaseService<Times> timeService)
        {
            _jogadorService = jogadorService;
            _timeService = timeService;
            InitializeComponent();
            CarregarCombo();
        }
        private void CarregarCombo()
        {
            var defaultTimeUm = new Times { Id = 0, Nome = "Escolha o mandante" };
            var timesList = _timeService.Get<Times>().ToList();
            timesList.Insert(0, defaultTimeUm);

            cboTime.ValueMember = "Id";
            cboTime.DisplayMember = "Nome";
            cboTime.DataSource = timesList;
        }
        private void PreencheObjeto(Jogadores jogador)
        {
            jogador.Nome = txtNome.Text;
            jogador.Idade = Convert.ToInt32(txtIdade.Text);
            if (rbtCapitao.Checked)
            {
                jogador.Capitao = true;
            }
            else
            {
                jogador.Capitao = false;
            }
            if (int.TryParse(cboTime.SelectedValue.ToString(), out var IdTime))
            {
                var time = _timeService.GetById<Times>(IdTime);
                jogador.Time = time;
            }
            //jogador.Time = (Times)cboTime.SelectedValue;
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
                        jogador.Time = _timeService.GetById<Times>(jogador.Time!.Id);
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
            jogadores = _jogadorService.Get<JogadoresModel>(new List<string> { "Time" }).ToList();
            dataGridViewConsulta.DataSource = jogadores;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Id"].Visible = false;
            dataGridViewConsulta.Columns["IdTime"].Visible = false;
            dataGridViewConsulta.Columns["NomeTime"].HeaderText = "Time atual";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtIdade.Text = linha?.Cells["Idade"].Value.ToString();
            cboTime.SelectedValue = linha?.Cells["IdTime"].Value;
            if (bool.Parse(linha?.Cells["Capitao"].Value.ToString()) == false)
            {
                rbtJogador.Checked = true;
                rbtCapitao.Checked = false;
            }
            else
            {
                rbtCapitao.Checked = true;
                rbtJogador.Checked = false;
            }
        }
    }
}
