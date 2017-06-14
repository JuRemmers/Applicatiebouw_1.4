namespace Systeem
{
    partial class BestellingOverzicht
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
            this.clb_besteIitems = new System.Windows.Forms.ListView();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.btn_aanpassen = new System.Windows.Forms.Button();
            this.lb_bestelling = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_bestellingtitel = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // clb_besteIitems
            // 
            this.clb_besteIitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.clb_besteIitems.Location = new System.Drawing.Point(13, 46);
            this.clb_besteIitems.Name = "clb_besteIitems";
            this.clb_besteIitems.Size = new System.Drawing.Size(399, 489);
            this.clb_besteIitems.TabIndex = 0;
            this.clb_besteIitems.UseCompatibleStateImageBehavior = false;
            this.clb_besteIitems.View = System.Windows.Forms.View.Details;
            // 
            // cb_status
            // 
            this.cb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(12, 541);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(197, 39);
            this.cb_status.TabIndex = 1;
            // 
            // btn_aanpassen
            // 
            this.btn_aanpassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_aanpassen.Location = new System.Drawing.Point(215, 540);
            this.btn_aanpassen.Name = "btn_aanpassen";
            this.btn_aanpassen.Size = new System.Drawing.Size(197, 39);
            this.btn_aanpassen.TabIndex = 2;
            this.btn_aanpassen.Text = "Aanpassen";
            this.btn_aanpassen.UseVisualStyleBackColor = true;
            // 
            // lb_bestelling
            // 
            this.lb_bestelling.AutoSize = true;
            this.lb_bestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lb_bestelling.Location = new System.Drawing.Point(383, 9);
            this.lb_bestelling.Name = "lb_bestelling";
            this.lb_bestelling.Size = new System.Drawing.Size(29, 31);
            this.lb_bestelling.TabIndex = 3;
            this.lb_bestelling.Text = "0";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(13, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 31);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Terug";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_bestellingtitel
            // 
            this.lb_bestellingtitel.AutoSize = true;
            this.lb_bestellingtitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lb_bestellingtitel.Location = new System.Drawing.Point(237, 9);
            this.lb_bestellingtitel.Name = "lb_bestellingtitel";
            this.lb_bestellingtitel.Size = new System.Drawing.Size(140, 31);
            this.lb_bestellingtitel.TabIndex = 5;
            this.lb_bestellingtitel.Text = "Bestelling:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gerecht";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aantal";
            // 
            // BestellingOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 591);
            this.Controls.Add(this.lb_bestellingtitel);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_bestelling);
            this.Controls.Add(this.btn_aanpassen);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.clb_besteIitems);
            this.Name = "BestellingOverzicht";
            this.Text = "BestellingOverzicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView clb_besteIitems;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button btn_aanpassen;
        public System.Windows.Forms.Label lb_bestelling;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_bestellingtitel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}