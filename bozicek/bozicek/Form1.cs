using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Media;

namespace bozicek
{
    public partial class okno : Form
    {
        bool levo;
        bool desno;
        //začetne hitrosti
        public int zacHitrostBoz = 20;
        public int zacHitrostDaril = 5;
        //hitrosti, ki se spreminjajo
        public int hitrostBoz;
        public int hitrostDaril;

        public int zivljenja = 0;

        int stTock = 0;

        //zvok, 
        //ko pobere darilo
        private SoundPlayer zvok1 = new SoundPlayer(Properties.Resources.kaplja);
        //bombe
        private SoundPlayer zvok2 = new SoundPlayer(Properties.Resources.zvokBombe);
        //ko ne pobere darila
        private SoundPlayer zvok3 = new SoundPlayer(Properties.Resources.padeMimo);
        //konec
        private SoundPlayer zvokHoHo = new SoundPlayer(Properties.Resources.ho_ho_ho);
        //melodija
        private SoundPlayer uvodnaMuska = new SoundPlayer(Properties.Resources.melodija);

        Random nakl = new Random();
        bool zacetek = true;

        //rezultati
        List<Tuple<string, int>> lestvica = new List<Tuple<string, int>>();


        public void zivljenjeSlike(int zivljenja)
        {//glede na število življenj doda število slike
            if (zivljenja == 1) {  zivljenje1.Image = Properties.Resources.zivljenje; zivljenje2.Visible = false; zivljenje3.Visible = false; }
            else if( zivljenja == 2) {  zivljenje1.Image = Properties.Resources.zivljenje; zivljenje2.Image = Properties.Resources.zivljenje; zivljenje3.Visible = false; }
            else if (zivljenja ==3) { zivljenje1.Visible = true; zivljenje2.Visible = true; zivljenje3.Visible = true; zivljenje1.Image = Properties.Resources.zivljenje; zivljenje2.Image = Properties.Resources.zivljenje; zivljenje3.Image = Properties.Resources.zivljenje; }
            else if( zivljenja ==0){ zivljenje1.Visible = false; zivljenje2.Visible = false;zivljenje3.Hide(); }
        }
        

        public okno()
        {
            InitializeComponent();
            bozicek.Image = Properties.Resources.bozicekL;
            darilo.Image = Properties.Resources.darilo1;
            bomba.Image = Properties.Resources.bomba;
            bozicek.Visible = false;
            konec.Visible = false;
            znova.Visible = false;

            //fiksiramo velikost
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            //uvodni pozdrav in navodilo za igranje 
            uvod.Text = " Pomagaj božičku pri pobiranju daril \n pazi, da ne pobereš bombe! \n Premikaš se z tipkami 'A' in 'D'";
            uvodnaMuska.Play();
        }



        //premikanje človečka
        private void časBožička_Tick(object sender, EventArgs e)
        {
            //da božiček ne zapusti okna
            if (bozicek.Left < ozadje.Left+200) { levo = false;  }
            if (bozicek.Right > ozadje.Right - 200) { desno = false; }
            //premik
            if (levo) { bozicek.Left -= hitrostBoz; }
            if (desno) { bozicek.Left += hitrostBoz; }
        }
        //pritisk na gumb
        private void okno_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A || e.KeyCode==Keys.NumPad4) { levo = true; bozicek.Image = Properties.Resources.bozicekL;  }
            if(e.KeyCode == Keys.D || e.KeyCode == Keys.NumPad6) { desno = true; bozicek.Image = Properties.Resources.bozicekD; }
        }
        //ko gumb spustiš
        private void okno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.NumPad4) { levo = false; }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.NumPad6) { desno = false; }
        }
        //pritisk na start gumb
        private void START_Click(object sender, EventArgs e)
        {
            zacetekIgre();
            uvod.Hide();
            uvodnaMuska.Stop();
        }
        private  Image Slike()
        {// seznam vseh daril 
            List<Image> slike = new List<Image>();
            slike.Add(Properties.Resources.darilo1);
            slike.Add(Properties.Resources.darilo2);
            slike.Add(Properties.Resources.darilo3);
            slike.Add(Properties.Resources.darilo4);
            slike.Add(Properties.Resources.darilo5);
            slike.Add(Properties.Resources.darilo6);
            slike.Add(Properties.Resources.darilo7);
            slike.Add(Properties.Resources.darilo8);
            //naključni števec
            int št= nakl.Next(0,slike.Count);
            return slike[št];
        }
        
        private void padanjeDaril_Tick(object sender, EventArgs e)
        {
            zivljenjeSlike(zivljenja);
            darilo.Top += hitrostDaril;

            if (darilo.Top > bozicek.Top - darilo.Height
              && darilo.Left + darilo.Width > bozicek.Left
              && darilo.Left < bozicek.Left + bozicek.Width)
            {//bozicek pobere darilo

                darilo.Top = ozadje.Top - darilo.Top;
                darilo.Left = nakl.Next(ozadje.Left + 300, ozadje.Right - 300);
                stTock += 1;
                rezultat.Text = stTock.ToString();
                zacetek = false;
                darilo.Image = Slike();
                hitrostDaril += 1;
                hitrostBoz += 1;
                zvok1.Play();

            }


            else if (darilo.Top > bozicek.Top)
            //če darila ni pobral
            {
                //izgubi življenje 
                zivljenja -= 1;
                zacetek = false;
                darilo.Top = ozadje.Top - darilo.Top;
                darilo.Left = nakl.Next(ozadje.Left + 300, ozadje.Right - 300);
                zvok3.Play();


            }
            //če nima več življenj, umre, ze zaključi igra
            else if (zivljenja == 0 && zacetek == false)
            {
                konecIgre();

            }
        }
        private void konecIgre()
        {
            //ustavimo štoparce
            časBožička.Stop();
            padanjeDaril.Stop();
            padanjeBombe.Stop();

            //prikažemo/skrijemo objekte
            bozicek.Visible = false;
            konec.Visible = true;
            znova.Visible = true;
            rezultat.Visible = false;
            bomba.Visible = false;
            darilo.Visible = false;

            gumbIme.Show();
            ime.Show();
            ime.Focus();
            // izpis rezultata
            konec.Text = konec.Text;
            lblLestvica.Show();
  
            
            //slike življenj se izbrišejo
            zivljenjeSlike(0);

            //zvok ho ho ho
            zvokHoHo.Play();
        }

        //funkcija za začetek igre
        private void zacetekIgre()
        {
            //nastavimo vse objekte, da so vidni
            bozicek.Visible = true;
            rezultat.Visible = true;
            bomba.Visible = true;
            darilo.Visible = true;

            //oziroma nevidni
            START.Visible = false;
            konec.Visible = false;
            znova.Visible = false;
            lblLestvica.Visible = false;

            //zaženemo vse štoparce, da se objekti premikajo
            časBožička.Start();
            padanjeDaril.Start();
            padanjeBombe.Start();


            //poenostavimo življenja in rezultat
            zivljenja = 3;
            stTock = 0;
            zivljenjeSlike(zivljenja);
            rezultat.Text = stTock.ToString();

            //hitrost gre nazaj na začetno
            hitrostBoz = zacHitrostBoz;
            hitrostDaril = zacHitrostDaril;

            //darilo in bombo postavimo nekam nad okno
            darilo.Left = nakl.Next(ozadje.Left + 300, ozadje.Right - 300);
            darilo.Top = ozadje.Top;

            bomba.Top = ozadje.Top - nakl.Next(800, 2500);
            bomba.Left = nakl.Next(ozadje.Left + 300, ozadje.Right - 300);


        }

        private void znova_Click(object sender, EventArgs e)
        {
            zacetekIgre();
        }

        private void pauza_Click(object sender, EventArgs e)
        {
            //gumb za premor
            if (pavza.Text == "pavza")
            {
                pavza.Text = "start";
                padanjeDaril.Stop();
                časBožička.Stop();
                padanjeBombe.Stop();
            }
            else
            {//če se pauza izvaja in kliknemo na gumb
                pavza.Text = "pavza";
                padanjeDaril.Start();
                časBožička.Start();
                padanjeBombe.Start();
            }
            
           
        }

        //bomba
        private void padanjeBombe_Tick(object sender, EventArgs e)
        {
            bomba.Top += hitrostDaril;
            //če je bomba na tleh
            if (bomba.Top + bomba.Height > ozadje.Height)
            {
                //naključna višina bombe
                bomba.Top = ozadje.Top - nakl.Next(800, 2500);
                bomba.Left = nakl.Next(ozadje.Left + 300, ozadje.Right - 300);
            }
            else if (bomba.Top > bozicek.Top - bomba.Height
                && bomba.Left + bomba.Width > bozicek.Left
                && bomba.Left < bozicek.Left + bozicek.Width)
            {
                //če je pobral bombo
                zvok2.Play();
                konecIgre();
            }

        }

        private void gumbIme_Click(object sender, EventArgs e)
        {
            string niz = "Lestvica: \n";

            if (ime.Text.Length == 0)
            {
                lblLestvica.Text = niz;
                ime.Text = "";
                ime.Hide();
                gumbIme.Hide();
            }
            else 
            {
                lestvica.Add(Tuple.Create(ime.Text, stTock));
                lestvica = lestvica.OrderBy(i => i.Item2).ToList();
                lestvica.Reverse();

                foreach (Tuple<string, int> vnos in lestvica)
                {

                    niz += vnos.Item1.ToString() + ".................." + vnos.Item2.ToString() + "\n";
                }
                lblLestvica.Text = niz;
                ime.Text = "";
                ime.Hide();
                gumbIme.Hide();
            }



        }
        }
}
