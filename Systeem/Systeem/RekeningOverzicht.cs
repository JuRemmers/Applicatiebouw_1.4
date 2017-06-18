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
        private int tafelId; // wordt meegegeven om de list met bestelitems op te halen
        private List<BestelItem> items;
        private Rekening r;
        private TafelService t = new TafelService();
        private RekeningService s = new RekeningService(); 

        public RekeningOverzicht(int tafelId)
        {
            InitializeComponent();
            this.tafelId = tafelId; // tafelId wordt toegekend
            lbl_tafelnummer.Text = "Tafel " + tafelId; // toont welke tafel dit rekeningoverzicht betreft
            lbl_tafelnummer2.Text = "Tafel " + tafelId; // toont welke tafel dit rekeningoverzicht betreft

            items = s.GetBestellingByTafelId(tafelId); // vult list<bestelItems>
            InitList(items);
            
            // als er geen items in items zitten dan kom je met geen mogelijkheid nog bij rekening aanmaken
            if (!items.Any())
            {
                btn_afrekenen.Enabled = false;
                tabControl1.TabPages.Remove(tp_rekening);
            }

            InitRekening(items);

            // checken of tafel vrij/bezet is, wordt daarna getoont in label
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
            // vult de listvieuw met items uit list<bestelitems>
            foreach(BestelItem i in items)
            {
                string sa = i.aantal.ToString();
                string sa2 = i.item.product;
                string sa3 = "€ " + (i.item.prijs*i.aantal).ToString("0.00");
                ListViewItem lvi = new ListViewItem(sa);
                
                // voeg overige waardes aan kolommen toe
                lvi.SubItems.Add(sa2);
                lvi.SubItems.Add(sa3);

                // voegt het listvieuwitem toe
                lv_bestelitems.Items.Add(lvi);                
            }
        }

        // hetzelfde als InitList voor rekeningtab
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

        // toont de waardes van de rekening
        private void ShowRekening()
        {
            try
            {
                lbl_mednaam.Text = "Medewerker : " + r.medewerker.voornaam;
                lbl_btwl.Text = "€" + r.btwLaag.ToString("0.00");
                lbl_btwh.Text = "€" + r.btwHoog.ToString("0.00");
                lbl_prijs.Text = "€" + r.Prijs.ToString("0.00");
                txt_tip.Text = r.fooi.ToString("0.00");
                lbl_totaal.Text = "€" + r.totaalprijs.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Er is iets misgegaan, probeer opniew");
            }
        }

        // maakt de rekening op en toont deze daarna
        private void tp_rekening_Click(object sender, EventArgs e)
        {
            RekeningService s = new RekeningService();
            r = s.MakeRekening(tafelId, items);
            ShowRekening();
        }

        // update het fooi bedrag en toont daarna de nieuwe rekening
        private void btn_updatefooi_Click(object sender, EventArgs e)
        {
            double fooi = double.Parse(txt_tip.Text);
            r.UpdateTipAndTotaalprijs(fooi);
            ShowRekening();
        }

        // gaat terug naar tafeloverzicht
        private void btn_terug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // gaat naar tafeloverzicht, tab bestelling maken
        private void btn_AddBestelling_Click(object sender, EventArgs e)
        {
            // dialogresult wordt meegegeven om de juiste tab te openen
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // maakt de rekening op en toont deze op de volgende tabpage
        private void btn_afrekenen_Click(object sender, EventArgs e)
        {
            RekeningService s = new RekeningService();
            r = s.MakeRekening(tafelId, items);
            ShowRekening();
            tabControl1.SelectedTab = tp_rekening;
        }

        // gaat terug naar rekeningoverzicht ipv rekening
        private void btn_Terug_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tp_tafeloverzicht;
        }

        // geeft aan dat de gast contact wilt betalen
        private void btn_contant_Click(object sender, EventArgs e)
        {
            string c = "contant";
            Betaling b = new Betaling(items, c, r);
            b.StartPosition = FormStartPosition.Manual;
            b.Location = this.Location;
            b.ShowDialog();
            this.Close();
        }

        // geeft aan dat de klant wil pinnen
        private void btn_pin_Click(object sender, EventArgs e)
        {
            string c = "met pin";
            Betaling b = new Betaling(items, c, r);
            b.StartPosition = FormStartPosition.Manual;
            b.Location = this.Location;
            b.ShowDialog();
            this.Close();
        }

        // toont messagebox met de opmerking die wordt toegevoegd aan de rekening
        private void button1_Click(object sender, EventArgs e)
        {
            string opm = txt_opmerking.Text;
            r.UpdateOpmerking(opm);
            MessageBox.Show("Opmerking is bij rekening gevoegd" + Environment.NewLine + "\"" + opm + "\"");
        }

        // Jesse van Duijne
        private void btn_bezet_Click(object sender, EventArgs e)
        {
            // 1. Verbind met logicalaag 
            // 2. Logicalaag verbind met databaselaag 
            // 3. Databaselaag zoekt uit of status bezet/vrij is
            // 4. if status == bezet --> zet status op vrij
            t.UpdateStatus(tafelId, true);
            string tafelStatus = "Tafel " + tafelId + ": Bezet";
            lbl_Tafelstatus.Text = tafelStatus;           
        }

        // Jesse van Duijne
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
            }           
        }

        // zorgt ervoor dat de instructietekst verdwijnt als medewerker wilt typen
        private void txt_opmerking_Click(object sender, EventArgs e)
        {
            txt_opmerking.Clear();
        }
    }
}
