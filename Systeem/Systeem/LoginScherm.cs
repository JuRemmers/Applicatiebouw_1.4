﻿using System;
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
            int werknemer_id=0;
            string wachtwoord=" ";

            try
            {
                werknemer_id = Int32.Parse(tb_werknemer_id.Text);
                wachtwoord = tb_wacthwoord.Text.ToString();
            }
            catch
            {
                MessageBox.Show("Verkeerde invoer, onthoud dat Werknemer ID een getal moet zijn");
            }

            Loginservice login = new Loginservice();
            bool check = login.logincheck(werknemer_id, wachtwoord);
            if (check)
            {
                this.Hide();
                var TafelOverzicht = new TafelOverzicht();
                TafelOverzicht.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Incorect wachtwoord");
            }


            


        }

        private void tb_wacthwoord_TextChanged(object sender, EventArgs e)
        {
            tb_wacthwoord.PasswordChar = '*';
        }
    }
}
