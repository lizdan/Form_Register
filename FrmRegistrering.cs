using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift_3
{
    public partial class FrmRegistrering : Form
    {
        public FrmRegistrering()
        {
            InitializeComponent();
        }


          //Metod som körs när användaren klickar på "Registrera" i menyn.
        private void MenuStripRegistrera_Click(object sender, EventArgs e)
        {
              //Avaktivera rubriken och textboxen för "resultat".
            lblResultat.Enabled = false;
            tbxResultat.Enabled = false;
              //Töm resultatrutan.
            tbxResultat.Text = "";
              //Aktiva gruppbox för inmatning samt 
            gbxPersUppg.Enabled = true;
              //Sätt markören i första textrutan.
            tbxFörnamn.Focus();
        }


          //Metod som körs när användaren klickar på "Avsluta". Avslutar programmet.
        private void MenuStripAvsluta_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }


          //Metod som utförs när använden klickar på knappen "OK".
        private void BtnOK_Click(object sender, EventArgs e)
        {
              //Aktivera texten "Resutlat" samt textrutan.
            lblResultat.Enabled = true;
            tbxResultat.Enabled = true;

              //Skapa ny instans av klassen Person.
            Person nyPerson = new Person();

              //Hämta input från användaren, spara medlemsvariablerna med nya insatsen.
            nyPerson.Förnamn = tbxFörnamn.Text;
            nyPerson.Efternamn = tbxEfternamn.Text;
            nyPerson.PersNr = tbxPersNr.Text;


              //Anropa metod som kontrollerar personnummret. Fortsätt om det returnerade värdet är felmeddelandet.
            if (nyPerson.persNrKontroll(nyPerson.PersNr).Equals(nyPerson.FEL_MEDDELANDE))
            {
                tbxResultat.Text = nyPerson.FEL_MEDDELANDE;
            }


              //Anropa metod som kontrollerar personnummret. Fortsätt om det returnerade värdet är "PersNr".
              //Skriv ut alla värden samt anropa metod som kontrollerar samt skriver ut vilket kön personen är.
            else if (nyPerson.persNrKontroll(nyPerson.PersNr).Equals(nyPerson.PersNr))
            {
                tbxResultat.Text = ("Förnamn: " + nyPerson.Förnamn + "\r\n");
                tbxResultat.Text += ("Efternamn: " + nyPerson.Efternamn + "\r\n");
                tbxResultat.Text += ("Personnummer: " + nyPerson.PersNr + "\r\n");
                tbxResultat.Text += nyPerson.kollAvKön(nyPerson.PersNr);
            }


              //Töm alla textrutor.
            tbxFörnamn.Text = "";
            tbxEfternamn.Text = "";
            tbxPersNr.Text = "";

              //Avaktivera gruppboxen.
            gbxPersUppg.Enabled = false;
        }

        
    }
}
