using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaVirtual.Model
{
    public class EfootballObj
    {
        public string NameLiga { get; set; }
        public string Time { get; set; }
        public string Team1 { get; set; }
        public string Player1 { get; set; }
        public string Score { get; set; }
        public string Team2 { get; set; }
        public string Player2 { get; set; }

        public EfootballObj(string nameLiga, string time, string team1, string player1, string golP1, string divisor, string golP2, string score, string team2, string player2)
        {
            NameLiga = nameLiga;
            Time = time;
            Team1 = team1;
            Player1 = player1;
            Score = golP1 + divisor + golP2 + score;
            Team2 = team2;
            Player2 = player2;
        }
        public override string ToString()
        {
            return NameLiga + ";" + Time + ";" + Team1 + ";" + Player1 + ";" + Score + ";" + Team2 + ";" + Player2;
        }
    }
}
