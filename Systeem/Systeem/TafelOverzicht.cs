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
            List<MenuItem> lunchmenu = lijst.GetAllkaart(kaartid);

            foreach (MenuItem MenuItem in lunchmenu)
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
