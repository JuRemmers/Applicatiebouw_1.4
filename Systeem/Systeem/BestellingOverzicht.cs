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
            TafelOverzicht tafel = new TafelOverzicht();
            TimeSpan maxtijd = new TimeSpan(30, 0, 0);

            foreach (BestelItem i in bestellingen)
            {
                DateTime tijd1 = DateTime.Now;
                TimeSpan wachttijd = tijd1.Subtract(i.tijd);
                string sa = i.item.product;
                string sa2 = i.aantal.ToString();
                string sa3 = i.status.ToString();
                string sa4 = wachttijd.ToString();
                ListViewItem listview = new ListViewItem(sa);
                listview.SubItems.Add(sa2);
                listview.SubItems.Add(sa4);
                listview.SubItems.Add(sa3);                
                clb_besteIitems.Items.Add(listview);


                if (wachttijd.TotalMinutes > maxtijd.TotalMinutes)
                {
                    listview.ForeColor = Color.Red;
                }
                else
                {
                    listview.ForeColor = Color.White;
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
                Status updatestatus = Model.Status.Gereed;
                string gerecht = clb_besteIitems.SelectedItems[0].Text;
                updatestatus = (Status)Enum.Parse(typeof(Status), cb_status.SelectedItem.ToString());
                BestellingService service = new BestellingService();
                service.UpdateStatus(bestellingid, updatestatus, gerecht);
                Bestellinglist(bestellingid);
            }

            catch
            {
                MessageBox.Show("Maak een selectie");
            }
        }
    }
}
