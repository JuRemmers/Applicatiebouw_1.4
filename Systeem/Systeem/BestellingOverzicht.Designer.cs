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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.btn_aanpassen = new System.Windows.Forms.Button();
            this.lb_bestelling = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 489);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.lb_bestelling.Location = new System.Drawing.Point(265, 9);
            this.lb_bestelling.Name = "lb_bestelling";
            this.lb_bestelling.Size = new System.Drawing.Size(147, 31);
            this.lb_bestelling.TabIndex = 3;
            this.lb_bestelling.Text = "Bestelling#";
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
            // BestellingOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 591);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_bestelling);
            this.Controls.Add(this.btn_aanpassen);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.listView1);
            this.Name = "BestellingOverzicht";
            this.Text = "BestellingOverzicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button btn_aanpassen;
        public System.Windows.Forms.Label lb_bestelling;
        private System.Windows.Forms.Button btn_back;
    }
}