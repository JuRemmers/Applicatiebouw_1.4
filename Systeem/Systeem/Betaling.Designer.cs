namespace Systeem
{
    partial class Betaling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Betaling));
            this.lbl_UheeftBetaald = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Medewerker = new System.Windows.Forms.Label();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.lbl_btwL = new System.Windows.Forms.Label();
            this.lbl_btwH = new System.Windows.Forms.Label();
            this.lbl_prijs = new System.Windows.Forms.Label();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.lbl_totaalprijs = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_plattegrond = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_opmerking = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_UheeftBetaald
            // 
            this.lbl_UheeftBetaald.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UheeftBetaald.Location = new System.Drawing.Point(112, 113);
            this.lbl_UheeftBetaald.Name = "lbl_UheeftBetaald";
            this.lbl_UheeftBetaald.Size = new System.Drawing.Size(197, 26);
            this.lbl_UheeftBetaald.TabIndex = 15;
            this.lbl_UheeftBetaald.Text = "u heeft pin betaald";
            this.lbl_UheeftBetaald.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Aantal,
            this.Naam,
            this.Prijs});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(12, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 183);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 50;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 250;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            this.Prijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Prijs.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "BTW 6%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "BTW 21%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Prijs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "TotaalPrijs";
            // 
            // lbl_Medewerker
            // 
            this.lbl_Medewerker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Medewerker.Location = new System.Drawing.Point(119, 493);
            this.lbl_Medewerker.Name = "lbl_Medewerker";
            this.lbl_Medewerker.Size = new System.Drawing.Size(194, 16);
            this.lbl_Medewerker.TabIndex = 22;
            this.lbl_Medewerker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datetime.Location = new System.Drawing.Point(138, 509);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(144, 16);
            this.lbl_datetime.TabIndex = 23;
            this.lbl_datetime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_datetime.UseWaitCursor = true;
            // 
            // lbl_btwL
            // 
            this.lbl_btwL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btwL.Location = new System.Drawing.Point(276, 331);
            this.lbl_btwL.Name = "lbl_btwL";
            this.lbl_btwL.Size = new System.Drawing.Size(136, 16);
            this.lbl_btwL.TabIndex = 24;
            this.lbl_btwL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_btwH
            // 
            this.lbl_btwH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btwH.Location = new System.Drawing.Point(276, 347);
            this.lbl_btwH.Name = "lbl_btwH";
            this.lbl_btwH.Size = new System.Drawing.Size(136, 16);
            this.lbl_btwH.TabIndex = 25;
            this.lbl_btwH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_prijs
            // 
            this.lbl_prijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prijs.Location = new System.Drawing.Point(276, 372);
            this.lbl_prijs.Name = "lbl_prijs";
            this.lbl_prijs.Size = new System.Drawing.Size(136, 16);
            this.lbl_prijs.TabIndex = 26;
            this.lbl_prijs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_tip
            // 
            this.lbl_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tip.Location = new System.Drawing.Point(276, 388);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(136, 16);
            this.lbl_tip.TabIndex = 27;
            this.lbl_tip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_totaalprijs
            // 
            this.lbl_totaalprijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totaalprijs.Location = new System.Drawing.Point(276, 424);
            this.lbl_totaalprijs.Name = "lbl_totaalprijs";
            this.lbl_totaalprijs.Size = new System.Drawing.Size(136, 16);
            this.lbl_totaalprijs.TabIndex = 28;
            this.lbl_totaalprijs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(118, 525);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Bedankt, en tot ziens!";
            // 
            // btn_plattegrond
            // 
            this.btn_plattegrond.Location = new System.Drawing.Point(138, 556);
            this.btn_plattegrond.Name = "btn_plattegrond";
            this.btn_plattegrond.Size = new System.Drawing.Size(144, 23);
            this.btn_plattegrond.TabIndex = 30;
            this.btn_plattegrond.Text = "Terug naar Plattegrond";
            this.btn_plattegrond.UseVisualStyleBackColor = true;
            this.btn_plattegrond.Click += new System.EventHandler(this.btn_plattegrond_Click);
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(112, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 104);
            this.label6.TabIndex = 31;
            // 
            // lbl_opmerking
            // 
            this.lbl_opmerking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_opmerking.Location = new System.Drawing.Point(12, 453);
            this.lbl_opmerking.Name = "lbl_opmerking";
            this.lbl_opmerking.Size = new System.Drawing.Size(400, 40);
            this.lbl_opmerking.TabIndex = 32;
            // 
            // Betaling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 591);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_opmerking);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_plattegrond);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_totaalprijs);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.lbl_prijs);
            this.Controls.Add(this.lbl_btwH);
            this.Controls.Add(this.lbl_btwL);
            this.Controls.Add(this.lbl_datetime);
            this.Controls.Add(this.lbl_Medewerker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_UheeftBetaald);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Betaling";
            this.Text = "Betaling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_UheeftBetaald;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Medewerker;
        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.Label lbl_btwL;
        private System.Windows.Forms.Label lbl_btwH;
        private System.Windows.Forms.Label lbl_prijs;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Label lbl_totaalprijs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_plattegrond;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_opmerking;
    }
}