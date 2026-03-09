namespace KorisnickiInterfejs
{
    partial class VezbacForma
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
            this.dgvVezbaci = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbVezbac = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDug = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVezbaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVezbaci
            // 
            this.dgvVezbaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVezbaci.Location = new System.Drawing.Point(305, 12);
            this.dgvVezbaci.Name = "dgvVezbaci";
            this.dgvVezbaci.Size = new System.Drawing.Size(490, 273);
            this.dgvVezbaci.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi ime i Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesi JMBG";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj vezbaca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(145, 52);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(100, 20);
            this.txtImePrezime.TabIndex = 4;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(145, 93);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(100, 20);
            this.txtJMBG.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Prikazi Vezbace";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbVezbac
            // 
            this.cmbVezbac.FormattingEnabled = true;
            this.cmbVezbac.Location = new System.Drawing.Point(180, 318);
            this.cmbVezbac.Name = "cmbVezbac";
            this.cmbVezbac.Size = new System.Drawing.Size(121, 21);
            this.cmbVezbac.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Vrati dug vežbača";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDug
            // 
            this.txtDug.Location = new System.Drawing.Point(145, 348);
            this.txtDug.Name = "txtDug";
            this.txtDug.Size = new System.Drawing.Size(100, 20);
            this.txtDug.TabIndex = 9;
            // 
            // VezbacForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 380);
            this.Controls.Add(this.txtDug);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbVezbac);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVezbaci);
            this.Name = "VezbacForma";
            this.Text = "VezbacForma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVezbaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVezbaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbVezbac;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtDug;
    }
}