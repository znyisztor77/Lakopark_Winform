using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lakopark_Winform
{
    public partial class Form1 : Form
    {
        List<Lakopark> lakoparkok = new List<Lakopark>();
        Adatbazis db = new Adatbazis();
        int aktualisParkIndex = 0;
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
            this.Text = $"{lakoparkok[aktualisParkIndex].Lakoparkneve} lakopark adatai.";


        }
    }
}
