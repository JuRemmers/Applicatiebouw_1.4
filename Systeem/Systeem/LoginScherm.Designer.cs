namespace Systeem
{
    partial class LoginScherm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScherm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_werknemer_id = new System.Windows.Forms.Label();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.tb_wacthwoord = new System.Windows.Forms.TextBox();
            this.b_login_enter = new System.Windows.Forms.Button();
            this.tb_werknemer_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 168);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(69, 9);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(283, 108);
            this.lbl_login.TabIndex = 12;
            this.lbl_login.Text = "Login";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // lbl_werknemer_id
            // 
            this.lbl_werknemer_id.AutoSize = true;
            this.lbl_werknemer_id.Location = new System.Drawing.Point(84, 398);
            this.lbl_werknemer_id.Name = "lbl_werknemer_id";
            this.lbl_werknemer_id.Size = new System.Drawing.Size(76, 13);
            this.lbl_werknemer_id.TabIndex = 7;
            this.lbl_werknemer_id.Text = "Werknemer ID";
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Location = new System.Drawing.Point(92, 445);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lbl_wachtwoord.TabIndex = 8;
            this.lbl_wachtwoord.Text = "Wachtwoord";
            // 
            // tb_wacthwoord
            // 
            this.tb_wacthwoord.Location = new System.Drawing.Point(205, 442);
            this.tb_wacthwoord.Name = "tb_wacthwoord";
            this.tb_wacthwoord.Size = new System.Drawing.Size(139, 20);
            this.tb_wacthwoord.TabIndex = 10;
            this.tb_wacthwoord.TextChanged += new System.EventHandler(this.tb_wacthwoord_TextChanged);
            // 
            // b_login_enter
            // 
            this.b_login_enter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_login_enter.Location = new System.Drawing.Point(205, 487);
            this.b_login_enter.Name = "b_login_enter";
            this.b_login_enter.Size = new System.Drawing.Size(139, 23);
            this.b_login_enter.TabIndex = 11;
            this.b_login_enter.Text = "Enter";
            this.b_login_enter.UseVisualStyleBackColor = true;
            this.b_login_enter.Click += new System.EventHandler(this.b_login_enter_Click);
            // 
            // tb_werknemer_id
            // 
            this.tb_werknemer_id.Location = new System.Drawing.Point(205, 398);
            this.tb_werknemer_id.Name = "tb_werknemer_id";
            this.tb_werknemer_id.Size = new System.Drawing.Size(139, 20);
            this.tb_werknemer_id.TabIndex = 9;
            // 
            // LoginScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_werknemer_id);
            this.Controls.Add(this.lbl_wachtwoord);
            this.Controls.Add(this.tb_wacthwoord);
            this.Controls.Add(this.b_login_enter);
            this.Controls.Add(this.tb_werknemer_id);
            this.Name = "LoginScherm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_werknemer_id;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.TextBox tb_wacthwoord;
        private System.Windows.Forms.Button b_login_enter;
        private System.Windows.Forms.TextBox tb_werknemer_id;
    }
}

