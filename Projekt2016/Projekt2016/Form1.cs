using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;
using ModelProjekt;

namespace Projekt2016
{
    public partial class Form1 : Form
    {
        DTO dto = null;
        List<Benutzer> bentzer = null;

        Benutzer utzi = null;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            dto = new DTO();
            bentzer = new List<Benutzer>();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bentzer = dto.BenutzerAuslesen();

            int i = 0;

            if (bentzer != null) {

                while (bentzer.Count > i)
                {

                    i++;

                    if (bentzer.ElementAt(i).Benutzername == textBoxBenutzer.Text) ;

                    utzi = bentzer.ElementAt(i);

                    Application.Run(new Ubersicht());

                    break;
                }

            } 


        }
    }
}
