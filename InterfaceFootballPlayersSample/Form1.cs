using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.InteropServices;

namespace InterfaceFootballPlayersSample
{
    public partial class Form1 : Form
    {
        Goalkeeper muslera = new Goalkeeper
        {
            FullName = "Fernando Muslera",
            Aggressiveness = 60,
            Stamina = 85,
            BallControlWithHands = 95,
            JerseyNumber = 1,
            Reflex = 90,
            IsLeftFooted = false,
            ShootPower = 60,
        };

        Goalkeeper livakovic = new Goalkeeper
        {
            FullName = "Dominik Livakovic",
            Aggressiveness = 58,
            Stamina = 85,
            BallControlWithHands = 90,
            JerseyNumber = 1,
            Reflex = 85,
            IsLeftFooted = false,
            ShootPower = 56,
        };

        Defense kohn = new Defense
        {
            FullName = "Derrick Köhn",
            Aggressiveness = 74,
            Stamina = 90,
            JerseyNumber = 17,
            Reflex = 75,
            IsLeftFooted = false,
            ShootPower = 72,
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lstFootballers.Items.Add(muslera);
            //lstFootballers.Items.Add(livakovic.FullName);
            //lstFootballers.Items.Add(kohn.FullName);

            lstFootballers.Items.Add(muslera);
            lstFootballers.Items.Add(livakovic);
            lstFootballers.Items.Add(kohn);
            // Default ToString olaný listbox'a ekliyor
        }

        // Bu event list box'ýn SelectedIndexChanged property'sine çift týklayýnca gelir
        private void lstFootballers_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpFootballerAttributes.Controls.Clear();

            // Reflection
            // Seçili item var mý? Varsa ilgili interface'den mi türetilmiþ?
            if (lstFootballers.SelectedItem != null && lstFootballers.SelectedItem.GetType().GetInterface("IFootballPlayer") != null)
            {

                // Listbox itemleri interface'imden türediði için bir cast iþlemi gerek
                IFootballPlayer selectedPlayer = (IFootballPlayer)lstFootballers.SelectedItem;
                PropertyInfo[] properties = selectedPlayer.GetType().GetProperties();
                foreach (PropertyInfo item in properties)
                {
                    // Runtime'da bir control tanýmlýyorum
                    Label lbl = new Label();
                    lbl.Text = item.GetCustomAttribute<DisplayAttribute>().Name + ": " + item.GetValue(selectedPlayer);
                    // item.GetValue(selectedPlayer) item value'sini selectedPlayer üzerinden alýr (reflection)

                    lbl.AutoSize = false;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    lbl.Width = flpFootballerAttributes.Width - 4;

                    flpFootballerAttributes.Controls.Add(lbl);
                }
            }
        }
    }
}
