using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Ubersicht : Form  {

        Benutzer b = null;

        public Ubersicht(Benutzer b)
        {
            InitializeComponent();
            this.b = b;
        }

        private void buttonProfil_Click(object sender, EventArgs e)
        {
            Application.Run(new Profil(b));
        }

        private void buttonRaten_Click(object sender, EventArgs e)
        {
            Application.Run(new Zahlen());
        }

        private void buttonMemory_Click(object sender, EventArgs e)
        {
            Application.Run(new Memory());
        }

        private void buttonHoeher_Click(object sender, EventArgs e)
        {
            Application.Run(new Hoeher());
        }

        
    }
}
