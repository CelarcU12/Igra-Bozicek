namespace bozicek
{
    partial class okno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(okno));
            this.časBožička = new System.Windows.Forms.Timer(this.components);
            this.padanjeDaril = new System.Windows.Forms.Timer(this.components);
            this.padanjeBombe = new System.Windows.Forms.Timer(this.components);
            this.ozadje = new System.Windows.Forms.Panel();
            this.gumbIme = new System.Windows.Forms.Button();
            this.ime = new System.Windows.Forms.TextBox();
            this.uvod = new System.Windows.Forms.Label();
            this.zivljenje3 = new System.Windows.Forms.PictureBox();
            this.zivljenje2 = new System.Windows.Forms.PictureBox();
            this.zivljenje1 = new System.Windows.Forms.PictureBox();
            this.bomba = new System.Windows.Forms.PictureBox();
            this.pavza = new System.Windows.Forms.Button();
            this.znova = new System.Windows.Forms.Button();
            this.konec = new System.Windows.Forms.Label();
            this.rezultat = new System.Windows.Forms.Label();
            this.START = new System.Windows.Forms.Button();
            this.darilo = new System.Windows.Forms.PictureBox();
            this.bozicek = new System.Windows.Forms.PictureBox();
            this.lblLestvica = new System.Windows.Forms.Label();
            this.ozadje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zivljenje3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivljenje2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivljenje1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bozicek)).BeginInit();
            this.SuspendLayout();
            // 
            // časBožička
            // 
            this.časBožička.Enabled = true;
            this.časBožička.Interval = 5;
            this.časBožička.Tick += new System.EventHandler(this.časBožička_Tick);
            // 
            // padanjeDaril
            // 
            this.padanjeDaril.Interval = 5;
            this.padanjeDaril.Tick += new System.EventHandler(this.padanjeDaril_Tick);
            // 
            // padanjeBombe
            // 
            this.padanjeBombe.Interval = 5;
            this.padanjeBombe.Tick += new System.EventHandler(this.padanjeBombe_Tick);
            // 
            // ozadje
            // 
            this.ozadje.BackColor = System.Drawing.SystemColors.Control;
            this.ozadje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ozadje.BackgroundImage")));
            this.ozadje.Controls.Add(this.lblLestvica);
            this.ozadje.Controls.Add(this.gumbIme);
            this.ozadje.Controls.Add(this.ime);
            this.ozadje.Controls.Add(this.uvod);
            this.ozadje.Controls.Add(this.zivljenje3);
            this.ozadje.Controls.Add(this.zivljenje2);
            this.ozadje.Controls.Add(this.zivljenje1);
            this.ozadje.Controls.Add(this.bomba);
            this.ozadje.Controls.Add(this.pavza);
            this.ozadje.Controls.Add(this.znova);
            this.ozadje.Controls.Add(this.konec);
            this.ozadje.Controls.Add(this.rezultat);
            this.ozadje.Controls.Add(this.START);
            this.ozadje.Controls.Add(this.darilo);
            this.ozadje.Controls.Add(this.bozicek);
            this.ozadje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ozadje.Location = new System.Drawing.Point(0, 0);
            this.ozadje.Name = "ozadje";
            this.ozadje.Size = new System.Drawing.Size(1208, 632);
            this.ozadje.TabIndex = 1;
            // 
            // gumbIme
            // 
            this.gumbIme.BackColor = System.Drawing.Color.Turquoise;
            this.gumbIme.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbIme.ForeColor = System.Drawing.Color.Brown;
            this.gumbIme.Location = new System.Drawing.Point(815, 223);
            this.gumbIme.Name = "gumbIme";
            this.gumbIme.Size = new System.Drawing.Size(67, 50);
            this.gumbIme.TabIndex = 13;
            this.gumbIme.Text = "Ok";
            this.gumbIme.UseVisualStyleBackColor = false;
            this.gumbIme.Visible = false;
            this.gumbIme.Click += new System.EventHandler(this.gumbIme_Click);
            this.gumbIme.Enter += new System.EventHandler(this.gumbIme_Click);
            // 
            // ime
            // 
            this.ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ime.Location = new System.Drawing.Point(639, 223);
            this.ime.MaxLength = 15;
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(170, 26);
            this.ime.TabIndex = 12;
            this.ime.Visible = false;
            // 
            // uvod
            // 
            this.uvod.AutoSize = true;
            this.uvod.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uvod.ForeColor = System.Drawing.Color.Brown;
            this.uvod.Image = global::bozicek.Properties.Resources.uvod1;
            this.uvod.Location = new System.Drawing.Point(316, 46);
            this.uvod.Name = "uvod";
            this.uvod.Size = new System.Drawing.Size(0, 47);
            this.uvod.TabIndex = 11;
            // 
            // zivljenje3
            // 
            this.zivljenje3.BackColor = System.Drawing.Color.White;
            this.zivljenje3.BackgroundImage = global::bozicek.Properties.Resources.zivljOzd;
            this.zivljenje3.Location = new System.Drawing.Point(1002, 83);
            this.zivljenje3.Name = "zivljenje3";
            this.zivljenje3.Size = new System.Drawing.Size(30, 26);
            this.zivljenje3.TabIndex = 10;
            this.zivljenje3.TabStop = false;
            this.zivljenje3.Visible = false;
            // 
            // zivljenje2
            // 
            this.zivljenje2.BackColor = System.Drawing.Color.White;
            this.zivljenje2.BackgroundImage = global::bozicek.Properties.Resources.zivljOzd;
            this.zivljenje2.Location = new System.Drawing.Point(966, 83);
            this.zivljenje2.Name = "zivljenje2";
            this.zivljenje2.Size = new System.Drawing.Size(30, 26);
            this.zivljenje2.TabIndex = 9;
            this.zivljenje2.TabStop = false;
            this.zivljenje2.Visible = false;
            // 
            // zivljenje1
            // 
            this.zivljenje1.BackColor = System.Drawing.Color.White;
            this.zivljenje1.BackgroundImage = global::bozicek.Properties.Resources.zivljOzd;
            this.zivljenje1.Location = new System.Drawing.Point(930, 83);
            this.zivljenje1.Name = "zivljenje1";
            this.zivljenje1.Size = new System.Drawing.Size(30, 26);
            this.zivljenje1.TabIndex = 8;
            this.zivljenje1.TabStop = false;
            this.zivljenje1.Visible = false;
            // 
            // bomba
            // 
            this.bomba.BackColor = System.Drawing.Color.SkyBlue;
            this.bomba.Location = new System.Drawing.Point(281, 202);
            this.bomba.Name = "bomba";
            this.bomba.Size = new System.Drawing.Size(40, 40);
            this.bomba.TabIndex = 7;
            this.bomba.TabStop = false;
            this.bomba.Visible = false;
            // 
            // pavza
            // 
            this.pavza.AutoEllipsis = true;
            this.pavza.BackColor = System.Drawing.Color.Turquoise;
            this.pavza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pavza.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pavza.ForeColor = System.Drawing.Color.Brown;
            this.pavza.Location = new System.Drawing.Point(25, 418);
            this.pavza.Name = "pavza";
            this.pavza.Size = new System.Drawing.Size(99, 33);
            this.pavza.TabIndex = 6;
            this.pavza.Text = "pavza";
            this.pavza.UseCompatibleTextRendering = true;
            this.pavza.UseVisualStyleBackColor = false;
            this.pavza.Click += new System.EventHandler(this.pauza_Click);
            // 
            // znova
            // 
            this.znova.BackColor = System.Drawing.Color.Turquoise;
            this.znova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.znova.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.znova.ForeColor = System.Drawing.Color.Brown;
            this.znova.Location = new System.Drawing.Point(479, 60);
            this.znova.Name = "znova";
            this.znova.Size = new System.Drawing.Size(189, 49);
            this.znova.TabIndex = 5;
            this.znova.Text = "ZNOVA";
            this.znova.UseVisualStyleBackColor = false;
            this.znova.Click += new System.EventHandler(this.znova_Click);
            // 
            // konec
            // 
            this.konec.AutoSize = true;
            this.konec.BackColor = System.Drawing.Color.DarkTurquoise;
            this.konec.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.konec.ForeColor = System.Drawing.Color.Brown;
            this.konec.Location = new System.Drawing.Point(459, 116);
            this.konec.Name = "konec";
            this.konec.Size = new System.Drawing.Size(216, 85);
            this.konec.TabIndex = 4;
            this.konec.Text = "KONEC";
            // 
            // rezultat
            // 
            this.rezultat.AutoSize = true;
            this.rezultat.BackColor = System.Drawing.Color.DarkTurquoise;
            this.rezultat.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezultat.ForeColor = System.Drawing.Color.Brown;
            this.rezultat.Image = global::bozicek.Properties.Resources.rezul;
            this.rezultat.Location = new System.Drawing.Point(957, 9);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(153, 51);
            this.rezultat.TabIndex = 3;
            this.rezultat.Text = "Rezultat:";
            this.rezultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rezultat.Visible = false;
            // 
            // START
            // 
            this.START.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.START.BackColor = System.Drawing.Color.Turquoise;
            this.START.Cursor = System.Windows.Forms.Cursors.Hand;
            this.START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.START.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.START.ForeColor = System.Drawing.Color.Brown;
            this.START.Location = new System.Drawing.Point(469, 249);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(199, 71);
            this.START.TabIndex = 2;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // darilo
            // 
            this.darilo.BackColor = System.Drawing.Color.SkyBlue;
            this.darilo.Location = new System.Drawing.Point(281, 83);
            this.darilo.Name = "darilo";
            this.darilo.Size = new System.Drawing.Size(40, 40);
            this.darilo.TabIndex = 1;
            this.darilo.TabStop = false;
            this.darilo.Visible = false;
            // 
            // bozicek
            // 
            this.bozicek.BackgroundImage = global::bozicek.Properties.Resources.bozicekPremik;
            this.bozicek.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bozicek.ErrorImage")));
            this.bozicek.InitialImage = ((System.Drawing.Image)(resources.GetObject("bozicek.InitialImage")));
            this.bozicek.Location = new System.Drawing.Point(512, 460);
            this.bozicek.Name = "bozicek";
            this.bozicek.Size = new System.Drawing.Size(70, 120);
            this.bozicek.TabIndex = 0;
            this.bozicek.TabStop = false;
            this.bozicek.WaitOnLoad = true;
            // 
            // lblLestvica
            // 
            this.lblLestvica.AutoSize = true;
            this.lblLestvica.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblLestvica.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLestvica.ForeColor = System.Drawing.Color.Brown;
            this.lblLestvica.Location = new System.Drawing.Point(459, 201);
            this.lblLestvica.Name = "lblLestvica";
            this.lblLestvica.Size = new System.Drawing.Size(174, 57);
            this.lblLestvica.TabIndex = 14;
            this.lblLestvica.Text = "Lestvica: ";
            this.lblLestvica.Visible = false;
            // 
            // okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 632);
            this.Controls.Add(this.ozadje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "okno";
            this.Text = "Božiček - avtor: Urban Celarc";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.okno_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.okno_KeyUp);
            this.ozadje.ResumeLayout(false);
            this.ozadje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zivljenje3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivljenje2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivljenje1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bozicek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ozadje;
        private System.Windows.Forms.PictureBox bozicek;
        private System.Windows.Forms.Timer časBožička;
        private System.Windows.Forms.Timer padanjeDaril;
        private System.Windows.Forms.PictureBox darilo;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Label rezultat;
        private System.Windows.Forms.Label konec;
        private System.Windows.Forms.Button znova;
        private System.Windows.Forms.PictureBox bomba;
        private System.Windows.Forms.Timer padanjeBombe;
        private System.Windows.Forms.PictureBox zivljenje3;
        private System.Windows.Forms.PictureBox zivljenje2;
        private System.Windows.Forms.PictureBox zivljenje1;
        private System.Windows.Forms.Label uvod;
        private System.Windows.Forms.Button pavza;
        private System.Windows.Forms.Button gumbIme;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.Label lblLestvica;
    }
}

