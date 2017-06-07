using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systeem
{
    public partial class LoginScherm : Form
    {
        public LoginScherm()
        {
            InitializeComponent();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void b_login_enter_Click(object sender, EventArgs e)
        {
            this.Hide();
            var TafelOverzicht = new TafelOverzicht();
            TafelOverzicht.ShowDialog();

            int werknemer_id;
            string wachtwoord;

            werknemer_id = int.Parse(tb_werknemer_id.Text);
            wachtwoord = tb_wacthwoord.Text.ToString();
        }

        private void tb_wacthwoord_TextChanged(object sender, EventArgs e)
        {
            tb_wacthwoord.PasswordChar = '*';
        }
    }
}
