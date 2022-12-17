namespace Inlämningsuppgift_3
{
    partial class FrmRegistrering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrering));
            this.gbxPersUppg = new System.Windows.Forms.GroupBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.tbxPersNr = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEfternamn = new System.Windows.Forms.Label();
            this.lblFörnamn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStripRegistrera = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAvsluta = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxPersUppg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPersUppg
            // 
            this.gbxPersUppg.Controls.Add(this.BtnOK);
            this.gbxPersUppg.Controls.Add(this.tbxPersNr);
            this.gbxPersUppg.Controls.Add(this.tbxEfternamn);
            this.gbxPersUppg.Controls.Add(this.tbxFörnamn);
            this.gbxPersUppg.Controls.Add(this.label3);
            this.gbxPersUppg.Controls.Add(this.lblEfternamn);
            this.gbxPersUppg.Controls.Add(this.lblFörnamn);
            this.gbxPersUppg.Enabled = false;
            this.gbxPersUppg.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPersUppg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxPersUppg.Location = new System.Drawing.Point(61, 154);
            this.gbxPersUppg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPersUppg.Name = "gbxPersUppg";
            this.gbxPersUppg.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPersUppg.Size = new System.Drawing.Size(531, 176);
            this.gbxPersUppg.TabIndex = 0;
            this.gbxPersUppg.TabStop = false;
            this.gbxPersUppg.Text = "Ange namn och personnummer:";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(371, 78);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(125, 43);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // tbxPersNr
            // 
            this.tbxPersNr.Location = new System.Drawing.Point(177, 119);
            this.tbxPersNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPersNr.Name = "tbxPersNr";
            this.tbxPersNr.Size = new System.Drawing.Size(159, 34);
            this.tbxPersNr.TabIndex = 5;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(177, 79);
            this.tbxEfternamn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(159, 34);
            this.tbxEfternamn.TabIndex = 4;
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(177, 39);
            this.tbxFörnamn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(159, 34);
            this.tbxFörnamn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personnummer:";
            // 
            // lblEfternamn
            // 
            this.lblEfternamn.AutoSize = true;
            this.lblEfternamn.Location = new System.Drawing.Point(7, 82);
            this.lblEfternamn.Name = "lblEfternamn";
            this.lblEfternamn.Size = new System.Drawing.Size(114, 27);
            this.lblEfternamn.TabIndex = 1;
            this.lblEfternamn.Text = "Efternamn:";
            // 
            // lblFörnamn
            // 
            this.lblFörnamn.AutoSize = true;
            this.lblFörnamn.Location = new System.Drawing.Point(7, 42);
            this.lblFörnamn.Name = "lblFörnamn";
            this.lblFörnamn.Size = new System.Drawing.Size(99, 27);
            this.lblFörnamn.TabIndex = 0;
            this.lblFörnamn.Text = "Förnamn:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 63);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Enabled = false;
            this.lblResultat.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(256, 382);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(142, 32);
            this.lblResultat.TabIndex = 2;
            this.lblResultat.Text = "RESULTAT";
            // 
            // tbxResultat
            // 
            this.tbxResultat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxResultat.Enabled = false;
            this.tbxResultat.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResultat.Location = new System.Drawing.Point(61, 416);
            this.tbxResultat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxResultat.Multiline = true;
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.ReadOnly = true;
            this.tbxResultat.Size = new System.Drawing.Size(529, 342);
            this.tbxResultat.TabIndex = 3;
            this.tbxResultat.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripRegistrera,
            this.MenuStripAvsluta});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(668, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "MenuStrip";
            // 
            // MenuStripRegistrera
            // 
            this.MenuStripRegistrera.Name = "MenuStripRegistrera";
            this.MenuStripRegistrera.Size = new System.Drawing.Size(103, 27);
            this.MenuStripRegistrera.Text = "Registrera";
            this.MenuStripRegistrera.Click += new System.EventHandler(this.MenuStripRegistrera_Click);
            // 
            // MenuStripAvsluta
            // 
            this.MenuStripAvsluta.Name = "MenuStripAvsluta";
            this.MenuStripAvsluta.Size = new System.Drawing.Size(83, 27);
            this.MenuStripAvsluta.Text = "Avsluta";
            this.MenuStripAvsluta.Click += new System.EventHandler(this.MenuStripAvsluta_Click);
            // 
            // FrmRegistrering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(668, 811);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxPersUppg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegistrering";
            this.Text = "Registrering";
            this.gbxPersUppg.ResumeLayout(false);
            this.gbxPersUppg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPersUppg;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox tbxPersNr;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEfternamn;
        private System.Windows.Forms.Label lblFörnamn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.TextBox tbxResultat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRegistrera;
        private System.Windows.Forms.ToolStripMenuItem MenuStripAvsluta;
    }
}

