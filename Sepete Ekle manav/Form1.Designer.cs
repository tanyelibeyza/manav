namespace Sepete_Ekle_manav
{
    partial class Form1
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
            this.txtManav = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSecilenisil = new System.Windows.Forms.Button();
            this.lblurun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtManav
            // 
            this.txtManav.Location = new System.Drawing.Point(57, 35);
            this.txtManav.Name = "txtManav";
            this.txtManav.Size = new System.Drawing.Size(131, 20);
            this.txtManav.TabIndex = 0;
            this.txtManav.TextChanged += new System.EventHandler(this.txtManav_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(57, 91);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(131, 24);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Sepete Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(224, 35);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(155, 108);
            this.lstSepet.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(57, 169);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(131, 24);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSecilenisil
            // 
            this.btnSecilenisil.BackColor = System.Drawing.Color.White;
            this.btnSecilenisil.Location = new System.Drawing.Point(57, 130);
            this.btnSecilenisil.Name = "btnSecilenisil";
            this.btnSecilenisil.Size = new System.Drawing.Size(131, 23);
            this.btnSecilenisil.TabIndex = 4;
            this.btnSecilenisil.Text = "Seçileni Sil";
            this.btnSecilenisil.UseVisualStyleBackColor = false;
            this.btnSecilenisil.Click += new System.EventHandler(this.btnSecilenisil_Click);
            // 
            // lblurun
            // 
            this.lblurun.AutoSize = true;
            this.lblurun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblurun.Location = new System.Drawing.Point(12, 35);
            this.lblurun.Name = "lblurun";
            this.lblurun.Size = new System.Drawing.Size(40, 15);
            this.lblurun.TabIndex = 5;
            this.lblurun.Text = "ürün:";
            this.lblurun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 250);
            this.Controls.Add(this.lblurun);
            this.Controls.Add(this.btnSecilenisil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtManav);
            this.Name = "Form1";
            this.Text = "Sepete Ekleme Programı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtManav;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSecilenisil;
        private System.Windows.Forms.Label lblurun;
    }
}

