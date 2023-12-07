using AutoMapper;
using HenriqueApp.App.Cadastros;
using HenriqueApp.App.Models;
using HenriqueApp.App.Outros;
using HenriqueApp.Domain.Base;
using HenriqueApp.Domain.Entities;
using HenriqueApp.Repository.Context;
using HenriqueApp.Repository.Repository;
using HenriqueApp.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueApp.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("C:\\Users\\aluno\\source\\repos\\duows\\HenriqueApp\\HenriqueApp.App\\Config\\DatabaseSetting.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Campeonato>, BaseRepository<Campeonato>>();
            Services.AddScoped<IBaseRepository<Jogadores>, BaseRepository<Jogadores>>();
            Services.AddScoped<IBaseRepository<Partida>, BaseRepository<Partida>>();
            Services.AddScoped<IBaseRepository<TempCamp>, BaseRepository<TempCamp>>();
            Services.AddScoped<IBaseRepository<Temporada>, BaseRepository<Temporada>>();
            Services.AddScoped<IBaseRepository<TimeCampeonato>, BaseRepository<TimeCampeonato>>();
            Services.AddScoped<IBaseRepository<Times>, BaseRepository<Times>>();

            // Services
            Services.AddScoped<IBaseService<Campeonato>, BaseService<Campeonato>>();
            Services.AddScoped<IBaseService<Jogadores>, BaseService<Jogadores>>();
            Services.AddScoped<IBaseService<Partida>, BaseService<Partida>>();
            Services.AddScoped<IBaseService<TempCamp>, BaseService<TempCamp>>();
            Services.AddScoped<IBaseService<Temporada>, BaseService<Temporada>>();
            Services.AddScoped<IBaseService<TimeCampeonato>, BaseService<TimeCampeonato>>();
            Services.AddScoped<IBaseService<Times>, BaseService<Times>>();

            // Formulários
            Services.AddTransient<TabelaClassificacao, TabelaClassificacao>();
            Services.AddTransient<SaoPaulo, SaoPaulo>();
            Services.AddTransient<CadastroCampeonato, CadastroCampeonato>();
            Services.AddTransient<CadastroTemporada, CadastroTemporada>();
            Services.AddTransient<CadastroJogadores, CadastroJogadores>();
            Services.AddTransient<CadastroPartida, CadastroPartida>();
            Services.AddTransient<CadastroTimeCampeonato, CadastroTimeCampeonato>();
            Services.AddTransient<CadastroTimes, CadastroTimes>();
            Services.AddTransient<CadastroCampeonatoTemporadaTempCamp, CadastroCampeonatoTemporadaTempCamp>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Campeonato, CampeonatoModel>();
                config.CreateMap<Jogadores, JogadoresModel>()
                    .ForMember(d => d.IdTime, d => d.MapFrom(x => x.Time!.Id))
                    .ForMember(d => d.NomeTime, d => d.MapFrom(x => $"{x.Time!.Nome}"));
                config.CreateMap<Partida, PartidaModel>()
                    .ForMember(d => d.IdTempCamp, d => d.MapFrom(x => x.TempCampId!.Id))
                    .ForMember(d => d.NomeCamp, d => d.MapFrom(x => $"{x.TempCampId!.Camp!.Nome}"))
                    .ForMember(d => d.AnoTemporada, d => d.MapFrom(x => $"{x.TempCampId!.Temp!.Ano}"))
                    .ForMember(d => d.IdTime1, d => d.MapFrom(x => x.Time1!.Id))
                    .ForMember(d => d.NomeTime1, d => d.MapFrom(x => $"{x.Time1!.Nome}"))
                    .ForMember(d => d.IdTime2, d => d.MapFrom(x => x.Time2!.Id))
                    .ForMember(d => d.NomeTime2, d => d.MapFrom(x => $"{x.Time2!.Nome}"));
                config.CreateMap<TempCamp, TempCampModel>()
                    .ForMember(d => d.IdTemporada, d => d.MapFrom(x => x.Temp!.Id))
                    .ForMember(d => d.AnoTemporada, d => d.MapFrom(x => $"{x.Temp!.Ano}"))
                    .ForMember(d => d.IdCampeonato, d => d.MapFrom(x => x.Camp!.Id))
                    .ForMember(d => d.NomeCampeonato, d => d.MapFrom(x => $"{x.Camp!.Nome}"));
                config.CreateMap<Temporada, TemporadaModel>();
                config.CreateMap<TimeCampeonato, TimeCampeonatoModel>()
                    .ForMember(d => d.IdTime, d => d.MapFrom(x => x.Time!.Id))
                    .ForMember(d => d.NomeTime, d => d.MapFrom(x => x.Time!.Nome))
                    .ForMember(d => d.IdTempCamp, d => d.MapFrom(x => x.Temp!.Id));
                config.CreateMap<Times, TimesModel>();

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
