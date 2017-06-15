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
    public partial class BestellingOverzicht : Form
    {
        int bestellingid;
        public BestellingOverzicht(int bestellingid)
        {
            this.bestellingid = bestellingid;
            InitializeComponent();
            Bestellinglist(bestellingid);
            cb_status.Items.Add("Opgenomen");
            cb_status.Items.Add("Onderhande");
            cb_status.Items.Add("Gereed");
            cb_status.Items.Add("Uitgeserveerd");
        }

        public void Bestellinglist(int bestellingid)
        {
            
            BestellingService service = new BestellingService();
            TafelOverzicht tafel = new TafelOverzicht();
            int bestelId = bestellingid;
            List<BestelItem> bestellingen = service.GetAllForItems(bestelId);

            foreach (BestelItem i in bestellingen)
            {
                string sa = i.item.product;
                string sa2 = i.aantal.ToString();
                ListViewItem listview = new ListViewItem(sa);
                listview.SubItems.Add(sa2);
                clb_besteIitems.Items.Add(listview);
            }
        }

    private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btn_aanpassen_Click(object sender, EventArgs e)
        {
            Status updatestatus = Model.Status.Gereed;
            updatestatus = (Status)Enum.Parse(typeof(Status), cb_status.SelectedItem.ToString());
            BestellingService service = new BestellingService();
            service.UpdateStatus(bestellingid, updatestatus);

        }
    }
}
