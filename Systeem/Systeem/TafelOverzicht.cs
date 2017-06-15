﻿using System;
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

        string sectie;
        BestellingService bestelservice = new BestellingService();

        public TafelOverzicht()
        {
            InitializeComponent();
            //cb_status.Items.Add("Opgenomen");
            //cb_status.Items.Add("Onderhande");
            //cb_status.Items.Add("Gereed");
            //cb_status.Items.Add("Uitgeserveerd");
        }

        public TafelOverzicht(string tabopen)
        {
            InitializeComponent();
            //cb_status.Items.Add("Opgenomen");
            //cb_status.Items.Add("Onderhande");
            //cb_status.Items.Add("Gereed");
            //cb_status.Items.Add("Uitgeserveerd");

            // Kayleigh Vossen
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
                    clb_menukaart.Items.Add(listview);
                }

                listview = new ListViewItem(item.product);
                if (item.voorraad <= 0)
                { listview.ForeColor = Color.Silver; }

                listview.SubItems.Add(item.prijs.ToString());


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
                    clb_menukaart.Items.Add(listview);
                }

                listview = new ListViewItem(item.product);
                if (item.voorraad <= 0)
                { listview.ForeColor = Color.Silver; }

                listview.SubItems.Add(item.prijs.ToString());


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
                    clb_menukaart.Items.Add(listview);
                }

                listview = new ListViewItem(item.product);
                if (item.voorraad <= 0)
                { listview.ForeColor = Color.Silver; }

                listview.SubItems.Add(item.prijs.ToString());


                cat = item.Categorie.ToString();

                clb_menukaart.Items.Add(listview);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (clb_menukaart.SelectedIndices.Count == 0)
            { MessageBox.Show("Selecteer een item."); }
            else
            {
                string selected = clb_menukaart.SelectedItems[0].Text;

                int aantal = (int)txt_aantal.Value;

                if (!bestelservice.Add(selected, aantal))
                {
                    MessageBox.Show("Input ongeldig.");
                }

                UpdateAantal();

                this.clb_menukaart.SelectedIndices.Clear();
            }
        }

        private void btn_Bekijk_Click(object sender, EventArgs e)
        {
            UpdateBestelling();

            gbox_items.Visible = false;
            gbox_Bestelling.Visible = true;
        }

        public void btn_bar_Click(object sender, EventArgs e)
        {
            sectie = "Bar";

            gbox_bestellingen.Visible = true;

            clb_bestellingen.Items.Clear();
            BestellingService service = new BestellingService();
            List<Bestelling> bestellingen = service.GetAllForBestelling(sectie);

            foreach (Bestelling item in bestellingen)
            {
                ListViewItem listview = new ListViewItem(item.ID.ToString());
                listview.SubItems.Add(item.tafel.ToString());
                clb_bestellingen.Items.Add(listview);
            }
            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void btn_keuken_Click(object sender, EventArgs e)
        {
            sectie = "Keuken";

            gbox_bestellingen.Visible = true;
            clb_bestellingen.Items.Clear();
            BestellingService service = new BestellingService();
            List<Bestelling> bestellingen = service.GetAllForBestelling(sectie);

            foreach (Bestelling item in bestellingen)
            {
                ListViewItem listview = new ListViewItem(item.ID.ToString());
                listview.SubItems.Add(item.tafel.ToString());
                clb_bestellingen.Items.Add(listview);
            }
            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_all_Click(object sender, EventArgs e)
        {

            sectie = "Alles";

            gbox_bestellingen.Visible = true;
            clb_bestellingen.Items.Clear();
            BestellingService service = new BestellingService();
            List<Bestelling> bestellingen = service.GetAllForBestellingAlles();

            foreach (Model.Bestelling item in bestellingen)
            {
                ListViewItem listview = new ListViewItem(item.ID.ToString());
                listview.SubItems.Add(item.tafel.ToString());
                clb_bestellingen.Items.Add(listview);
            }
            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            clb_bestellingen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            gbox_bestellingen.Visible = false;
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int bestellingid;
        //    Status updatestatus = Model.Status.Gereed;

        //    ListViewItem list2 = clb_bestellingen.SelectedItems[0];
        //    bestellingid = int.Parse(list2.SubItems[0].Text);
        //    updatestatus = (Status)Enum.Parse(typeof(Status), cb_status.SelectedItem.ToString());

        //    BestellingService service = new BestellingService();
        //    service.UpdateStatus(bestellingid, updatestatus);


        //    switch (sectie)
        //    {
        //        case "Keuken":
        //            btn_keuken.PerformClick();
        //            break;

        //        case "Bar":
        //            btn_bar.PerformClick();
        //            break;

        //        case "Alles":
        //            btn_all.PerformClick();
        //            break;

        //    }


        //}

        // Kayleigh Vossen
        private void pb_table1_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(1);

            overzicht.Show();
            overzicht.Location = new Point(this.Left, this.Top);
            // pb_table1.Image = Image.FromFile("C:/Users/jesse/OneDrive/Afbeeldingen/111.png");        
        }

        // Kayleigh Vossen
        private void pb_table3_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(3);

            overzicht.Show();
            overzicht.Location = new Point(this.Left, this.Top);
        }

        // Kayleigh Vossen
        private void pb_table5_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(5);

            overzicht.Show();
            overzicht.Location = new Point(this.Left, this.Top);
        }

        // Kayleigh Vossen
        private void pb_table7_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(7);

            overzicht.Show();
            overzicht.Location = new Point(this.Left, this.Top);
        }

        // Kayleigh Vossen
        private void pb_table9_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(9);

            overzicht.Show();
            overzicht.Location = new Point(this.Left, this.Top);
        }

        // Kayleigh Vossen
        private void pb_table2_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(2);

            overzicht.Show();
            overzicht.Location = new Point(this.Left, this.Top);
        }

        // Kayleigh Vossen
        private void pb_table4_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(4);

            overzicht.Show();
            overzicht.Location = new Point(this.Left, this.Top);
        }

        // Kayleigh Vossen
        private void pb_table6_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(6);
            overzicht.Show();
            overzicht.Location = new Point(this.Left, this.Top);
        }

        // Kayleigh Vossen
        private void pb_table8_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(8);

            overzicht.Show();
            overzicht.Location = new Point(this.Left, this.Top);
        }

        // Kayleigh Vossen
        private void pb_table10_Click(object sender, EventArgs e)
        {
            RekeningOverzicht overzicht = new RekeningOverzicht(10);

            overzicht.Show();
            overzicht.Location = new Point(this.Left, this.Top);
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

        private void UpdateAantal()
        {
            int aantal = bestelservice.GetCount();
            lbl_aantal.Text = aantal.ToString();
        }

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

        private void UpdateBestelling()
        {
            lv_bestelling.Items.Clear();

            foreach (BestelItem item in bestelservice.GetBestelling())
            {
                ListViewItem listview = new ListViewItem(item.item.ToString());
                listview.SubItems.Add(item.aantal.ToString());
                lv_bestelling.Items.Add(listview);
            }
        }
    }
}
