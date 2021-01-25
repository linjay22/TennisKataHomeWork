using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public class TennisGame
    {
        private int _firstPlayerTime = 0;
        private int _secondPlayerTime = 0;
        private string _firstPlayerName = "FirstPlayer";
        private string _secondPlayerName = "SecondPlayer";
        public string Score()
        {
            var scoreLookup = new Dictionary<int, string>
            {
                {0,"Love"},{1,"Fifteen"},{2,"Thirty"},{3,"Forty"}
            };
            if (_firstPlayerTime < 3 || _secondPlayerTime < 3)
            {
                if (_firstPlayerTime == _secondPlayerTime)
                {
                    return string.Format("{0} All", scoreLookup[_firstPlayerTime]);
                }
                else if (_firstPlayerTime == 4)
                {
                    return string.Format("{0} Win.", _firstPlayerName);
                }
                else if (_secondPlayerTime == 4)
                {
                    return string.Format("{0} Win.", _secondPlayerName);
                }
                else
                {
                    return string.Format("{0} {1}", scoreLookup[_firstPlayerTime], scoreLookup[_secondPlayerTime]);
                }
            }            
            else if (_firstPlayerTime == 0 && _secondPlayerTime > 0)
            {
                return string.Format("Love {0}", scoreLookup[_secondPlayerTime]);
            }
            else if (_firstPlayerTime >= 3 && _secondPlayerTime >= 3)
            {
                if (_firstPlayerTime == _secondPlayerTime)
                {
                    return "Deuce";
                }
                else if (_firstPlayerTime - _secondPlayerTime == 1)
                {
                    return string.Format("{0} Adv.", _firstPlayerName);
                }
                else if (_firstPlayerTime - _secondPlayerTime == -1)
                {
                    return string.Format("{0} Adv.", _secondPlayerName);
                }
                else if (_firstPlayerTime - _secondPlayerTime == 2)
                {
                    return string.Format("{0} Win.", _firstPlayerName);
                }
                else if (_firstPlayerTime - _secondPlayerTime == -2)
                {
                    return string.Format("{0} Win.", _secondPlayerName);
                }
            }
            else if (_firstPlayerTime > 0 && _secondPlayerTime == 0)
            {
                return string.Format("{0} Love", scoreLookup[_firstPlayerTime]);
            }
            return "";
        }
        public void FirstPlayerScore()
        {
            _firstPlayerTime = _firstPlayerTime + 1;
        }
        public void SecondPlayerScore()
        {
            _secondPlayerTime = _secondPlayerTime + 1;
        }
    }
}
