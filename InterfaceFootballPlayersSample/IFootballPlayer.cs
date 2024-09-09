using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFootballPlayersSample
{
    interface IFootballPlayer
    {
        string FullName { get; set; }
        int JerseyNumber { get; set; }
        byte ShootPower { get; set; }
        byte Reflex { get; set; }
        byte Aggressiveness { get; set; }
        bool IsLeftFooted { get; set; }
        string Shoot();
        string MarkTheOpponent(); // Normalde bu her oyuncu için geçerli değil amacımız ortak şeyleri sıralamak, ama şu an önemsemiyoruz
        string GetInjured();
    }
}
