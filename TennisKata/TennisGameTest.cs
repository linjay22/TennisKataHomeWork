using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    [TestClass]
    public class TennisGameTest
    {
        private TennisGame _tennisGame;
        
        [TestInitialize]
        public void SetUp()
        {
            _tennisGame = new TennisGame();
        }

        [TestMethod]
        public void when_game_start_should_be_love_all()
        {
            Assert.AreEqual("Love All", _tennisGame.Score());
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            GiveFirstPlayerTimes(1);
            Assert.AreEqual("Fifteen Love", _tennisGame.Score());
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GiveFirstPlayerTimes(2);
            Assert.AreEqual("Thirty Love", _tennisGame.Score());
        }

        [TestMethod]
        public void Forty_Love()
        {
            GiveFirstPlayerTimes(3);
            Assert.AreEqual("Forty Love", _tennisGame.Score());
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            GiveSecondPlayerTimes(1);
            Assert.AreEqual("Love Fifteen", _tennisGame.Score());
        }

        [TestMethod]
        public void Love_Thirty()
        {
            GiveSecondPlayerTimes(2);
            Assert.AreEqual("Love Thirty", _tennisGame.Score());
        }

        [TestMethod]
        public void Love_Forty()
        {
            GiveSecondPlayerTimes(3);
            Assert.AreEqual("Love Forty", _tennisGame.Score());
        }

        [TestMethod]
        public void Fifteen_Thirty()
        {
            GiveFirstPlayerTimes(1);
            GiveSecondPlayerTimes(2);
            Assert.AreEqual("Fifteen Thirty", _tennisGame.Score());
        }

        [TestMethod]
        public void Forty_Fifteen()
        {
            GiveFirstPlayerTimes(3);
            GiveSecondPlayerTimes(1);
            Assert.AreEqual("Forty Fifteen", _tennisGame.Score());
        }

        [TestMethod]
        public void Deuce3_3()
        {
            GiveFirstPlayerTimes(3);
            GiveSecondPlayerTimes(3);
            Assert.AreEqual("Deuce", _tennisGame.Score());
        }

        [TestMethod]
        public void Deuce4_4()
        {
            GiveFirstPlayerTimes(4);
            GiveSecondPlayerTimes(4);
            Assert.AreEqual("Deuce", _tennisGame.Score());
        }

        [TestMethod]
        public void All0_0()
        {
            Assert.AreEqual("Love All", _tennisGame.Score());
        }

        [TestMethod]
        public void All1_1()
        {
            GiveFirstPlayerTimes(1);
            GiveSecondPlayerTimes(1);
            Assert.AreEqual("Fifteen All", _tennisGame.Score());
        }

        [TestMethod]
        public void AdvFirstPlayer()
        {
            GiveFirstPlayerTimes(4);
            GiveSecondPlayerTimes(3);
            Assert.AreEqual("FirstPlayer Adv.", _tennisGame.Score());
        }

        [TestMethod]
        public void AdvSecondPlayer()
        {
            GiveFirstPlayerTimes(4);
            GiveSecondPlayerTimes(5);
            Assert.AreEqual("SecondPlayer Adv.", _tennisGame.Score());
        }

        [TestMethod]
        public void WinFirstPlayer4_0()
        {
            GiveFirstPlayerTimes(4);
            Assert.AreEqual("FirstPlayer Win.", _tennisGame.Score());
        }

        [TestMethod]
        public void WinFirstPlayer4_2()
        {
            GiveFirstPlayerTimes(4);
            GiveSecondPlayerTimes(2);
            Assert.AreEqual("FirstPlayer Win.", _tennisGame.Score());
        }

        [TestMethod]
        public void WinSecondPlayer1_4()
        {
            GiveFirstPlayerTimes(1);
            GiveSecondPlayerTimes(4);
            Assert.AreEqual("SecondPlayer Win.", _tennisGame.Score());
        }

        [TestMethod]
        public void WinFirstPlayer5_3()
        {
            GiveFirstPlayerTimes(5);
            GiveSecondPlayerTimes(3);
            Assert.AreEqual("FirstPlayer Win.", _tennisGame.Score());
        }

        [TestMethod]
        public void WinSecondPlayer4_6()
        {
            GiveFirstPlayerTimes(4);
            GiveSecondPlayerTimes(6);
            Assert.AreEqual("SecondPlayer Win.", _tennisGame.Score());
        }

        private void GiveFirstPlayerTimes(int times) 
        {
            for (int i = 0; i < times;i++ )
            {
                _tennisGame.FirstPlayerScore();
            }
        }
        private void GiveSecondPlayerTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.SecondPlayerScore();
            }
        }

    }
}
