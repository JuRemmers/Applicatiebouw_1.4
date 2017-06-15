﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DAO;


namespace Systeem
{
    public partial class Betaling : Form
    {
        
        public Betaling(List<BestelItem> items, string betaalmethode, Rekening r)
        {
            InitializeComponent();
            lbl_UheeftBetaald.Text = "U heeft " + betaalmethode + " betaald";
            lbl_btwL.Text = "€ " + r.btwLaag.ToString("0.00");
            lbl_btwH.Text = "€ " + r.btwHoog.ToString("0.00");
            lbl_prijs.Text = "€ " + r.Prijs.ToString("0.00");
            lbl_tip.Text = "€ " + r.fooi.ToString("0.00");
            lbl_totaalprijs.Text = "€ " + r.totaalprijs.ToString("0.00");
            lbl_Medewerker.Text = "U werd geholpen door: " + r.medewerker.voornaam;
            lbl_datetime.Text = r.datumtijd.ToString("dd - MM - yyyy  hh:mm");
            RekeningDAO d = new RekeningDAO();
            d.InsertRekening(r);
            BestellingDAO b = new BestellingDAO();
            b.UpdateBetaald(r.bestelId);
            InitList(items);
        }

        private void InitList(List<BestelItem> items)
        {
            foreach (BestelItem i in items)
            {
                string sa = i.aantal.ToString();
                string sa2 = i.item.product;
                string sa3 = "€ " + (i.item.prijs * i.aantal).ToString("0.00");
                ListViewItem lvi = new ListViewItem(sa);

                lvi.SubItems.Add(sa2);
                lvi.SubItems.Add(sa3);
                listView1.Items.Add(lvi);
            }
        }

        private void btn_plattegrond_Click(object sender, EventArgs e)
        {
            TafelOverzicht overzicht = new TafelOverzicht();
            overzicht.Location = this.Location;
            overzicht.Show();
            this.Close();
        }
    }
}