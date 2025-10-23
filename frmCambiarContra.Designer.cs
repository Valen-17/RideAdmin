namespace ProyectoHerramientas
{
    partial class frmCambiarContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarContra));
            this.panel_cambiarContra = new System.Windows.Forms.Panel();
            this.btn_cerrarCon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdb_ver = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_recuperar = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_ocultar = new System.Windows.Forms.RadioButton();
            this.panel_cambiarContra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cambiarContra
            // 
            this.panel_cambiarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.panel_cambiarContra.Controls.Add(this.rdb_ocultar);
            this.panel_cambiarContra.Controls.Add(this.btn_cerrarCon);
            this.panel_cambiarContra.Controls.Add(this.label3);
            this.panel_cambiarContra.Controls.Add(this.rdb_ver);
            this.panel_cambiarContra.Controls.Add(this.label2);
            this.panel_cambiarContra.Controls.Add(this.btn_recuperar);
            this.panel_cambiarContra.Controls.Add(this.txt_codigo);
            this.panel_cambiarContra.Controls.Add(this.pictureBox2);
            this.panel_cambiarContra.Controls.Add(this.pictureBox1);
            this.panel_cambiarContra.Controls.Add(this.label1);
            this.panel_cambiarContra.Location = new System.Drawing.Point(221, 60);
            this.panel_cambiarContra.Name = "panel_cambiarContra";
            this.panel_cambiarContra.Size = new System.Drawing.Size(556, 416);
            this.panel_cambiarContra.TabIndex = 1;
            // 
            // btn_cerrarCon
            // 
            this.btn_cerrarCon.BackColor = System.Drawing.Color.Red;
            this.btn_cerrarCon.Location = new System.Drawing.Point(514, 3);
            this.btn_cerrarCon.Name = "btn_cerrarCon";
            this.btn_cerrarCon.Size = new System.Drawing.Size(39, 27);
            this.btn_cerrarCon.TabIndex = 12;
            this.btn_cerrarCon.Text = "X";
            this.btn_cerrarCon.UseVisualStyleBackColor = false;
            this.btn_cerrarCon.Click += new System.EventHandler(this.btn_cerrarCon_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(108, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "Se ha enviado un codigo a su carreo registrado, por favor ingreselo aqui:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdb_ver
            // 
            this.rdb_ver.AutoSize = true;
            this.rdb_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_ver.ForeColor = System.Drawing.Color.White;
            this.rdb_ver.Location = new System.Drawing.Point(410, 291);
            this.rdb_ver.Name = "rdb_ver";
            this.rdb_ver.Size = new System.Drawing.Size(59, 24);
            this.rdb_ver.TabIndex = 18;
            this.rdb_ver.TabStop = true;
            this.rdb_ver.Text = "Ver";
            this.rdb_ver.UseVisualStyleBackColor = true;
            this.rdb_ver.CheckedChanged += new System.EventHandler(this.rdb_ver_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(151, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Reestablecer contraseña";
            // 
            // btn_recuperar
            // 
            this.btn_recuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(71)))));
            this.btn_recuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recuperar.ForeColor = System.Drawing.Color.Black;
            this.btn_recuperar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_recuperar.Location = new System.Drawing.Point(169, 277);
            this.btn_recuperar.Name = "btn_recuperar";
            this.btn_recuperar.Size = new System.Drawing.Size(219, 50);
            this.btn_recuperar.TabIndex = 3;
            this.btn_recuperar.Text = "Recuperar contraseña";
            this.btn_recuperar.UseVisualStyleBackColor = false;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(144, 196);
            this.txt_codigo.Multiline = true;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.PasswordChar = '*';
            this.txt_codigo.Size = new System.Drawing.Size(312, 41);
            this.txt_codigo.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(87, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "RideAdmin";
            // 
            // rdb_ocultar
            // 
            this.rdb_ocultar.AutoSize = true;
            this.rdb_ocultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_ocultar.ForeColor = System.Drawing.Color.White;
            this.rdb_ocultar.Location = new System.Drawing.Point(410, 291);
            this.rdb_ocultar.Name = "rdb_ocultar";
            this.rdb_ocultar.Size = new System.Drawing.Size(92, 24);
            this.rdb_ocultar.TabIndex = 21;
            this.rdb_ocultar.TabStop = true;
            this.rdb_ocultar.Text = "Ocultar";
            this.rdb_ocultar.UseVisualStyleBackColor = true;
            this.rdb_ocultar.Visible = false;
            this.rdb_ocultar.CheckedChanged += new System.EventHandler(this.rdb_ocultar_CheckedChanged);
            // 
            // frmCambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1025, 544);
            this.Controls.Add(this.panel_cambiarContra);
            this.Name = "frmCambiarContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCambiarContra";
            this.panel_cambiarContra.ResumeLayout(false);
            this.panel_cambiarContra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cambiarContra;
        private System.Windows.Forms.RadioButton rdb_ver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_recuperar;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cerrarCon;
        private System.Windows.Forms.RadioButton rdb_ocultar;
    }
}