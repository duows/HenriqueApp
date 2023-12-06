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

namespace HenriqueApp.App.Cadastros
{
    public partial class CadastroPartida : CadastroBase
    {
        private readonly IBaseService<Partida> _partidaService;
        private readonly IBaseService<Times> _timesService;
        private readonly IBaseService<Campeonato> _campeonatoService;
        private readonly IBaseService<Temporada> _temporadaService;
        private readonly IBaseService<TempCamp> _tempCampService;
        private readonly IBaseService<TimeCampeonato> _timeCampeonatoService;

        private List<Partida>? partida;

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

        private void AtualizaTime(Times time)
        {
            var camp = (Campeonato)cboCamp.SelectedItem;
            var temp = (Temporada)cboTemp.SelectedItem;
            var tempCamp = _tempCampService.Get<TempCamp>(new List<string>() { "Camp", "Temp" }).Where(x => x.Camp!.Id == camp.Id && x.Temp!.Id == temp.Id).FirstOrDefault();


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
                    }
                }
                else
                {
                    var partida = new Partida();
                    PreencheObjeto(partida);
                    _partidaService.Add<Partida, Partida, PartidaValidator>(partida);
                }

                MessageBox.Show("Partida salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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
    }
}
