namespace felhasznalo_nyilvantartas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nevtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addb = new System.Windows.Forms.Button();
            this.editb = new System.Windows.Forms.Button();
            this.deleteb = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lista = new System.Windows.Forms.ListBox();
            this._profil_feltolt = new System.Windows.Forms.Button();
            this.profiltxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(308, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználó nyilvántartás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(213, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(213, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Születési Dátum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(214, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID:";
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(376, 170);
            this.datum.MaxDate = new System.DateTime(2022, 12, 14, 0, 0, 0, 0);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(200, 20);
            this.datum.TabIndex = 5;
            this.datum.Value = new System.DateTime(2022, 12, 14, 0, 0, 0, 0);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(312, 79);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(125, 20);
            this.idtxt.TabIndex = 6;
            // 
            // nevtxt
            // 
            this.nevtxt.Location = new System.Drawing.Point(312, 124);
            this.nevtxt.Name = "nevtxt";
            this.nevtxt.Size = new System.Drawing.Size(454, 20);
            this.nevtxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(213, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Profilképnév: (.jpg/.png/.webp/.gif)";
            // 
            // addb
            // 
            this.addb.Location = new System.Drawing.Point(481, 274);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(159, 25);
            this.addb.TabIndex = 10;
            this.addb.Text = "Hozzáadás";
            this.addb.UseVisualStyleBackColor = true;
            this.addb.Click += new System.EventHandler(this.addb_Click);
            // 
            // editb
            // 
            this.editb.Location = new System.Drawing.Point(481, 356);
            this.editb.Name = "editb";
            this.editb.Size = new System.Drawing.Size(159, 25);
            this.editb.TabIndex = 11;
            this.editb.Text = "Modositás";
            this.editb.UseVisualStyleBackColor = true;
            this.editb.Click += new System.EventHandler(this.editb_Click);
            // 
            // deleteb
            // 
            this.deleteb.Location = new System.Drawing.Point(481, 317);
            this.deleteb.Name = "deleteb";
            this.deleteb.Size = new System.Drawing.Size(159, 24);
            this.deleteb.TabIndex = 12;
            this.deleteb.Text = "Törlés";
            this.deleteb.UseVisualStyleBackColor = true;
            this.deleteb.Click += new System.EventHandler(this.deleteb_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(217, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 113);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lista
            // 
            this.lista.Dock = System.Windows.Forms.DockStyle.Left;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(0, 0);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(166, 450);
            this.lista.TabIndex = 2;
            // 
            // _profil_feltolt
            // 
            this._profil_feltolt.Location = new System.Drawing.Point(218, 393);
            this._profil_feltolt.Name = "_profil_feltolt";
            this._profil_feltolt.Size = new System.Drawing.Size(84, 23);
            this._profil_feltolt.TabIndex = 14;
            this._profil_feltolt.Text = "Feltolt";
            this._profil_feltolt.UseVisualStyleBackColor = true;
            this._profil_feltolt.Click += new System.EventHandler(this._profil_feltolt_Click);
            // 
            // profiltxt
            // 
            this.profiltxt.Location = new System.Drawing.Point(217, 248);
            this.profiltxt.Name = "profiltxt";
            this.profiltxt.Size = new System.Drawing.Size(224, 20);
            this.profiltxt.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.profiltxt);
            this.Controls.Add(this._profil_feltolt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteb);
            this.Controls.Add(this.editb);
            this.Controls.Add(this.addb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nevtxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker datum;
        public System.Windows.Forms.TextBox idtxt;
        public System.Windows.Forms.TextBox nevtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.Button editb;
        private System.Windows.Forms.Button deleteb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Button _profil_feltolt;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox profiltxt;
    }
}

