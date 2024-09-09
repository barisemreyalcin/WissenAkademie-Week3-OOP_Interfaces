using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFootballPlayersSample
{
    public class Goalkeeper : IFootballPlayer
    {
        // Bu özellikleri Display attribute/annotation ile formda gösterebilirim
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Jersey Number")]
        public int JerseyNumber { get; set; }

        [Display(Name = "Shoot Power")]
        public byte ShootPower { get; set; }

        [Display(Name = "Reflex")]
        public byte Reflex { get; set; }

        [Display(Name = "Stamina")]
        public byte Stamina { get; set; }

        [Display(Name = "Aggressiveness")]
        public byte Aggressiveness { get; set; }

        [Display(Name = "Left Footed")]
        public bool IsLeftFooted { get; set; }

        [Display(Name = "Ball Control with Hands")]
        public byte BallControlWithHands { get; set; }


        public string GetInjured()
        {
            return "Player got injured";
        }

        public string MarkTheOpponent()
        {
            return "Player marked the opponent";
        }

        public string Shoot()
        {
            return "Player shot the ball";
        }

        public override string ToString()
        {
            return $"{JerseyNumber} - {FullName}";
        }
    }
}
