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
        public BestellingOverzicht(int bestellingid)
        {
            InitializeComponent();
            Bestellinglist(bestellingid);
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
            clb_besteIitems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            clb_besteIitems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

    private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
