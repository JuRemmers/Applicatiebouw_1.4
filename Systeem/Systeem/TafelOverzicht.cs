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
using Systeem.Model;

namespace Systeem
{
    public partial class TafelOverzicht : Form
    {
        public TafelOverzicht()
        {
            InitializeComponent();
        }

        private void btn_lunch_Click(object sender, EventArgs e)
        {

            gbox_items.Visible = true;

            clb_menukaart.Items.Clear();
            Lunchservice lijst = new Lunchservice();
            string kaartid = "lunch";
            List<Model.MenuItem> kaart = new List<Model.MenuItem>();

            kaart.Add(new Model.MenuItem(2, 3, 50, new Menucategorie(1, "nagerecht", 2, 3), new MenuKaart(1, 3)));
            kaart.Add(new Model.MenuItem(4, 3, 50, new Menucategorie(1, "nagerecht", 2, 3), new MenuKaart(1, 3)));
            foreach (Model.MenuItem MenuItem in kaart)
            {
                clb_menukaart.Items.Add(MenuItem.ToString());
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
    }
}
