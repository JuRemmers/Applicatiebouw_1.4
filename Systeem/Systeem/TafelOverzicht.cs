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
    public partial class TafelOverzicht : Form
    {
        int bestellingid { get; set; }
        int medewerkerId;

        string sectie;
        BestellingService bestelservice = new BestellingService();
        TafelService tafelservice = new TafelService();
        Kaartservice kaartservice = new Kaartservice();

        public TafelOverzicht(int medewerkerId = 0)
        {
            InitializeComponent();
            loadTableStatus();
            this.medewerkerId = medewerkerId;
        }

        //Donna vd Bent
        private void btn_lunch_Click(object sender, EventArgs e)
        {
            gbox_items.Visible = true;
            clb_menukaart.Items.Clear();

            PrintKaart("Lunch");
        }

        // Donna vd Bent
        private void btn_diner_Click(object sender, EventArgs e)
        {
            gbox_items.Visible = true;
            clb_menukaart.Items.Clear();


            PrintKaart("Diner");
        }

        // Donna vd Bent
        private void btn_dranken_Click(object sender, EventArgs e)
        {
            gbox_items.Visible = true;
            clb_menukaart.Items.Clear();

            PrintKaart("Drank");
        }

        // Donna vd Bent
        private void PrintKaart(string kaart)
        {
            List<Model.MenuItem> allLunch = kaartservice.GetAllkaart(kaart);

            ListViewItem listview;
            string cat = null;
            foreach (Model.MenuItem item in allLunch)
            {
                // als de catergorie veranderd is, print deze
                if (cat != item.Categorie.ToString())
                {
                    listview = new ListViewItem(item.Categorie.ToString());
                    listview.Font = new Font("Serif", 15, FontStyle.Bold);
                    clb_menukaart.Items.Add(listview);
                }

                // print item, als er geen voorraad meer is, maak tekst grijs
                listview = new ListViewItem(item.product);
                listview.SubItems.Add(item.prijs.ToString());
                if (item.voorraad <= 0)
                { listview.ForeColor = Color.Silver; }

                // Update categorie
                cat = item.Categorie.ToString();

                clb_menukaart.Items.Add(listview);
            }
        }

        private void btn_terug_Click(object sender, EventArgs e)
        {
            gbox_items.Visible = false;
        }

        private void btn_terug_Click_1(object sender, EventArgs e)
        {
            gbox_items.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Donna vd Bent
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (clb_menukaart.SelectedIndices.Count == 0)
            { MessageBox.Show("Selecteer een item."); }
            else
            {
                // kan maar 1 selecteren > [0]
                string selected = clb_menukaart.SelectedItems[0].Text;
                int aantal = (int)txt_aantal.Value;

                if (!bestelservice.Add(selected, aantal))
                {
                    // message tekst iets aangepast -- Kayleigh
                    MessageBox.Show("Item niet voldoende op voorraad");
                }

                UpdateAantal();

                txt_aantal.Text = "1";
                this.clb_menukaart.SelectedIndices.Clear();
            }
        }

        // Donna vd Bent
        private void btn_Bekijk_Click(object sender, EventArgs e)
        {
            UpdateBestelling();

            gbox_items.Visible = false;
            gbox_Bestelling.Visible = true;
        }

        //Julian Remmers, Print de lijst met bestellingen voor Bar
        public void btn_bar_Click(object sender, EventArgs e)
        {
            sectie = "Bar";

            gbox_bestellingen.Visible = true;
            clb_bestellingen.Items.Clear();
            BestellingService service = new BestellingService();
            try
            {
                List<Bestelling> bestellingen = service.GetAllForBestelling(sectie);
                foreach (Bestelling item in bestellingen)
                {
                        ListViewItem listview = new ListViewItem(item.ID.ToString());
                        listview.SubItems.Add(item.tafel.ToString());
                        clb_bestellingen.Items.Add(listview);
                }
            }
            catch
            {
            }    
                   
            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //Julian Remmers, Print de lijst met bestellingen voor Keuken
        public void btn_keuken_Click(object sender, EventArgs e)
        {
            sectie = "Keuken";

            gbox_bestellingen.Visible = true;
            clb_bestellingen.Items.Clear();
            BestellingService service = new BestellingService();
            try
            {
                List<Bestelling> bestellingen = service.GetAllForBestelling(sectie);

                foreach (Bestelling item in bestellingen)
                {
                        ListViewItem listview = new ListViewItem(item.ID.ToString());
                        listview.SubItems.Add(item.tafel.ToString());
                        clb_bestellingen.Items.Add(listview);
                }
            }
            catch
            {
            }

            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //Julian Remmers, Print de lijst met bestellingen voor Alles
        private void btn_all_Click(object sender, EventArgs e)
        {
            gbox_bestellingen.Visible = true;
            clb_bestellingen.Items.Clear();
            BestellingService service = new BestellingService();

            try
            {
                List<Bestelling> bestellingen = service.GetAllForBestellingAlles();

                foreach (Model.Bestelling item in bestellingen)
                {
                    ListViewItem listview = new ListViewItem(item.ID.ToString());
                    listview.SubItems.Add(item.tafel.ToString());
                    clb_bestellingen.Items.Add(listview);
                }
            }
            catch
            {
            }

            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //Julian Remmers, Terug knop, heeft niet echt uitleg nodig
        private void btn_back_Click(object sender, EventArgs e)
        {
            gbox_bestellingen.Visible = false;
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void btn_bekijkbestel_Click(object sender, EventArgs e)
        {
            BestellingService items = new BestellingService();
            //List<Bestelling> bestelitems = items.GetAllForItems();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbox_Bestelling.Visible = false;
        }

        private void btn_bekijk_bestelling_Click(object sender, EventArgs e)
        {
            UpdateBestelling();
            gbox_Bestelling.Visible = true;
        }

        public void clb_bestellingen_ColumnClick(object sender, EventArgs e)
        {
            bestellingid = int.Parse(clb_bestellingen.SelectedItems[0].Text);
            BestellingOverzicht overzicht = new BestellingOverzicht(bestellingid);
            overzicht.lb_bestelling.Text = bestellingid.ToString();
            overzicht.Show();
            overzicht.Location = new Point(this.Left, this.Top);
        }

        //Donna vd Bent
        private void UpdateAantal()
        {
            //Telt aantal bestelitems in bestellingservice en zet deze in label
            int aantal = bestelservice.GetCount();
            lbl_aantal.Text = aantal.ToString();
        }

        // Donna vd Bent
        private void btn_wijzigAantal_Click(object sender, EventArgs e)
        {
            if (lv_bestelling.SelectedIndices.Count == 0)
            { MessageBox.Show("Selecteer een item."); }
            else
            {
                string selected = lv_bestelling.SelectedItems[0].Text;
                int aantal = (int)nod_aantal.Value;

                if (!bestelservice.WijzigAantal(selected, aantal))
                { MessageBox.Show("Input ongeldig."); }

                this.lv_bestelling.SelectedIndices.Clear();

                UpdateAantal();
                UpdateBestelling();
            }
        }

        // Donna vd Bent
        private void UpdateBestelling()
        {
            // refresht bestellingoverzicht (lokaal)
            lv_bestelling.Items.Clear();

            foreach (BestelItem item in bestelservice.GetBestelling())
            {
                ListViewItem listview = new ListViewItem(item.item.ToString());
                listview.SubItems.Add(item.aantal.ToString());
                lv_bestelling.Items.Add(listview);
            }
        }

        // Donna vd Bent
        private void btn_verwijderitem_Click(object sender, EventArgs e)
        {
            if (lv_bestelling.SelectedIndices.Count == 0)
            { MessageBox.Show("Selecteer een item."); }
            else
            {
                string selected = lv_bestelling.SelectedItems[0].Text;

                bestelservice.Verwijder(selected);

                this.lv_bestelling.SelectedIndices.Clear();
                UpdateAantal();

                UpdateBestelling();
            }
        }

        // Kayleigh Vossen
        public void btn_table1_Click(object sender, EventArgs e)
        {
            // new form initialseren & tafelnummer meegeven          
            RekeningOverzicht overzicht = new RekeningOverzicht(1);

            // locatie overzichtform op dezelfde locatie zetten
            overzicht.StartPosition = FormStartPosition.Manual;
            overzicht.Location = new Point(this.Left, this.Top);

            // als button "Nieuwe bestelling" geklikt wordt, dialogresult = ok, dan opent hij tabpage bestelling maken
            if (overzicht.ShowDialog() == DialogResult.OK)
            {
                tab_tafeloverzicht.SelectedTab = tp_bestelling_maken;
            }
            // tafelstatus wordt geladen
            loadTableStatus();
        }

        // Kayleigh Vossen
        public void btn_table2_Click(object sender, EventArgs e)
        {
            // new form initialseren & tafelnummer meegeven          
            RekeningOverzicht overzicht = new RekeningOverzicht(2);

            // locatie overzichtform op dezelfde locatie zetten
            overzicht.StartPosition = FormStartPosition.Manual;
            overzicht.Location = new Point(this.Left, this.Top);

            // als button "Nieuwe bestelling" geklikt wordt, dialogresult = ok, dan opent hij tabpage bestelling maken
            if (overzicht.ShowDialog() == DialogResult.OK)
            {
                tab_tafeloverzicht.SelectedTab = tp_bestelling_maken;
            }
            // tafelstatus wordt geladen
            loadTableStatus();
        }

        // Kayleigh Vossen
        public void btn_table3_Click(object sender, EventArgs e)
        {
            // new form initialseren & tafelnummer meegeven          
            RekeningOverzicht overzicht = new RekeningOverzicht(3);

            // locatie overzichtform op dezelfde locatie zetten
            overzicht.StartPosition = FormStartPosition.Manual;
            overzicht.Location = new Point(this.Left, this.Top);

            // als button "Nieuwe bestelling" geklikt wordt, dialogresult = ok, dan opent hij tabpage bestelling maken
            if (overzicht.ShowDialog() == DialogResult.OK)
            {
                tab_tafeloverzicht.SelectedTab = tp_bestelling_maken;
            }
            // tafelstatus wordt geladen
            loadTableStatus();
        }

        // Kayleigh Vossen
        public void btn_table4_Click(object sender, EventArgs e)
        {
            // new form initialseren & tafelnummer meegeven          
            RekeningOverzicht overzicht = new RekeningOverzicht(4);

            // locatie overzichtform op dezelfde locatie zetten
            overzicht.StartPosition = FormStartPosition.Manual;
            overzicht.Location = new Point(this.Left, this.Top);

            // als button "Nieuwe bestelling" geklikt wordt, dialogresult = ok, dan opent hij tabpage bestelling maken
            if (overzicht.ShowDialog() == DialogResult.OK)
            {
                tab_tafeloverzicht.SelectedTab = tp_bestelling_maken;
            }
            // tafelstatus wordt geladen
            loadTableStatus();
        }

        // Kayleigh Vossen
        public void btn_table5_Click(object sender, EventArgs e)
        {
            // new form initialseren & tafelnummer meegeven          
            RekeningOverzicht overzicht = new RekeningOverzicht(5);

            // locatie overzichtform op dezelfde locatie zetten
            overzicht.StartPosition = FormStartPosition.Manual;
            overzicht.Location = new Point(this.Left, this.Top);

            // als button "Nieuwe bestelling" geklikt wordt, dialogresult = ok, dan opent hij tabpage bestelling maken
            if (overzicht.ShowDialog() == DialogResult.OK)
            {
                tab_tafeloverzicht.SelectedTab = tp_bestelling_maken;
            }
            // tafelstatus wordt geladen
            loadTableStatus();
        }

        // Kayleigh Vossen
        public void btn_table6_Click(object sender, EventArgs e)
        {
            // new form initialseren & tafelnummer meegeven          
            RekeningOverzicht overzicht = new RekeningOverzicht(6);

            // locatie overzichtform op dezelfde locatie zetten
            overzicht.StartPosition = FormStartPosition.Manual;
            overzicht.Location = new Point(this.Left, this.Top);

            // als button "Nieuwe bestelling" geklikt wordt, dialogresult = ok, dan opent hij tabpage bestelling maken
            if (overzicht.ShowDialog() == DialogResult.OK)
            {
                tab_tafeloverzicht.SelectedTab = tp_bestelling_maken;
            }
            // tafelstatus wordt geladen
            loadTableStatus();
        }

        // Kayleigh Vossen
        public void btn_table7_Click(object sender, EventArgs e)
        {
            // new form initialseren & tafelnummer meegeven          
            RekeningOverzicht overzicht = new RekeningOverzicht(7);

            // locatie overzichtform op dezelfde locatie zetten
            overzicht.StartPosition = FormStartPosition.Manual;
            overzicht.Location = new Point(this.Left, this.Top);

            // als button "Nieuwe bestelling" geklikt wordt, dialogresult = ok, dan opent hij tabpage bestelling maken
            if (overzicht.ShowDialog() == DialogResult.OK)
            {
                tab_tafeloverzicht.SelectedTab = tp_bestelling_maken;
            }
            // tafelstatus wordt geladen
            loadTableStatus();
        }

        // Kayleigh Vossen
        public void btn_table8_Click(object sender, EventArgs e)
        {
            // new form initialseren & tafelnummer meegeven          
            RekeningOverzicht overzicht = new RekeningOverzicht(8);

            // locatie overzichtform op dezelfde locatie zetten
            overzicht.StartPosition = FormStartPosition.Manual;
            overzicht.Location = new Point(this.Left, this.Top);

            // als button "Nieuwe bestelling" geklikt wordt, dialogresult = ok, dan opent hij tabpage bestelling maken
            if (overzicht.ShowDialog() == DialogResult.OK)
            {
                tab_tafeloverzicht.SelectedTab = tp_bestelling_maken;
            }
            // tafelstatus wordt geladen
            loadTableStatus();
        }

        // Kayleigh Vossen
        public void btn_table9_Click(object sender, EventArgs e)
        {
            // new form initialseren & tafelnummer meegeven          
            RekeningOverzicht overzicht = new RekeningOverzicht(9);

            // locatie overzichtform op dezelfde locatie zetten
            overzicht.StartPosition = FormStartPosition.Manual;
            overzicht.Location = new Point(this.Left, this.Top);

            // als button "Nieuwe bestelling" geklikt wordt, dialogresult = ok, dan opent hij tabpage bestelling maken
            if (overzicht.ShowDialog() == DialogResult.OK)
            {
                tab_tafeloverzicht.SelectedTab = tp_bestelling_maken;
            }
            // tafelstatus wordt geladen
            loadTableStatus();
        }

        // Kayleigh Vossen
        public void btn_table10_Click(object sender, EventArgs e)
        {
            // new form initialseren & tafelnummer meegeven          
            RekeningOverzicht overzicht = new RekeningOverzicht(10);

            // locatie overzichtform op dezelfde locatie zetten
            overzicht.StartPosition = FormStartPosition.Manual;
            overzicht.Location = new Point(this.Left, this.Top);

            // als button "Nieuwe bestelling" geklikt wordt, dialogresult = ok, dan opent hij tabpage bestelling maken
            if (overzicht.ShowDialog() == DialogResult.OK)
            {
                tab_tafeloverzicht.SelectedTab = tp_bestelling_maken;
            }
            // tafelstatus wordt geladen
            loadTableStatus();
        }

        public void loadTableStatus()
        {
            for (int i = 1; i <= 10; i++)
            {
                string gerechtstatus = tafelservice.GetGerechtStatus(i);

                bool tafelstatus = tafelservice.TafelStatus(i);
                switch (i)
                {
                    case 1:
                        if (tafelstatus == true)
                            btn_table1.BackColor = Color.Salmon;
                        else btn_table1.BackColor = Color.PaleGreen;
                        btn_table1.Text = "Tafel 1 "; // dit is een reset omdat je hem leegmaakt                        
                        btn_table1.Text += gerechtstatus;
                        break;
                    case 2:
                        if (tafelstatus == true)
                            btn_table2.BackColor = Color.Salmon;
                        else btn_table2.BackColor = Color.PaleGreen;
                        btn_table2.Text = "Tafel 2 ";
                        btn_table2.Text += gerechtstatus;
                        break;
                    case 3:
                        if (tafelstatus == true)
                            btn_table3.BackColor = Color.Salmon;
                        else btn_table3.BackColor = Color.PaleGreen;
                        btn_table3.Text = "Tafel 3 ";
                        btn_table3.Text += gerechtstatus;
                        break;
                    case 4:
                        if (tafelstatus == true)
                            btn_table4.BackColor = Color.Salmon;
                        else btn_table4.BackColor = Color.PaleGreen;
                        btn_table4.Text = "Tafel 4 ";
                        btn_table4.Text += gerechtstatus;
                        break;
                    case 5:
                        if (tafelstatus == true)
                            btn_table5.BackColor = Color.Salmon;
                        else btn_table5.BackColor = Color.PaleGreen;
                        btn_table5.Text = "Tafel 5 ";
                        btn_table5.Text += gerechtstatus;
                        break;
                    case 6:
                        if (tafelstatus == true)
                            btn_table6.BackColor = Color.Salmon;
                        else btn_table6.BackColor = Color.PaleGreen;
                        btn_table6.Text = "Tafel 6 ";
                        btn_table6.Text += gerechtstatus;
                        break;
                    case 7:
                        if (tafelstatus == true)
                            btn_table7.BackColor = Color.Salmon;
                        else btn_table7.BackColor = Color.PaleGreen;
                        btn_table7.Text = "Tafel 7 ";
                        btn_table7.Text += gerechtstatus;
                        break;
                    case 8:
                        if (tafelstatus == true)
                            btn_table8.BackColor = Color.Salmon;
                        else btn_table8.BackColor = Color.PaleGreen;
                        btn_table8.Text = "Tafel 8 ";
                        btn_table8.Text += gerechtstatus;
                        break;
                    case 9:
                        if (tafelstatus == true)
                            btn_table9.BackColor = Color.Salmon;
                        else btn_table9.BackColor = Color.PaleGreen;
                        btn_table9.Text = "Tafel 9 ";
                        btn_table9.Text += gerechtstatus;
                        break;
                    case 10:
                        if (tafelstatus == true)
                            btn_table10.BackColor = Color.Salmon;
                        else btn_table10.BackColor = Color.PaleGreen;
                        btn_table10.Text = "Tafel 10 ";
                        btn_table10.Text += gerechtstatus;
                        break;
                }
            }
        }

        // Donna vd Bent
        private void btn_plaats_Click(object sender, EventArgs e)
        {
            int tafel = (int)nod_tafel.Value;

            if (!bestelservice.PlaatsBestelling(medewerkerId, tafel))
            {
                MessageBox.Show("Er ging iets fout.");
            }
            else { MessageBox.Show("Bestelling geplaatst"); }

            loadTableStatus();
            UpdateBestelling();
        }

        private void btn_loguit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_bar_meldingen_Click(object sender, EventArgs e)
        {
            tab_tafeloverzicht.SelectedTab = tp_huidige_bestellingen;
            btn_bar.PerformClick();
        }

        private void btn_keuken_meldingen_Click(object sender, EventArgs e)
        {
            tab_tafeloverzicht.SelectedTab = tp_huidige_bestellingen;
            btn_keuken.PerformClick();
        }

        private void btn_opmerking_Click(object sender, EventArgs e)
        {
            string opm = tb_opmerking.Text;
            string selected = lv_bestelling.SelectedItems[0].Text;

            if (!bestelservice.WijzigOpmerking(selected, opm))
            {
                MessageBox.Show("Kon opmerking niet toevoegen");
            }
            else
            {
                MessageBox.Show("Opmerking toegevoegd");
            }

            tb_opmerking.Text = "Schrijf hier een opmerking voor een item";
        }

        private void tb_opmerking_Click(object sender, EventArgs e)
        {
            tb_opmerking.Clear();
        }
    }
}
