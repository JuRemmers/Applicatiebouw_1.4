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

        private void btn_lunch_Click(object sender, EventArgs e)
        {

            gbox_items.Visible = true;

            clb_menukaart.Items.Clear();
            Kaartservice service = new Kaartservice();
            List<Model.MenuItem> allLunch = service.GetAllkaart("Lunch");

            foreach (Model.MenuItem item in allLunch)
            {
                clb_menukaart.Items.Add(item.ToString());
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_diner_Click(object sender, EventArgs e)
        {
            gbox_items.Visible = true;

            clb_menukaart.Items.Clear();
            Kaartservice service = new Kaartservice();
            List<Model.MenuItem> allDiner = service.GetAllkaart("Diner");

            foreach (Model.MenuItem item in allDiner)
            {
                clb_menukaart.Items.Add(item.ToString());
            }
        }

        private void btn_dranken_Click(object sender, EventArgs e)
        {
            gbox_items.Visible = true;

            clb_menukaart.Items.Clear();
            Kaartservice service = new Kaartservice();
            List<Model.MenuItem> allDranken = service.GetAllkaart("Drank");

            Menucategorie cat = null;
            foreach (Model.MenuItem item in allDranken)
            {
                if (item.Categorie != cat)
                {
                    clb_menukaart.Items.Add("-");
                    cat = item.Categorie;
                }
                clb_menukaart.Items.Add(item.ToString());
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

        private void clb_menukaart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
