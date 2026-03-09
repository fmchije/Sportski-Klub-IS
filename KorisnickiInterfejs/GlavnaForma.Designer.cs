namespace KorisnickiInterfejs
{
    partial class GlavnaForma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rasporedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vezbacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cenovnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azurirajRasporedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(305, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniToolStripMenuItem,
            this.rasporedToolStripMenuItem,
            this.vezbacToolStripMenuItem,
            this.placanjeToolStripMenuItem,
            this.cenovnikToolStripMenuItem,
            this.azurirajRasporedToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // zaposleniToolStripMenuItem
            // 
            this.zaposleniToolStripMenuItem.Name = "zaposleniToolStripMenuItem";
            this.zaposleniToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.zaposleniToolStripMenuItem.Text = "Zaposleni";
            this.zaposleniToolStripMenuItem.Click += new System.EventHandler(this.zaposleniToolStripMenuItem_Click);
            // 
            // rasporedToolStripMenuItem
            // 
            this.rasporedToolStripMenuItem.Name = "rasporedToolStripMenuItem";
            this.rasporedToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.rasporedToolStripMenuItem.Text = "Raspored";
            this.rasporedToolStripMenuItem.Click += new System.EventHandler(this.rasporedToolStripMenuItem_Click);
            // 
            // vezbacToolStripMenuItem
            // 
            this.vezbacToolStripMenuItem.Name = "vezbacToolStripMenuItem";
            this.vezbacToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.vezbacToolStripMenuItem.Text = "Vezbac";
            this.vezbacToolStripMenuItem.Click += new System.EventHandler(this.vezbacToolStripMenuItem_Click);
            // 
            // placanjeToolStripMenuItem
            // 
            this.placanjeToolStripMenuItem.Name = "placanjeToolStripMenuItem";
            this.placanjeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.placanjeToolStripMenuItem.Text = "Placanje";
            this.placanjeToolStripMenuItem.Click += new System.EventHandler(this.placanjeToolStripMenuItem_Click);
            // 
            // cenovnikToolStripMenuItem
            // 
            this.cenovnikToolStripMenuItem.Name = "cenovnikToolStripMenuItem";
            this.cenovnikToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cenovnikToolStripMenuItem.Text = "Cenovnik";
            this.cenovnikToolStripMenuItem.Click += new System.EventHandler(this.cenovnikToolStripMenuItem_Click);
            // 
            // azurirajRasporedToolStripMenuItem
            // 
            this.azurirajRasporedToolStripMenuItem.Name = "azurirajRasporedToolStripMenuItem";
            this.azurirajRasporedToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.azurirajRasporedToolStripMenuItem.Text = "Azuriraj Raspored";
            this.azurirajRasporedToolStripMenuItem.Click += new System.EventHandler(this.azurirajRasporedToolStripMenuItem_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 280);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rasporedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vezbacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cenovnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azurirajRasporedToolStripMenuItem;
    }
}