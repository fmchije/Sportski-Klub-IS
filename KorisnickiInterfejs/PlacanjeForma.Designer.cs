namespace KorisnickiInterfejs
{
    partial class PlacanjeForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVezbac = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDan = new System.Windows.Forms.ComboBox();
            this.cmbMesec = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.Iznos = new System.Windows.Forms.Label();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vezbac";
            // 
            // cmbVezbac
            // 
            this.cmbVezbac.FormattingEnabled = true;
            this.cmbVezbac.Location = new System.Drawing.Point(96, 62);
            this.cmbVezbac.Name = "cmbVezbac";
            this.cmbVezbac.Size = new System.Drawing.Size(121, 21);
            this.cmbVezbac.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mesec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Godina";
            // 
            // cmbDan
            // 
            this.cmbDan.FormattingEnabled = true;
            this.cmbDan.Location = new System.Drawing.Point(186, 124);
            this.cmbDan.Name = "cmbDan";
            this.cmbDan.Size = new System.Drawing.Size(41, 21);
            this.cmbDan.TabIndex = 7;
            // 
            // cmbMesec
            // 
            this.cmbMesec.FormattingEnabled = true;
            this.cmbMesec.Location = new System.Drawing.Point(275, 124);
            this.cmbMesec.Name = "cmbMesec";
            this.cmbMesec.Size = new System.Drawing.Size(33, 21);
            this.cmbMesec.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Uplata";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(186, 197);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(100, 20);
            this.txtIznos.TabIndex = 11;
            // 
            // Iznos
            // 
            this.Iznos.AutoSize = true;
            this.Iznos.Location = new System.Drawing.Point(128, 204);
            this.Iznos.Name = "Iznos";
            this.Iznos.Size = new System.Drawing.Size(32, 13);
            this.Iznos.TabIndex = 12;
            this.Iznos.Text = "Iznos";
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(354, 124);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(78, 20);
            this.txtGodina.TabIndex = 13;
            // 
            // PlacanjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 361);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.Iznos);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbMesec);
            this.Controls.Add(this.cmbDan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVezbac);
            this.Controls.Add(this.label1);
            this.Name = "PlacanjeForma";
            this.Text = "PlacanjeForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVezbac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDan;
        private System.Windows.Forms.ComboBox cmbMesec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label Iznos;
        private System.Windows.Forms.TextBox txtGodina;
    }
}