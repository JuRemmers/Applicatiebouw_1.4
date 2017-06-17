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

namespace Systeem
{
    public partial class LoginScherm : Form
    {
        public LoginScherm()
        {
            InitializeComponent();
        }

        private void b_login_enter_Click(object sender, EventArgs e)
        {
            int werknemer_id = 0; // Initialiseert waarden voor id en wachtwoord
            string wachtwoord = " ";

            // Inlezen ID en wachtwoord
            if (tb_werknemer_id.Text.All(char.IsDigit) && tb_werknemer_id.Text != "")
            {
                // Proceed
                werknemer_id = Int32.Parse(tb_werknemer_id.Text);
                wachtwoord = tb_wachtwoord.Text.ToString();

                // Onderstaande controleerd of de login valide is
                Loginservice login = new Loginservice();  // Maakt instantie van class Loginservice
                bool check = login.logincheck(werknemer_id, wachtwoord); // ..en stopt hem in bool
                if (check)
                {
                    this.Hide(); // Verbergt loginscherm wanneer ingelogd
                    var TafelOverzicht = new TafelOverzicht(werknemer_id); // 'var' = compiler bepaalt datatype
                    TafelOverzicht.ShowDialog();
                    tb_werknemer_id.Clear(); // Leegt de textboxen als je opnieuw inlogt
                    tb_wachtwoord.Clear();
                    this.Show(); // Showt tafeloverzichtscherm
                }
                else MessageBox.Show("Incorect wachtwoord");
            }
            else MessageBox.Show("Geen geldig ID ingevoerd: voer cijfers in");                     
        }

        private void tb_wachtwoord_TextChanged(object sender, EventArgs e)
        {
            tb_wachtwoord.PasswordChar = '*'; // Toont een * op de plek van het wachtwoord
        }
    }
}
