using AutoMapper;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HenriqueApp.App.Cadastros
{
    public partial class CadastroPartida : CadastroBase
    {
        bool delete = false;
        private readonly IBaseService<Partida> _partidaService;
        private readonly IBaseService<Times> _timesService;
        private readonly IBaseService<Campeonato> _campeonatoService;
        private readonly IBaseService<Temporada> _temporadaService;
        private readonly IBaseService<TempCamp> _tempCampService;
        private readonly IBaseService<TimeCampeonato> _timeCampeonatoService;

        private List<PartidaModel>? partida;

        public CadastroPartida(IBaseService<Partida> partidaService,
                               IBaseService<Times> timesService,
                               IBaseService<Campeonato> campeonatoService,
                               IBaseService<Temporada> temporadaService,
                               IBaseService<TempCamp> tempCampService,
                               IBaseService<TimeCampeonato> timeCampeonatoService)
        {
            _partidaService = partidaService;
            _timesService = timesService;
            _campeonatoService = campeonatoService;
            _temporadaService = temporadaService;
            _tempCampService = tempCampService;
            _timeCampeonatoService = timeCampeonatoService;
            InitializeComponent();
            Load += CadastroPartida_Load;
        }
        private void CadastroPartida_Load(object sender, EventArgs e)
        {
            CarregaCombo();

            cboTimeUm.SelectedIndexChanged += CboTimeUm_SelectedIndexChanged;
        }

        private void CboTimeUm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var timeMandante = (Times)cboTimeUm.SelectedItem;

            var timesDisponiveis = _timesService.Get<Times>()
                .Where(time => time.Id != timeMandante.Id)
                .ToList();

            cboTimeDois.DataSource = timesDisponiveis;
        }
        private void CarregaCombo()
        {
            var defaultTimeUm = new Times { Id = 0, Nome = "Escolha o mandante" };
            var timesList = _timesService.Get<Times>().ToList();
            timesList.Insert(0, defaultTimeUm);

            cboTimeUm.ValueMember = "Id";
            cboTimeUm.DisplayMember = "Nome";
            cboTimeUm.DataSource = timesList;

            var defaultTimeDois = new Times { Id = 0, Nome = "Escolha o visitante" };
            timesList = _timesService.Get<Times>().ToList();
            timesList.Insert(0, defaultTimeDois);

            cboTimeDois.ValueMember = "Id";
            cboTimeDois.DisplayMember = "Nome";
            cboTimeDois.DataSource = timesList;

            cboCamp.ValueMember = "Id";
            cboCamp.DisplayMember = "Nome";
            cboCamp.DataSource = _campeonatoService.Get<Campeonato>().ToList();

        }

        private void PreencheObjeto(Partida partida)
        {
            var camp = (Campeonato)cboCamp.SelectedItem;
            var temp = (Temporada)cboTemp.SelectedItem;
            var tempCamp = _tempCampService.Get<TempCamp>(new List<string>() { "Camp", "Temp" }).Where(x => x.Camp!.Id == camp.Id && x.Temp!.Id == temp.Id).FirstOrDefault();

            partida.Time1 = (Times)cboTimeUm.SelectedItem;
            partida.Time2 = (Times)cboTimeDois.SelectedItem;
            partida.TempCampId = tempCamp;
            partida.Gol1 = int.TryParse(txtGolUm.Text, out var gol1) ? gol1 : 0;
            partida.Gol2 = int.TryParse(txtGolDois.Text, out var gol2) ? gol2 : 0;
        }

        private void AtualizaTime(Times timeUm, Times timeDois, Partida? partida = null)
        {
            var camp = (Campeonato)cboCamp.SelectedItem;
            var temp = (Temporada)cboTemp.SelectedItem;
            var tempCamp = _tempCampService.Get<TempCamp>(new List<string>() { "Camp", "Temp" })
                .Where(x => x.Camp!.Id == camp.Id && x.Temp!.Id == temp.Id).FirstOrDefault();

            var timeUmCamp = _timeCampeonatoService.Get<TimeCampeonato>(new List<string>() { "Time", "Temp" })
                .Where(x => x.Time!.Id == timeUm.Id && x.Temp!.Id == tempCamp!.Id).FirstOrDefault();

            var timeDoisCamp = _timeCampeonatoService.Get<TimeCampeonato>(new List<string>() { "Time", "Temp" })
                .Where(x => x.Time!.Id == timeDois.Id && x.Temp!.Id == tempCamp!.Id).FirstOrDefault();

            if (int.Parse(txtGolUm.Text) > int.Parse(txtGolDois.Text))
            {
                timeUmCamp!.Golpro += int.Parse(txtGolUm.Text);
                timeUmCamp.Golcon += int.Parse(txtGolDois.Text);
                timeUmCamp.Pontos += 3;
                timeUmCamp.Vitoria += 1;

                timeDoisCamp!.Golpro += int.Parse(txtGolDois.Text);
                timeDoisCamp.Golcon += int.Parse(txtGolUm.Text);
                timeDoisCamp.Derrota += 1;
            }
            else
            {
                if (int.Parse(txtGolUm.Text) < int.Parse(txtGolDois.Text))
                {
                    timeUmCamp!.Golpro += int.Parse(txtGolUm.Text);
                    timeUmCamp.Golcon += int.Parse(txtGolDois.Text);
                    timeUmCamp.Derrota += 1;

                    timeDoisCamp!.Golpro += int.Parse(txtGolDois.Text);
                    timeDoisCamp.Golcon += int.Parse(txtGolUm.Text);
                    timeDoisCamp.Vitoria += 1;
                    timeDoisCamp.Pontos += 3;
                }
                else
                {
                    timeUmCamp!.Golpro += int.Parse(txtGolUm.Text);
                    timeUmCamp.Golcon += int.Parse(txtGolDois.Text);
                    timeUmCamp.Pontos += 1;
                    timeUmCamp.Empate += 1;

                    timeDoisCamp!.Golpro += int.Parse(txtGolDois.Text);
                    timeDoisCamp.Golcon += int.Parse(txtGolUm.Text);
                    timeDoisCamp.Empate += 1;
                    timeDoisCamp.Pontos += 1;
                }

            }
            _timeCampeonatoService.Update<TimeCampeonato, TimeCampeonato, TimeCampeonatoValidator>(timeUmCamp);
            _timeCampeonatoService.Update<TimeCampeonato, TimeCampeonato, TimeCampeonatoValidator>(timeDoisCamp);
        }

        protected override void Salvar()
        {
            try
            {

                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var partida = _partidaService.GetById<Partida>(id);
                        PreencheObjeto(partida);
                        partida = _partidaService.Update<Partida, Partida, PartidaValidator>(partida);
                        AtualizaTime(partida.Time1!, partida.Time2!);
                        MessageBox.Show("Partida salva com sucesso!", @"Henrique App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    var partida = new Partida();
                    PreencheObjeto(partida);
                    _partidaService.Add<Partida, Partida, PartidaValidator>(partida);
                    AtualizaTime(partida.Time1!, partida.Time2!);
                    MessageBox.Show("Partida salva com sucesso!", @"Henrique App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var camp = (Campeonato)cboCamp.SelectedItem;
            var tempCamp = _tempCampService.Get<TempCamp>(new List<string> { "Camp", "Temp" })
                    .Where(x => x.Camp!.Id == camp.Id).ToList();

            var temporadas = new List<Temporada>();

            foreach (var temp in tempCamp)
            {
                temporadas.Add(temp.Temp!);
            }

            cboTemp.ValueMember = "Id";
            cboTemp.DisplayMember = "Ano";
            cboTemp.DataSource = temporadas;
        }

        protected override void CarregaGrid()
        {
            partida = _partidaService.Get<PartidaModel>(new List<string> { "Time1", "Time2", "TempCampId" }).ToList();
            dataGridViewConsulta.DataSource = partida;
            dataGridViewConsulta.Columns["Id"].Visible = false;
            dataGridViewConsulta.Columns["IdTime1"].Visible = false;
            dataGridViewConsulta.Columns["IdTime2"].Visible = false;
            //dataGridViewConsulta.Columns["Time1"].Visible = false;
            dataGridViewConsulta.Columns["NomeTime1"].Visible = true;
            dataGridViewConsulta.Columns["NomeTime1"].HeaderText = "Time mandante";
            dataGridViewConsulta.Columns["NomeTime2"].Visible = true;
            dataGridViewConsulta.Columns["NomeTime2"].HeaderText = "Time visitante";
            dataGridViewConsulta.Columns["IdTempCamp"].Visible = false;
            dataGridViewConsulta.Columns["NomeCamp"].Visible = false;
            //dataGridViewConsulta.Columns["NomeCamp"].HeaderText = "Nome campeonato";
            dataGridViewConsulta.Columns["AnoTemporada"].Visible = false;
            //dataGridViewConsulta.Columns["AnoTemporada"].HeaderText = "AnoTemporada";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtGolUm.Text = linha?.Cells["Gol1"].Value.ToString();
            txtGolDois.Text = linha?.Cells["Gol2"].Value.ToString();
            cboTimeUm.SelectedValue = linha?.Cells["IdTime1"].Value;
            cboTimeDois.SelectedValue = linha?.Cells["IdTime2"].Value;
        }

        protected override void Deletar(int id)
        {
            try
            {
                _partidaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Henrique App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var camp = (Campeonato)cboCamp.SelectedItem;
            var temp = (Temporada)cboTemp.SelectedItem;
            var tempCamp = _tempCampService.Get<TempCamp>(new List<string> { "Camp", "Temp" })
                    .Where(x => x.Camp!.Id == camp.Id && x.Temp!.Id == temp.Id).FirstOrDefault();

            var times = _timeCampeonatoService.Get<TimeCampeonato>(new List<string> { "Time", "Temp" })
                .Where(x => x.Temp!.Id == tempCamp!.Id).ToList();

            var timesDisponiveis = new List<Times>();

            foreach (var time in times)
            {
                timesDisponiveis.Add(time.Time!);
            }

            cboTimeUm.ValueMember = "Id";
            cboTimeUm.DisplayMember = "Nome";
            cboTimeUm.DataSource = timesDisponiveis;

            cboTimeDois.ValueMember = "Id";
            cboTimeDois.DisplayMember = "Nome";
            cboTimeDois.DataSource = timesDisponiveis;
        }

        private void cboTimeUm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var timeMandante = (Times)cboTimeUm.SelectedItem;

            var timesDisponiveis = _timesService.Get<Times>()
                .Where(time => time.Id != timeMandante.Id)
                .ToList();

            cboTimeDois.DataSource = timesDisponiveis;
        }

        private void materialTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
