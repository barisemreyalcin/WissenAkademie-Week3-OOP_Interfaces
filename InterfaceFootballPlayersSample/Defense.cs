using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFootballPlayersSample
{
    public class Defense : IFootballPlayer
    {
        // Bu özellikleri Display attribute/annotation ile formda gösterebilirim
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Jersey Number")]
        public int JerseyNumber { get; set; }

        private byte _shootPower;
        [Display(Name = "Shoot Power")]
        public byte ShootPower
        {
            get
            {
                return _shootPower;
            }
            set
            {
                // Normalde burada business çok bulundurmamalıyız
                if (value > 70)
                {
                    _shootPower = 70;
                    MessageBox.Show("A defense player can have maximum shoot power of 70. Shoot power set to 70!");
                } else
                {
                    _shootPower = value;
                }
            }
        }

        [Display(Name = "Reflex")]
        public byte Reflex { get; set; }

        [Display(Name = "Aggressiveness")]
        public byte Aggressiveness { get; set; }

        [Display(Name = "Stamina")]
        public byte Stamina { get; set; }

        [Display(Name = "Left Footed")]
        public bool IsLeftFooted { get; set; }

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
