using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Systeem.Logica;
using Model;

namespace Systeem
{
    public partial class TafelOverzicht : Form
    {
        public TafelOverzicht()
        {
            InitializeComponent();
            cb_status.Items.Add("Opgenomen");
            cb_status.Items.Add("Onderhande");
            cb_status.Items.Add("Gereed");
            cb_status.Items.Add("Uitgeserveerd");
        }

        public TafelOverzicht(string tabopen)
        {
            InitializeComponent();
            cb_status.Items.Add("Opgenomen");
            cb_status.Items.Add("Onderhande");
            cb_status.Items.Add("Gereed");
            cb_status.Items.Add("Uitgeserveerd");
            if (tabopen == "tp_bestelling_maken")
            {
                tab_tafeloverzicht.SelectedTab = tp_bestelling_maken;
            }
        }

        private void btn_lunch_Click(object sender, EventArgs e)
        {

            gbox_items.Visible = true;

            clb_menukaart.Items.Clear();
            Kaartservice service = new Kaartservice();
            List<Model.MenuItem> allLunch = service.GetAllkaart("Lunch");

            ListViewItem listview;
            string cat = null;
            foreach (Model.MenuItem item in allLunch)
            {
                if (cat != item.Categorie.ToString())
                {
                    listview = new ListViewItem(item.Categorie.ToString());
                    listview.Font = new Font("Serif", 15, FontStyle.Bold);
                }
                else
                {
                    listview = new ListViewItem(item.product);
                    listview.SubItems.Add(item.prijs.ToString());
                }

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

        private void btn_diner_Click(object sender, EventArgs e)
        {
            gbox_items.Visible = true;

            clb_menukaart.Items.Clear();
            Kaartservice service = new Kaartservice();
            List<Model.MenuItem> allDiner = service.GetAllkaart("Diner");

            ListViewItem listview;
            string cat = null;
            foreach (Model.MenuItem item in allDiner)
            {
                if (cat != item.Categorie.ToString())
                {
                    listview = new ListViewItem(item.Categorie.ToString());
                    listview.Font = new Font("Serif", 15, FontStyle.Bold);
                }
                else
                {
                    listview = new ListViewItem(item.product);
                    listview.SubItems.Add(item.prijs.ToString());
                }

                cat = item.Categorie.ToString();

                clb_menukaart.Items.Add(listview);
            }
        }

        private void btn_dranken_Click(object sender, EventArgs e)
        {
            gbox_items.Visible = true;

            clb_menukaart.Items.Clear();
            Kaartservice service = new Kaartservice();
            List<Model.MenuItem> allDranken = service.GetAllkaart("Drank");

            ListViewItem listview;
            string cat = null;
            foreach (Model.MenuItem item in allDranken)
            {
                if (cat != item.Categorie.ToString())
                {
                    listview = new ListViewItem(item.Categorie.ToString());
                    listview.Font = new Font("Serif", 15, FontStyle.Bold);
                }
                else
                {
                    listview = new ListViewItem(item.product);
                    listview.SubItems.Add(item.prijs.ToString());
                }

                cat = item.Categorie.ToString();

                clb_menukaart.Items.Add(listview);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string selected = clb_menukaart.CheckedItems.ToString();


        }

        private void btn_Bekijk_Click(object sender, EventArgs e)
        {
            clb_menukaart.Items.Clear();

            // somehow get list of bestellingen

            // print each
        }

        private void btn_bar_Click(object sender, EventArgs e)
        {
            gbox_bestellingen.Visible = true;

            clb_bestellingen.Items.Clear();
            BestellingService service = new BestellingService();
            List<Bestelling> bestellingen = service.GetAllForBestelling("Bar");

            foreach (Bestelling item in bestellingen)
            {
                clb_bestellingen.Items.Add(item.ToString());
            }
        }

        private void btn_keuken_Click(object sender, EventArgs e)
        {
            gbox_bestellingen.Visible = true;
            clb_bestellingen.Items.Clear();
            BestellingService service = new BestellingService();
            List<Bestelling> bestellingen = service.GetAllForBestelling("Keuken");

            foreach (Bestelling item in bestellingen)
            {
                clb_bestellingen.Items.Add(item.ToString());
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            gbox_bestellingen.Visible = true;
            clb_bestellingen.Items.Clear();
            BestellingService service = new BestellingService();
            List<Bestelling> bestellingen = service.GetAllForBestellingAlles();

            foreach (Bestelling item in bestellingen)
            {
                clb_bestellingen.Items.Add(item.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbox_bestellingen.Visible = false;
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Kayleigh
        private void pb_table1_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(1);
            overzicht.Show();
            this.Close();
        }

        // Kayleigh
        private void pb_table3_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(3);
            overzicht.Show();
            this.Close();
        }

        // Kayleigh
        private void pb_table5_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(5);
            overzicht.Show();
            this.Close();
        }

        // Kayleigh
        private void pb_table7_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(7);
            overzicht.Show();
            this.Close();
        }

        // Kayleigh
        private void pb_table9_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(9);
            overzicht.Show();
            this.Close();
        }

        // Kayleigh
        private void pb_table2_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(2);
            overzicht.Show();
            this.Close();
        }

        // Kayleigh
        private void pb_table4_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(4);
            overzicht.Show();
            this.Close();
        }

        // Kayleigh
        private void pb_table6_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(6);
            overzicht.Show();
            this.Close();
        }

        // Kayleigh
        private void pb_table8_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(8);
            overzicht.Show();
            this.Close();
        }

        // Kayleigh
        private void pb_table10_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(10);
            overzicht.Show();
            this.Close();
        }
    }
}
