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
        public int tafelId;

        public RekeningOverzicht(int tafelId)
        {
            InitializeComponent();
            this.tafelId = tafelId;
            lbl_tafelnummer.Text = "Tafel " + tafelId;
            lbl_tafelnummer2.Text = "Tafel " + tafelId;
            RekeningService s = new RekeningService();
            List<BestelItem> items = s.GetBestellingByTafelId(tafelId);
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
                listView1.Items.Add(lvi);
                
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
            overzicht.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tp_rekening;
        }

        private void tp_rekening_Click(object sender, EventArgs e)
        {

        }
    }
}
