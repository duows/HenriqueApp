using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using HenriqueApp.Domain.Entities;

namespace HenriqueApp.Teste
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCampeonato()
        {
            var campeonato = new Campeonato();

            campeonato.Nome = "Revoada";

            Console.WriteLine(JsonSerializer.Serialize(campeonato));
            Assert.AreEqual(campeonato.Nome, "Revoada");

        }
        [TestMethod]
        public void TestJogadores()
        {
            var jogador = new Jogadores();
            var time = new Times();

            time.Nome = "São Paulo";

            jogador.Nome = "Luciano";
            jogador.Gols = 75;
            jogador.Idade = 31;
            jogador.Assist = 25;
            jogador.Capitao = 0;
            jogador.Time = time;

            Console.WriteLine(JsonSerializer.Serialize(jogador));
            Assert.AreEqual(jogador.Nome, "Luciano");
            Assert.AreEqual(jogador.Gols, 75);
            Assert.AreEqual(jogador.Idade, 31);
            Assert.AreEqual(jogador.Assist, 25);
            Assert.AreEqual(jogador.Capitao, 0);
            Assert.AreEqual(jogador.Time.Nome, time.Nome);

        }
        [TestMethod]
        public void TestPartida()
        {
            var partida = new Partida();
            var time1 = new Times();
            var time2 = new Times();
            var tempCamp = new TempCamp();
            var temp = new  Temporada();
            var camp = new Campeonato();
            var timeCampeonato1 = new TimeCampeonato();
            var timeCampeonato2 = new TimeCampeonato();


            time1.Nome = "São Paulo";
            time2.Nome = "Corinthians";

            temp.Ano = "2025";

            camp.Nome = "Brasileirão";

            tempCamp.Premio = "Nada";
            tempCamp.Temp = temp;
            tempCamp.Camp = camp;
            tempCamp.Campeao = "São Paulo";

            timeCampeonato1.Time = time1;
            timeCampeonato1.Temp = tempCamp;
            timeCampeonato1.Pontos = 100;
            timeCampeonato1.Posicao = 1;
            timeCampeonato1.Golpro = 50;
            timeCampeonato1.Golcon = 0;

            timeCampeonato2.Time = time2;
            timeCampeonato2.Temp = tempCamp;
            timeCampeonato2.Pontos = 0;
            timeCampeonato2.Posicao = 20;
            timeCampeonato2.Golpro = 0;
            timeCampeonato2.Golcon = 30;

            partida.Data = DateTime.Today;
            partida.TempCampId = tempCamp;
            partida.Gol1 = 10;
            partida.Gol2 = 0;
            partida.Time1 = time1;
            partida.Time2 = time2;


            Console.WriteLine(JsonSerializer.Serialize(partida));
            Assert.AreEqual(partida.Data, DateTime.Today);
            Assert.AreEqual(partida.TempCampId, tempCamp);
            Assert.AreEqual(partida.Gol1, 10);
            Assert.AreEqual(partida.Gol2, 0);
            Assert.AreEqual(partida.Time1, time1);
            Assert.AreEqual(partida.Time2, time2);

        }
        [TestMethod]
        public void TestTempCamp()
        {
            var tempCamp = new TempCamp();
            var timeCampeonato = new TimeCampeonato();
            var temp = new Temporada();
            var camp = new Campeonato();
            var time = new Times();

            time.Nome = "São paulo";

            tempCamp.Premio = "Nada";
            tempCamp.Temp = temp;
            tempCamp.Camp = camp;
            tempCamp.Campeao = "São Paulo";

            timeCampeonato.Time = time;
            timeCampeonato.Temp = tempCamp;
            timeCampeonato.Pontos = 100;
            timeCampeonato.Posicao = 1;
            timeCampeonato.Golpro = 50;
            timeCampeonato.Golcon = 0;

            temp.Ano = "2025";

            camp.Nome = "Brasileirão";

            tempCamp.Premio = "Nada";
            tempCamp.Temp = temp;
            tempCamp.Camp = camp;
            tempCamp.Campeao = "São Paulo";

            Console.WriteLine(JsonSerializer.Serialize(tempCamp));
            Assert.AreEqual(tempCamp.Premio, "Nada");
            Assert.AreEqual(tempCamp.Temp, temp);
            Assert.AreEqual(tempCamp.Camp, camp);
            Assert.AreEqual(tempCamp.Campeao, "São Paulo");

        }
        [TestMethod]
        public void TestTemporada()
        {
            var temporada = new Temporada();


            temporada.Ano = "2010";

            Console.WriteLine(JsonSerializer.Serialize(temporada));
            Assert.AreEqual(temporada.Ano, "2010");

        }
        [TestMethod]
        public void TestTimeCampeonato()
        {
            var timeCampeonato = new TimeCampeonato();
            var time = new Times();
            var tempCamp = new TempCamp();
            var temp = new Temporada();
            var camp = new Campeonato();

            temp.Ano = "2025";
            camp.Nome = "Brasileirão";
            time.Nome = "São paulo";

            tempCamp.Premio = "Nada";
            tempCamp.Temp = temp;
            tempCamp.Camp = camp;
            tempCamp.Campeao = "São Paulo";

            timeCampeonato.Time = time;
            timeCampeonato.Temp = tempCamp;
            timeCampeonato.Pontos = 100;
            timeCampeonato.Posicao = 1;
            timeCampeonato.Golpro = 100;
            timeCampeonato.Golcon = 0;


            Console.WriteLine(JsonSerializer.Serialize(timeCampeonato));
            Assert.AreEqual(timeCampeonato.Time, time);
            Assert.AreEqual(timeCampeonato.Temp, tempCamp);
            Assert.AreEqual(timeCampeonato.Pontos, 100);
            Assert.AreEqual(timeCampeonato.Posicao, 1);
            Assert.AreEqual(timeCampeonato.Golpro, 100);
            Assert.AreEqual(timeCampeonato.Golcon, 0);
        }
        [TestMethod]
        public void TestTimes()
        {
            var time = new Times();

            time.Nome = "São Paulo";

            Console.WriteLine(JsonSerializer.Serialize(time));
            Assert.AreEqual(time.Nome, "São Paulo");
        }
    }
}
