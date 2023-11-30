﻿using HenriqueApp.App.Base;
using HenriqueApp.Domain.Base;
using HenriqueApp.Domain.Entities;
using HenriqueApp.Service.Validators;
using ReaLTaiizor.Controls;
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
    public partial class CadastroCampeonato : CadastroBase
    {
        private readonly IBaseService<Campeonato> _campeonatoService;

        private List<Campeonato>? campeonato;

        public CadastroCampeonato(IBaseService<Campeonato> campeonatoService)
        {
            _campeonatoService = campeonatoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Campeonato campeonato)
        {
            //campeonato.Nome = txtNome.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {/*
                    if (int.TryParse(txtId., out var id))
                    {
                        var campeonatos = _campeonatoService.GetById<Campeonato>(id);
                        PreencheObjeto(campeonatos);
                        campeonatos = _campeonatoService.Update<Campeonato, Campeonato, CampeonatoValidator>(campeonatos);
                    }*/
                }
                else
                {
                    var campeonatos = new Campeonato();
                    PreencheObjeto(campeonatos);
                    _campeonatoService.Add<Campeonato, Campeonato, CampeonatoValidator>(campeonatos);
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
                _campeonatoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Henrique App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            campeonato = _campeonatoService.Get<Campeonato>().ToList();
            dataGridViewConsulta.DataSource = campeonato;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            //txtId.Text = linha?.Cells["Id"].Value.ToString();
            //txtNome.Text = linha?.Cells["Nome"].Value.ToString();
        }

    }
}