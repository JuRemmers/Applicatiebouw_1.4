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

        private void button4_Click(object sender, EventArgs e)
        {
            TafelOverzicht overzicht = new TafelOverzicht();
            overzicht.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TafelOverzicht overzicht = new TafelOverzicht("tp_bestelling_maken");
            overzicht.Location = this.Location;
            overzicht.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RekeningService s = new RekeningService();
            r = s.MakeRekening(tafelId, items);
            ShowRekening();
            tabControl1.SelectedTab = tp_rekening;
        }


        private void tp_rekening_Click(object sender, EventArgs e)
        {
            RekeningService s = new RekeningService();
            r = s.MakeRekening(tafelId, items);
            ShowRekening();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
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

        private void btn_updatefooi_Click(object sender, EventArgs e)
        {
            double fooi = double.Parse(txt_tip.Text);
            r.UpdateTipAndTotaalprijs(fooi);
            ShowRekening();
        }
    }
}
