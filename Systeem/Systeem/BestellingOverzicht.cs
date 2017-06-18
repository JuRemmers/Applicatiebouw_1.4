using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Model;

namespace Systeem
{
    public partial class BestellingOverzicht : Form
    {
        int bestellingid;
        public BestellingOverzicht(int bestellingid)
        {
            this.bestellingid = bestellingid;
            InitializeComponent();
            Bestellinglist(bestellingid);
            
            cb_status.Items.Add("Onderhande");
            cb_status.Items.Add("Opgenomen");
            cb_status.Items.Add("Gereed");
            cb_status.Items.Add("Uitgeserveerd");
        }

        public void Bestellinglist(int bestellingid)
        {
            clb_besteIitems.Items.Clear();
            int bestelId = bestellingid;
            BestellingService service = new BestellingService();
            List<BestelItem> bestellingen = service.GetAllForItems(bestelId);                                   
            //TafelOverzicht tafel = new TafelOverzicht();            
            

            foreach (BestelItem i in bestellingen)
            {                
                DateTime tijd1 = DateTime.Now;
                TimeSpan wachttijd = tijd1.Subtract(i.tijd);
                string sa = i.item.product;
                string sa2 = i.aantal.ToString();
                string sa3 = i.status.ToString();
                string sa4 = Math.Round(wachttijd.TotalMinutes, 0).ToString();
                ListViewItem listview = new ListViewItem(sa);
                listview.SubItems.Add(sa2);
                listview.SubItems.Add(sa4);
                listview.SubItems.Add(sa3);
                listview.Tag = i.opmerking;
                clb_besteIitems.Items.Add(listview);

                // Kayleigh Vossen, zorgt ervoor dat uitgeserveerd andere kleur krijgt
                if (i.status == Status.Uitgeserveerd)
                {
                    listview.ForeColor = Color.ForestGreen;
                    continue;
                }

                int categorie = i.item.Categorie.menu.id;

                if (categorie == 1)
                {
                    //true is drank

                    TimeSpan maxtijd = new TimeSpan(0, 15, 0);
                    TimeSpan midtijd = new TimeSpan(0, 5, 0);
                    if (wachttijd.TotalMinutes > maxtijd.TotalMinutes)
                    {
                        listview.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (wachttijd.TotalMinutes > midtijd.TotalMinutes)
                        {
                            listview.ForeColor = Color.Orange;
                        }
                        else
                        {
                            listview.ForeColor = Color.Black;
                        }
                    }
                }
                else
                {
                    //false is eten

                    TimeSpan maxtijd = new TimeSpan(0, 60, 0);
                    TimeSpan midtijd = new TimeSpan(0, 30, 0);
                    if (wachttijd.TotalMinutes > maxtijd.TotalMinutes)
                    {
                        listview.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (wachttijd.TotalMinutes > midtijd.TotalMinutes)
                        {
                            listview.ForeColor = Color.Orange;
                        }
                        else
                        {
                            listview.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btn_aanpassen_Click(object sender, EventArgs e)
        {
            try
            {
                Status updatestatus = Status.Gereed;
                string gerecht = clb_besteIitems.SelectedItems[0].Text;
                updatestatus = (Status)Enum.Parse(typeof(Status), cb_status.SelectedItem.ToString());
                BestellingService service = new BestellingService();
                service.UpdateStatus(bestellingid, updatestatus, gerecht);
                Bestellinglist(bestellingid);
            }

            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bestellinglist(bestellingid);
        }

        // Kayleigh Vossen, toont opmerking bij bestelitem in bestelling overzicht
        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_status.SelectedItem.ToString()==Status.Onderhande.ToString())
            {
                if(clb_besteIitems.SelectedItems[0].Tag.ToString() != "")
                {
                    MessageBox.Show(clb_besteIitems.SelectedItems[0].Tag.ToString());
                }
            }
        }
    }
}
