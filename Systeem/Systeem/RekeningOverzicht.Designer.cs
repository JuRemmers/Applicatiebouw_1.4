namespace Systeem
{
    partial class RekeningOverzicht
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_tafeloverzicht = new System.Windows.Forms.TabPage();
            this.btn_vrij = new System.Windows.Forms.Button();
            this.btn_bezet = new System.Windows.Forms.Button();
            this.lbl_tafelnummer = new System.Windows.Forms.Label();
            this.btn_terugPlattegrond = new System.Windows.Forms.Button();
            this.btn_afrekenen = new System.Windows.Forms.Button();
            this.btn_AddBestelling = new System.Windows.Forms.Button();
            this.lv_bestelitems = new System.Windows.Forms.ListView();
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_rekening = new System.Windows.Forms.TabPage();
            this.btn_updatopm = new System.Windows.Forms.Button();
            this.txt_opmerking = new System.Windows.Forms.TextBox();
            this.btn_updatefooi = new System.Windows.Forms.Button();
            this.lbl_tafelnummer2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_totaal = new System.Windows.Forms.Label();
            this.lbl_prijs = new System.Windows.Forms.Label();
            this.lbl_btwh = new System.Windows.Forms.Label();
            this.lbl_btwl = new System.Windows.Forms.Label();
            this.btn_Terug = new System.Windows.Forms.Button();
            this.txt_tip = new System.Windows.Forms.TextBox();
            this.btn_pin = new System.Windows.Forms.Button();
            this.btn_contant = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_mednaam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Tafelstatus = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tp_tafeloverzicht.SuspendLayout();
            this.tp_rekening.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tp_tafeloverzicht);
            this.tabControl1.Controls.Add(this.tp_rekening);
            this.tabControl1.ItemSize = new System.Drawing.Size(66, 30);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(32, 3);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 591);
            this.tabControl1.TabIndex = 1;
            // 
            // tp_tafeloverzicht
            // 
            this.tp_tafeloverzicht.Controls.Add(this.lbl_Tafelstatus);
            this.tp_tafeloverzicht.Controls.Add(this.btn_vrij);
            this.tp_tafeloverzicht.Controls.Add(this.btn_bezet);
            this.tp_tafeloverzicht.Controls.Add(this.lbl_tafelnummer);
            this.tp_tafeloverzicht.Controls.Add(this.btn_terugPlattegrond);
            this.tp_tafeloverzicht.Controls.Add(this.btn_afrekenen);
            this.tp_tafeloverzicht.Controls.Add(this.btn_AddBestelling);
            this.tp_tafeloverzicht.Controls.Add(this.lv_bestelitems);
            this.tp_tafeloverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_tafeloverzicht.Location = new System.Drawing.Point(4, 34);
            this.tp_tafeloverzicht.Name = "tp_tafeloverzicht";
            this.tp_tafeloverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tp_tafeloverzicht.Size = new System.Drawing.Size(417, 553);
            this.tp_tafeloverzicht.TabIndex = 1;
            this.tp_tafeloverzicht.Text = "Overzicht tafel";
            this.tp_tafeloverzicht.UseVisualStyleBackColor = true;
            // 
            // btn_vrij
            // 
            this.btn_vrij.BackColor = System.Drawing.Color.LightGreen;
            this.btn_vrij.Location = new System.Drawing.Point(19, 480);
            this.btn_vrij.Name = "btn_vrij";
            this.btn_vrij.Size = new System.Drawing.Size(83, 53);
            this.btn_vrij.TabIndex = 7;
            this.btn_vrij.Text = "Vrij";
            this.btn_vrij.UseVisualStyleBackColor = false;
            this.btn_vrij.Click += new System.EventHandler(this.btn_vrij_Click);
            // 
            // btn_bezet
            // 
            this.btn_bezet.BackColor = System.Drawing.Color.Salmon;
            this.btn_bezet.Location = new System.Drawing.Point(108, 480);
            this.btn_bezet.Name = "btn_bezet";
            this.btn_bezet.Size = new System.Drawing.Size(81, 53);
            this.btn_bezet.TabIndex = 6;
            this.btn_bezet.Text = "Bezet";
            this.btn_bezet.UseVisualStyleBackColor = false;
            this.btn_bezet.Click += new System.EventHandler(this.btn_bezet_Click);
            // 
            // lbl_tafelnummer
            // 
            this.lbl_tafelnummer.AutoSize = true;
            this.lbl_tafelnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tafelnummer.Location = new System.Drawing.Point(146, 17);
            this.lbl_tafelnummer.Name = "lbl_tafelnummer";
            this.lbl_tafelnummer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_tafelnummer.Size = new System.Drawing.Size(82, 31);
            this.lbl_tafelnummer.TabIndex = 5;
            this.lbl_tafelnummer.Text = "Tafel ";
            this.lbl_tafelnummer.UseMnemonic = false;
            // 
            // btn_terugPlattegrond
            // 
            this.btn_terugPlattegrond.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terugPlattegrond.Location = new System.Drawing.Point(7, 6);
            this.btn_terugPlattegrond.Name = "btn_terugPlattegrond";
            this.btn_terugPlattegrond.Size = new System.Drawing.Size(42, 53);
            this.btn_terugPlattegrond.TabIndex = 4;
            this.btn_terugPlattegrond.Text = ">";
            this.btn_terugPlattegrond.UseVisualStyleBackColor = true;
            this.btn_terugPlattegrond.Click += new System.EventHandler(this.btn_terug_Click);
            // 
            // btn_afrekenen
            // 
            this.btn_afrekenen.Location = new System.Drawing.Point(206, 498);
            this.btn_afrekenen.Name = "btn_afrekenen";
            this.btn_afrekenen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_afrekenen.Size = new System.Drawing.Size(201, 44);
            this.btn_afrekenen.TabIndex = 3;
            this.btn_afrekenen.Text = "Afrekenen";
            this.btn_afrekenen.UseVisualStyleBackColor = true;
            this.btn_afrekenen.Click += new System.EventHandler(this.btn_afrekenen_Click);
            // 
            // btn_AddBestelling
            // 
            this.btn_AddBestelling.Location = new System.Drawing.Point(206, 448);
            this.btn_AddBestelling.Name = "btn_AddBestelling";
            this.btn_AddBestelling.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_AddBestelling.Size = new System.Drawing.Size(201, 44);
            this.btn_AddBestelling.TabIndex = 2;
            this.btn_AddBestelling.Text = "Voeg nieuw bestelling toe";
            this.btn_AddBestelling.UseVisualStyleBackColor = true;
            this.btn_AddBestelling.Click += new System.EventHandler(this.btn_AddBestelling_Click);
            // 
            // lv_bestelitems
            // 
            this.lv_bestelitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Aantal,
            this.Naam,
            this.Prijs});
            this.lv_bestelitems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_bestelitems.Location = new System.Drawing.Point(7, 65);
            this.lv_bestelitems.Name = "lv_bestelitems";
            this.lv_bestelitems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lv_bestelitems.Size = new System.Drawing.Size(404, 377);
            this.lv_bestelitems.TabIndex = 0;
            this.lv_bestelitems.UseCompatibleStateImageBehavior = false;
            this.lv_bestelitems.View = System.Windows.Forms.View.Details;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 50;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 280;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            this.Prijs.Width = 70;
            // 
            // tp_rekening
            // 
            this.tp_rekening.Controls.Add(this.btn_updatopm);
            this.tp_rekening.Controls.Add(this.txt_opmerking);
            this.tp_rekening.Controls.Add(this.btn_updatefooi);
            this.tp_rekening.Controls.Add(this.lbl_tafelnummer2);
            this.tp_rekening.Controls.Add(this.label15);
            this.tp_rekening.Controls.Add(this.label14);
            this.tp_rekening.Controls.Add(this.lbl_totaal);
            this.tp_rekening.Controls.Add(this.lbl_prijs);
            this.tp_rekening.Controls.Add(this.lbl_btwh);
            this.tp_rekening.Controls.Add(this.lbl_btwl);
            this.tp_rekening.Controls.Add(this.btn_Terug);
            this.tp_rekening.Controls.Add(this.txt_tip);
            this.tp_rekening.Controls.Add(this.btn_pin);
            this.tp_rekening.Controls.Add(this.btn_contant);
            this.tp_rekening.Controls.Add(this.label9);
            this.tp_rekening.Controls.Add(this.label8);
            this.tp_rekening.Controls.Add(this.label7);
            this.tp_rekening.Controls.Add(this.label6);
            this.tp_rekening.Controls.Add(this.label5);
            this.tp_rekening.Controls.Add(this.lbl_mednaam);
            this.tp_rekening.Controls.Add(this.label2);
            this.tp_rekening.Controls.Add(this.listView2);
            this.tp_rekening.Location = new System.Drawing.Point(4, 34);
            this.tp_rekening.Name = "tp_rekening";
            this.tp_rekening.Size = new System.Drawing.Size(417, 553);
            this.tp_rekening.TabIndex = 2;
            this.tp_rekening.Text = "Rekening opmaken";
            this.tp_rekening.UseVisualStyleBackColor = true;
            this.tp_rekening.Click += new System.EventHandler(this.tp_rekening_Click);
            // 
            // btn_updatopm
            // 
            this.btn_updatopm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatopm.Location = new System.Drawing.Point(119, 469);
            this.btn_updatopm.Name = "btn_updatopm";
            this.btn_updatopm.Size = new System.Drawing.Size(175, 30);
            this.btn_updatopm.TabIndex = 22;
            this.btn_updatopm.Text = "Voeg opmerking toe";
            this.btn_updatopm.UseVisualStyleBackColor = true;
            this.btn_updatopm.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_opmerking
            // 
            this.txt_opmerking.Location = new System.Drawing.Point(10, 417);
            this.txt_opmerking.Multiline = true;
            this.txt_opmerking.Name = "txt_opmerking";
            this.txt_opmerking.Size = new System.Drawing.Size(401, 46);
            this.txt_opmerking.TabIndex = 21;
            // 
            // btn_updatefooi
            // 
            this.btn_updatefooi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatefooi.Location = new System.Drawing.Point(358, 354);
            this.btn_updatefooi.Name = "btn_updatefooi";
            this.btn_updatefooi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_updatefooi.Size = new System.Drawing.Size(50, 20);
            this.btn_updatefooi.TabIndex = 20;
            this.btn_updatefooi.Text = "+";
            this.btn_updatefooi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_updatefooi.UseVisualStyleBackColor = true;
            this.btn_updatefooi.Click += new System.EventHandler(this.btn_updatefooi_Click);
            // 
            // lbl_tafelnummer2
            // 
            this.lbl_tafelnummer2.AutoSize = true;
            this.lbl_tafelnummer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tafelnummer2.Location = new System.Drawing.Point(146, 17);
            this.lbl_tafelnummer2.Name = "lbl_tafelnummer2";
            this.lbl_tafelnummer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_tafelnummer2.Size = new System.Drawing.Size(82, 31);
            this.lbl_tafelnummer2.TabIndex = 19;
            this.lbl_tafelnummer2.Text = "Tafel ";
            this.lbl_tafelnummer2.UseMnemonic = false;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(10, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(397, 2);
            this.label15.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(11, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(397, 2);
            this.label14.TabIndex = 17;
            // 
            // lbl_totaal
            // 
            this.lbl_totaal.AutoSize = true;
            this.lbl_totaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totaal.Location = new System.Drawing.Point(355, 388);
            this.lbl_totaal.Name = "lbl_totaal";
            this.lbl_totaal.Size = new System.Drawing.Size(0, 16);
            this.lbl_totaal.TabIndex = 16;
            // 
            // lbl_prijs
            // 
            this.lbl_prijs.AutoSize = true;
            this.lbl_prijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prijs.Location = new System.Drawing.Point(355, 334);
            this.lbl_prijs.Name = "lbl_prijs";
            this.lbl_prijs.Size = new System.Drawing.Size(0, 16);
            this.lbl_prijs.TabIndex = 15;
            // 
            // lbl_btwh
            // 
            this.lbl_btwh.AutoSize = true;
            this.lbl_btwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btwh.Location = new System.Drawing.Point(355, 312);
            this.lbl_btwh.Name = "lbl_btwh";
            this.lbl_btwh.Size = new System.Drawing.Size(0, 16);
            this.lbl_btwh.TabIndex = 14;
            // 
            // lbl_btwl
            // 
            this.lbl_btwl.AutoSize = true;
            this.lbl_btwl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_btwl.Location = new System.Drawing.Point(355, 288);
            this.lbl_btwl.Name = "lbl_btwl";
            this.lbl_btwl.Size = new System.Drawing.Size(0, 16);
            this.lbl_btwl.TabIndex = 13;
            // 
            // btn_Terug
            // 
            this.btn_Terug.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Terug.Location = new System.Drawing.Point(7, 6);
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Terug.Size = new System.Drawing.Size(42, 53);
            this.btn_Terug.TabIndex = 12;
            this.btn_Terug.Text = "<";
            this.btn_Terug.UseVisualStyleBackColor = true;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // txt_tip
            // 
            this.txt_tip.Location = new System.Drawing.Point(252, 355);
            this.txt_tip.Name = "txt_tip";
            this.txt_tip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_tip.Size = new System.Drawing.Size(100, 20);
            this.txt_tip.TabIndex = 11;
            // 
            // btn_pin
            // 
            this.btn_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pin.Location = new System.Drawing.Point(209, 502);
            this.btn_pin.Name = "btn_pin";
            this.btn_pin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_pin.Size = new System.Drawing.Size(198, 40);
            this.btn_pin.TabIndex = 10;
            this.btn_pin.Text = "Pinnen";
            this.btn_pin.UseVisualStyleBackColor = true;
            this.btn_pin.Click += new System.EventHandler(this.btn_pin_Click);
            // 
            // btn_contant
            // 
            this.btn_contant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contant.Location = new System.Drawing.Point(7, 502);
            this.btn_contant.Name = "btn_contant";
            this.btn_contant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_contant.Size = new System.Drawing.Size(196, 40);
            this.btn_contant.TabIndex = 9;
            this.btn_contant.Text = "Contant betalen";
            this.btn_contant.UseVisualStyleBackColor = true;
            this.btn_contant.Click += new System.EventHandler(this.btn_contant_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 388);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Totaalprijs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 356);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tip";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 334);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prijs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 312);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "BTW 21%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 288);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "BTW 6%";
            // 
            // lbl_mednaam
            // 
            this.lbl_mednaam.AutoSize = true;
            this.lbl_mednaam.Location = new System.Drawing.Point(352, 46);
            this.lbl_mednaam.Name = "lbl_mednaam";
            this.lbl_mednaam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_mednaam.Size = new System.Drawing.Size(0, 13);
            this.lbl_mednaam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 46);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medewerker : ";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.Location = new System.Drawing.Point(7, 65);
            this.listView2.Name = "listView2";
            this.listView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView2.Size = new System.Drawing.Size(404, 216);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Aantal";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naam";
            this.columnHeader2.Width = 280;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prijs";
            this.columnHeader3.Width = 70;
            // 
            // lbl_Tafelstatus
            // 
            this.lbl_Tafelstatus.AutoSize = true;
            this.lbl_Tafelstatus.Location = new System.Drawing.Point(19, 461);
            this.lbl_Tafelstatus.Name = "lbl_Tafelstatus";
            this.lbl_Tafelstatus.Size = new System.Drawing.Size(184, 16);
            this.lbl_Tafelstatus.TabIndex = 8;
            this.lbl_Tafelstatus.Text = "Als dit er staat is het niet goed";
            // 
            // RekeningOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 591);
            this.Controls.Add(this.tabControl1);
            this.Name = "RekeningOverzicht";
            this.Text = "RekeningOverzicht";
            this.tabControl1.ResumeLayout(false);
            this.tp_tafeloverzicht.ResumeLayout(false);
            this.tp_tafeloverzicht.PerformLayout();
            this.tp_rekening.ResumeLayout(false);
            this.tp_rekening.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_tafeloverzicht;
        private System.Windows.Forms.TabPage tp_rekening;
        private System.Windows.Forms.Label lbl_tafelnummer;
        private System.Windows.Forms.Button btn_terugPlattegrond;
        private System.Windows.Forms.Button btn_afrekenen;
        private System.Windows.Forms.Button btn_AddBestelling;
        private System.Windows.Forms.ListView lv_bestelitems;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_totaal;
        private System.Windows.Forms.Label lbl_prijs;
        private System.Windows.Forms.Label lbl_btwh;
        private System.Windows.Forms.Label lbl_btwl;
        private System.Windows.Forms.Button btn_Terug;
        private System.Windows.Forms.TextBox txt_tip;
        private System.Windows.Forms.Button btn_pin;
        private System.Windows.Forms.Button btn_contant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_mednaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbl_tafelnummer2;
        private System.Windows.Forms.Button btn_updatefooi;
        private System.Windows.Forms.Button btn_updatopm;
        private System.Windows.Forms.TextBox txt_opmerking;
        private System.Windows.Forms.Button btn_vrij;
        private System.Windows.Forms.Button btn_bezet;
        private System.Windows.Forms.Label lbl_Tafelstatus;
    }
}