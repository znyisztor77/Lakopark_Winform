using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lakopark_Winform
{
    public partial class Form1 : Form
    {
        List<Lakopark> lakoparkok = new List<Lakopark>();
        Adatbazis db = new Adatbazis();
        int aktualisParkIndex = 0;
        int hazKepekMeret = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //-adatok betöltése az adtbázisból
            lakoparkok = db.parkadatokBetoltese();
            parkAdatokMegjelenitese();
        }

        private void parkAdatokMegjelenitese()
        {
            panelEpuletek.Controls.Clear();
            this.Text = $"{lakoparkok[aktualisParkIndex].Lakoparkneve} lakopark adatai.";
            //pictureBox_Nevado.Image = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}{lakoparkok[aktualisParkIndex].Lakoparkneve}.jpg");
            pictureBox_Nevado.Image = lakoparkok[aktualisParkIndex].getNevadoKep();
            //PictureBox.Nevado.SizeMode = ImageLayout.Stretch;

            for (int utca = 0; utca < lakoparkok[aktualisParkIndex].Utcakszama; utca++)
            {
                for (int hazszam = 0; hazszam < lakoparkok[aktualisParkIndex].Telkekszama; hazszam++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = lakoparkok[aktualisParkIndex].getHazKep(utca, hazszam);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(hazKepekMeret,hazKepekMeret);
                    pb.Location = new Point(hazszam * hazKepekMeret, utca*hazKepekMeret);
                    pb.Tag = $"{utca}; {hazszam}";
                    pb.Click += hazraClick; // esemény kezelőnél nem kell paramétereket megadni mert rendszer automatikusan generálja
                    panelEpuletek.Controls.Add(pb);
                }
            }

            if (aktualisParkIndex == 0)
            {
                button_balraNyil.Hide();
                button_jobbraNyil.Show();

            }
            else if (aktualisParkIndex == lakoparkok.Count - 1)
            {
                button_jobbraNyil.Hide();
                button_balraNyil.Show();
            }
            else
            {
                button_balraNyil.Show();
                button_jobbraNyil.Show();
            }

        }

        private void hazraClick(object sender, EventArgs e)
        {
            // -- a hátz szinjeinek a végtelenített növelése
            PictureBox pb = (PictureBox)sender;
            string[] parameterek = pb.Tag.ToString().Split(';');
            int utca = int.Parse(parameterek[0]);
            int hazszam = int.Parse(parameterek[1]);
            //MessageBox.Show($"utca: {utca+1}, ház: {hazszam+1}");
            lakoparkok[aktualisParkIndex].Hazak[utca, hazszam]++;

            if (lakoparkok[aktualisParkIndex].Hazak[utca, hazszam]> 3) // szinteket nézümk
            {
                lakoparkok[aktualisParkIndex].Hazak[utca, hazszam] = 0;
            }
            pb.Image = lakoparkok[aktualisParkIndex].getHazKep(utca, hazszam);
        }

        private void button_jobbraNyil_Click(object sender, EventArgs e)
        {
            if (aktualisParkIndex < lakoparkok.Count-1)
            {
                aktualisParkIndex++;

            }

            parkAdatokMegjelenitese();
        }

        private void button_balraNyil_Click(object sender, EventArgs e)
        {
            if (aktualisParkIndex != 0)
            {
                aktualisParkIndex--;
            }
            parkAdatokMegjelenitese();
        }
    }
}
