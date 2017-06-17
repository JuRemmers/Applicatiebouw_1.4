using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;


// Kayleigh Vossen
namespace Systeem
{
    public partial class RekeningOverzicht : Form
    {
        private int tafelId;
        private List<BestelItem> items;
        private Rekening r;
        private TafelService t = new TafelService();
        private TafelOverzicht tafeloverzicht = new TafelOverzicht();   

        public RekeningOverzicht(int tafelId)
        {
            InitializeComponent();
            this.tafelId = tafelId;
            lbl_tafelnummer.Text = "Tafel " + tafelId;
            lbl_tafelnummer2.Text = "Tafel " + tafelId;
            RekeningService s = new RekeningService();
            items = s.GetBestellingByTafelId(tafelId);
            if (!items.Any())
            {
                btn_afrekenen.Enabled = false;
                tabControl1.TabPages.Remove(tp_rekening);
            }
            InitList(items);
            InitRekening(items);

            lbl_Tafelstatus.Text = t.TafelStatus(tafelId).ToString();
            if(t.TafelStatus(tafelId) == false)
            {
                lbl_Tafelstatus.Text = "Tafel " + tafelId + ": Vrij";                

            }
            else
            {
                lbl_Tafelstatus.Text = "Tafel " + tafelId + ": Bezet";
            }
        }

        private void InitList(List<BestelItem> items)
        {
            foreach(BestelItem i in items)
            {
                string sa = i.aantal.ToString();
                string sa2 = i.item.product;
                string sa3 = "€ " + (i.item.prijs*i.aantal).ToString("0.00");
                ListViewItem lvi = new ListViewItem(sa);
                
                lvi.SubItems.Add(sa2);
                lvi.SubItems.Add(sa3);
                lv_bestelitems.Items.Add(lvi);                
            }
        }

        private void InitRekening(List<BestelItem> items)
        {
            foreach (BestelItem i in items)
            {
                string sa = i.aantal.ToString();
                string sa2 = i.item.product;
                string sa3 = "€ " + (i.item.prijs * i.aantal).ToString("0.00");
                ListViewItem lvi = new ListViewItem(sa);

                lvi.SubItems.Add(sa2);
                lvi.SubItems.Add(sa3);                
                listView2.Items.Add(lvi);
            }
        }

        private void ShowRekening()
        {
            lbl_mednaam.Text = r.medewerker.voornaam;
            lbl_btwl.Text = "€" + r.btwLaag.ToString("0.00");
            lbl_btwh.Text = "€" + r.btwHoog.ToString("0.00");
            lbl_prijs.Text = "€" + r.Prijs.ToString("0.00");
            txt_tip.Text = r.fooi.ToString("0.00");
            lbl_totaal.Text = "€" + r.totaalprijs.ToString("0.00");
        }

        private void tp_rekening_Click(object sender, EventArgs e)
        {
            RekeningService s = new RekeningService();
            r = s.MakeRekening(tafelId, items);
            ShowRekening();
        }

        private void btn_updatefooi_Click(object sender, EventArgs e)
        {
            double fooi = double.Parse(txt_tip.Text);
            r.UpdateTipAndTotaalprijs(fooi);
            ShowRekening();
        }

        private void btn_terug_Click(object sender, EventArgs e)
        {
            TafelOverzicht tafeloverzicht = new TafelOverzicht();
            this.Close();
        }

        private void btn_AddBestelling_Click(object sender, EventArgs e)
        {
            TafelOverzicht overzicht = new TafelOverzicht("tp_bestelling_maken");
            overzicht.Location = this.Location;
            overzicht.Show();
            this.Close();
        }

        private void btn_afrekenen_Click(object sender, EventArgs e)
        {
            RekeningService s = new RekeningService();
            r = s.MakeRekening(tafelId, items);
            ShowRekening();
            tabControl1.SelectedTab = tp_rekening;
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tp_tafeloverzicht;
        }

        private void btn_contant_Click(object sender, EventArgs e)
        {
            string c = "contant";
            Betaling b = new Betaling(items, c, r);
            b.Location = this.Location;
            b.Show();
            this.Close();
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
            string c = "met pin";
            Betaling b = new Betaling(items, c, r);
            b.Location = this.Location;
            b.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opm = txt_opmerking.Text;
            r.UpdateOpmerking(opm);            
        }

        private void btn_bezet_Click(object sender, EventArgs e)
        {
            // 1. Verbind met logicalaag 
            // 2. Logicalaag verbind met databaselaag 
            // 3. Databaselaag zoekt uit of status bezet/vrij is
            // 4. if status == bezet --> zet status op vrij
            t.UpdateStatus(tafelId, true);
            string tafelStatus = "Tafel " + tafelId + ": Bezet";
            lbl_Tafelstatus.Text = tafelStatus;
            tafeloverzicht.loadTableStatus();            
        }

        public void btn_vrij_Click(object sender, EventArgs e)
        {
            if(lv_bestelitems.Items.Count != 0)
            {
                MessageBox.Show("Kan niet op vrij zetten, want er loopt nog een bestelling");
            }

            else
            {
                t.UpdateStatus(tafelId, false);
                string tafelStatus = "Tafel " + tafelId + ": Vrij";
                lbl_Tafelstatus.Text = tafelStatus;
                tafeloverzicht.loadTableStatus();
            }           
        }
    }
}
