namespace winSemaforos
{
    partial class frmMenú
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.lblTítulo = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.cmbPuertosSeriales = new System.Windows.Forms.ComboBox();
			this.btnAbrirPuerto = new System.Windows.Forms.Button();
			this.lblPuertoSerial = new System.Windows.Forms.Label();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.lblSemaforo1 = new System.Windows.Forms.Label();
			this.lblSemaforo2 = new System.Windows.Forms.Label();
			this.lblSemaforo3 = new System.Windows.Forms.Label();
			this.txtSemaforo1 = new System.Windows.Forms.TextBox();
			this.txtSemaforo2 = new System.Windows.Forms.TextBox();
			this.txtSemaforo3 = new System.Windows.Forms.TextBox();
			this.tmrSemaforo3 = new System.Windows.Forms.Timer(this.components);
			this.btnManual = new System.Windows.Forms.Button();
			this.grbManual = new System.Windows.Forms.GroupBox();
			this.btnActivar = new System.Windows.Forms.Button();
			this.btnAuto = new System.Windows.Forms.Button();
			this.tmrSemaforo2 = new System.Windows.Forms.Timer(this.components);
			this.tmrSemaforo1 = new System.Windows.Forms.Timer(this.components);
			this.btnParar = new System.Windows.Forms.Button();
			this.btnContinuar = new System.Windows.Forms.Button();
			this.picCarroTrasero = new System.Windows.Forms.PictureBox();
			this.picCarroIzquierda = new System.Windows.Forms.PictureBox();
			this.picCarroDerecha = new System.Windows.Forms.PictureBox();
			this.picCarretera2 = new System.Windows.Forms.PictureBox();
			this.picSemáforo = new System.Windows.Forms.PictureBox();
			this.tmrCarroDerecha = new System.Windows.Forms.Timer(this.components);
			this.tmrCarroIzquierda = new System.Windows.Forms.Timer(this.components);
			this.tmrRecto = new System.Windows.Forms.Timer(this.components);
			this.tmrAnimacion = new System.Windows.Forms.Timer(this.components);
			this.tmrAnimacionDerecha = new System.Windows.Forms.Timer(this.components);
			this.tmrAnimacionRecta = new System.Windows.Forms.Timer(this.components);
			this.tmrParpadeo = new System.Windows.Forms.Timer(this.components);
			this.tmrParpadeo2 = new System.Windows.Forms.Timer(this.components);
			this.tmrParpadeo3 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.grbManual.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCarroTrasero)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCarroIzquierda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCarroDerecha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCarretera2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picSemáforo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTítulo
			// 
			this.lblTítulo.AutoSize = true;
			this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTítulo.ForeColor = System.Drawing.SystemColors.Info;
			this.lblTítulo.Location = new System.Drawing.Point(623, 20);
			this.lblTítulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTítulo.Name = "lblTítulo";
			this.lblTítulo.Size = new System.Drawing.Size(311, 73);
			this.lblTítulo.TabIndex = 0;
			this.lblTítulo.Text = "Semáforo";
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(940, 105);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(53, 19);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
			// 
			// cmbPuertosSeriales
			// 
			this.cmbPuertosSeriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPuertosSeriales.FormattingEnabled = true;
			this.cmbPuertosSeriales.Location = new System.Drawing.Point(635, 105);
			this.cmbPuertosSeriales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbPuertosSeriales.Name = "cmbPuertosSeriales";
			this.cmbPuertosSeriales.Size = new System.Drawing.Size(296, 41);
			this.cmbPuertosSeriales.TabIndex = 6;
			// 
			// btnAbrirPuerto
			// 
			this.btnAbrirPuerto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAbrirPuerto.Location = new System.Drawing.Point(940, 128);
			this.btnAbrirPuerto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAbrirPuerto.Name = "btnAbrirPuerto";
			this.btnAbrirPuerto.Size = new System.Drawing.Size(53, 20);
			this.btnAbrirPuerto.TabIndex = 7;
			this.btnAbrirPuerto.Text = "Abrir";
			this.btnAbrirPuerto.UseVisualStyleBackColor = false;
			this.btnAbrirPuerto.Click += new System.EventHandler(this.btnAbrirPuerto_Click_1);
			// 
			// lblPuertoSerial
			// 
			this.lblPuertoSerial.AutoSize = true;
			this.lblPuertoSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPuertoSerial.ForeColor = System.Drawing.SystemColors.Info;
			this.lblPuertoSerial.Location = new System.Drawing.Point(656, 146);
			this.lblPuertoSerial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPuertoSerial.Name = "lblPuertoSerial";
			this.lblPuertoSerial.Size = new System.Drawing.Size(254, 24);
			this.lblPuertoSerial.TabIndex = 8;
			this.lblPuertoSerial.Text = "Puerto(#) Serial detectado (#)";
			// 
			// lblSemaforo1
			// 
			this.lblSemaforo1.AutoSize = true;
			this.lblSemaforo1.Location = new System.Drawing.Point(4, 45);
			this.lblSemaforo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSemaforo1.Name = "lblSemaforo1";
			this.lblSemaforo1.Size = new System.Drawing.Size(86, 18);
			this.lblSemaforo1.TabIndex = 9;
			this.lblSemaforo1.Text = "Semaforo 1";
			// 
			// lblSemaforo2
			// 
			this.lblSemaforo2.AutoSize = true;
			this.lblSemaforo2.Location = new System.Drawing.Point(86, 45);
			this.lblSemaforo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSemaforo2.Name = "lblSemaforo2";
			this.lblSemaforo2.Size = new System.Drawing.Size(86, 18);
			this.lblSemaforo2.TabIndex = 10;
			this.lblSemaforo2.Text = "Semaforo 2";
			// 
			// lblSemaforo3
			// 
			this.lblSemaforo3.AutoSize = true;
			this.lblSemaforo3.Location = new System.Drawing.Point(171, 45);
			this.lblSemaforo3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSemaforo3.Name = "lblSemaforo3";
			this.lblSemaforo3.Size = new System.Drawing.Size(86, 18);
			this.lblSemaforo3.TabIndex = 11;
			this.lblSemaforo3.Text = "Semaforo 3";
			// 
			// txtSemaforo1
			// 
			this.txtSemaforo1.Enabled = false;
			this.txtSemaforo1.Location = new System.Drawing.Point(17, 63);
			this.txtSemaforo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtSemaforo1.Name = "txtSemaforo1";
			this.txtSemaforo1.Size = new System.Drawing.Size(60, 24);
			this.txtSemaforo1.TabIndex = 12;
			// 
			// txtSemaforo2
			// 
			this.txtSemaforo2.Enabled = false;
			this.txtSemaforo2.Location = new System.Drawing.Point(99, 63);
			this.txtSemaforo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtSemaforo2.Name = "txtSemaforo2";
			this.txtSemaforo2.Size = new System.Drawing.Size(60, 24);
			this.txtSemaforo2.TabIndex = 13;
			// 
			// txtSemaforo3
			// 
			this.txtSemaforo3.Enabled = false;
			this.txtSemaforo3.Location = new System.Drawing.Point(184, 63);
			this.txtSemaforo3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtSemaforo3.Name = "txtSemaforo3";
			this.txtSemaforo3.Size = new System.Drawing.Size(60, 24);
			this.txtSemaforo3.TabIndex = 14;
			// 
			// tmrSemaforo3
			// 
			this.tmrSemaforo3.Interval = 1000;
			this.tmrSemaforo3.Tick += new System.EventHandler(this.tmrSemaforo3_Tick);
			// 
			// btnManual
			// 
			this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManual.Location = new System.Drawing.Point(710, 351);
			this.btnManual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnManual.Name = "btnManual";
			this.btnManual.Size = new System.Drawing.Size(100, 26);
			this.btnManual.TabIndex = 15;
			this.btnManual.Text = "Manual";
			this.btnManual.UseVisualStyleBackColor = true;
			this.btnManual.Visible = false;
			this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
			// 
			// grbManual
			// 
			this.grbManual.Controls.Add(this.btnActivar);
			this.grbManual.Controls.Add(this.lblSemaforo2);
			this.grbManual.Controls.Add(this.lblSemaforo1);
			this.grbManual.Controls.Add(this.lblSemaforo3);
			this.grbManual.Controls.Add(this.txtSemaforo3);
			this.grbManual.Controls.Add(this.txtSemaforo1);
			this.grbManual.Controls.Add(this.txtSemaforo2);
			this.grbManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbManual.ForeColor = System.Drawing.SystemColors.Info;
			this.grbManual.Location = new System.Drawing.Point(668, 209);
			this.grbManual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.grbManual.Name = "grbManual";
			this.grbManual.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.grbManual.Size = new System.Drawing.Size(262, 102);
			this.grbManual.TabIndex = 17;
			this.grbManual.TabStop = false;
			this.grbManual.Text = "Semáforos";
			this.grbManual.Visible = false;
			// 
			// btnActivar
			// 
			this.btnActivar.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnActivar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnActivar.Location = new System.Drawing.Point(184, 14);
			this.btnActivar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnActivar.Name = "btnActivar";
			this.btnActivar.Size = new System.Drawing.Size(74, 23);
			this.btnActivar.TabIndex = 15;
			this.btnActivar.Text = "activar";
			this.btnActivar.UseVisualStyleBackColor = false;
			this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
			// 
			// btnAuto
			// 
			this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAuto.Location = new System.Drawing.Point(589, 351);
			this.btnAuto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAuto.Name = "btnAuto";
			this.btnAuto.Size = new System.Drawing.Size(104, 26);
			this.btnAuto.TabIndex = 18;
			this.btnAuto.Text = "Automatico";
			this.btnAuto.UseVisualStyleBackColor = true;
			this.btnAuto.Visible = false;
			this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
			// 
			// tmrSemaforo2
			// 
			this.tmrSemaforo2.Interval = 1000;
			this.tmrSemaforo2.Tick += new System.EventHandler(this.tmrSemaforo2_Tick);
			// 
			// tmrSemaforo1
			// 
			this.tmrSemaforo1.Interval = 1000;
			this.tmrSemaforo1.Tick += new System.EventHandler(this.tmrSemaforo1_Tick);
			// 
			// btnParar
			// 
			this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnParar.Location = new System.Drawing.Point(824, 351);
			this.btnParar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnParar.Name = "btnParar";
			this.btnParar.Size = new System.Drawing.Size(100, 26);
			this.btnParar.TabIndex = 19;
			this.btnParar.Text = "Parar";
			this.btnParar.UseVisualStyleBackColor = true;
			this.btnParar.Visible = false;
			this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
			// 
			// btnContinuar
			// 
			this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContinuar.Location = new System.Drawing.Point(940, 351);
			this.btnContinuar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnContinuar.Name = "btnContinuar";
			this.btnContinuar.Size = new System.Drawing.Size(100, 26);
			this.btnContinuar.TabIndex = 20;
			this.btnContinuar.Text = "Continuar";
			this.btnContinuar.UseVisualStyleBackColor = true;
			this.btnContinuar.Visible = false;
			this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
			// 
			// picCarroTrasero
			// 
			this.picCarroTrasero.Image = global::winSemaforos.Properties.Resources.Trasero_;
			this.picCarroTrasero.Location = new System.Drawing.Point(230, 331);
			this.picCarroTrasero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picCarroTrasero.Name = "picCarroTrasero";
			this.picCarroTrasero.Size = new System.Drawing.Size(44, 46);
			this.picCarroTrasero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCarroTrasero.TabIndex = 26;
			this.picCarroTrasero.TabStop = false;
			this.picCarroTrasero.Visible = false;
			// 
			// picCarroIzquierda
			// 
			this.picCarroIzquierda.Image = global::winSemaforos.Properties.Resources.Izquierda1;
			this.picCarroIzquierda.Location = new System.Drawing.Point(56, 170);
			this.picCarroIzquierda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picCarroIzquierda.Name = "picCarroIzquierda";
			this.picCarroIzquierda.Size = new System.Drawing.Size(72, 41);
			this.picCarroIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCarroIzquierda.TabIndex = 25;
			this.picCarroIzquierda.TabStop = false;
			this.picCarroIzquierda.Visible = false;
			// 
			// picCarroDerecha
			// 
			this.picCarroDerecha.Image = global::winSemaforos.Properties.Resources.Derecha1;
			this.picCarroDerecha.Location = new System.Drawing.Point(374, 170);
			this.picCarroDerecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picCarroDerecha.Name = "picCarroDerecha";
			this.picCarroDerecha.Size = new System.Drawing.Size(72, 41);
			this.picCarroDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCarroDerecha.TabIndex = 24;
			this.picCarroDerecha.TabStop = false;
			this.picCarroDerecha.Visible = false;
			// 
			// picCarretera2
			// 
			this.picCarretera2.Image = global::winSemaforos.Properties.Resources.Crucero;
			this.picCarretera2.Location = new System.Drawing.Point(56, 13);
			this.picCarretera2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picCarretera2.Name = "picCarretera2";
			this.picCarretera2.Size = new System.Drawing.Size(391, 364);
			this.picCarretera2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCarretera2.TabIndex = 22;
			this.picCarretera2.TabStop = false;
			this.picCarretera2.Visible = false;
			// 
			// picSemáforo
			// 
			this.picSemáforo.Image = global::winSemaforos.Properties.Resources.semaforo3;
			this.picSemáforo.Location = new System.Drawing.Point(940, 11);
			this.picSemáforo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picSemáforo.Name = "picSemáforo";
			this.picSemáforo.Size = new System.Drawing.Size(103, 90);
			this.picSemáforo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picSemáforo.TabIndex = 5;
			this.picSemáforo.TabStop = false;
			// 
			// tmrCarroDerecha
			// 
			this.tmrCarroDerecha.Tick += new System.EventHandler(this.tmrCarroDerecha_Tick);
			// 
			// tmrCarroIzquierda
			// 
			this.tmrCarroIzquierda.Tick += new System.EventHandler(this.tmrCarroIzquierda_Tick);
			// 
			// tmrRecto
			// 
			this.tmrRecto.Tick += new System.EventHandler(this.tmrRecto_Tick);
			// 
			// tmrAnimacion
			// 
			this.tmrAnimacion.Tick += new System.EventHandler(this.tmrAnimacion_Tick);
			// 
			// tmrAnimacionDerecha
			// 
			this.tmrAnimacionDerecha.Tick += new System.EventHandler(this.tmrAnimacionDerecha_Tick);
			// 
			// tmrAnimacionRecta
			// 
			this.tmrAnimacionRecta.Tick += new System.EventHandler(this.tmrAnimacionRecta_Tick);
			// 
			// tmrParpadeo
			// 
			this.tmrParpadeo.Interval = 800;
			this.tmrParpadeo.Tick += new System.EventHandler(this.tmrParpadeo_Tick);
			// 
			// tmrParpadeo2
			// 
			this.tmrParpadeo2.Interval = 800;
			this.tmrParpadeo2.Tick += new System.EventHandler(this.tmrParpadeo2_Tick);
			// 
			// tmrParpadeo3
			// 
			this.tmrParpadeo3.Interval = 800;
			this.tmrParpadeo3.Tick += new System.EventHandler(this.tmrParpadeo3_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 146);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "Semaforo 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(228, 260);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 28;
			this.label2.Text = "Semaforo 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(296, 194);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 29;
			this.label3.Text = "Semaforo 3";
			// 
			// frmMenú
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(1048, 416);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picCarroTrasero);
			this.Controls.Add(this.picCarroIzquierda);
			this.Controls.Add(this.picCarroDerecha);
			this.Controls.Add(this.btnContinuar);
			this.Controls.Add(this.btnParar);
			this.Controls.Add(this.btnAuto);
			this.Controls.Add(this.grbManual);
			this.Controls.Add(this.btnManual);
			this.Controls.Add(this.lblPuertoSerial);
			this.Controls.Add(this.btnAbrirPuerto);
			this.Controls.Add(this.cmbPuertosSeriales);
			this.Controls.Add(this.picSemáforo);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.lblTítulo);
			this.Controls.Add(this.picCarretera2);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmMenú";
			this.Text = "Semaforo 3";
			this.Load += new System.EventHandler(this.frmMenú_Load);
			this.grbManual.ResumeLayout(false);
			this.grbManual.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCarroTrasero)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCarroIzquierda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCarroDerecha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCarretera2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picSemáforo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picSemáforo;
        private System.Windows.Forms.ComboBox cmbPuertosSeriales;
        private System.Windows.Forms.Button btnAbrirPuerto;
        private System.Windows.Forms.Label lblPuertoSerial;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblSemaforo1;
        private System.Windows.Forms.Label lblSemaforo2;
        private System.Windows.Forms.Label lblSemaforo3;
        private System.Windows.Forms.TextBox txtSemaforo1;
        private System.Windows.Forms.TextBox txtSemaforo2;
        private System.Windows.Forms.TextBox txtSemaforo3;
        private System.Windows.Forms.Timer tmrSemaforo3;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.GroupBox grbManual;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Timer tmrSemaforo2;
        private System.Windows.Forms.Timer tmrSemaforo1;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.PictureBox picCarretera2;
        private System.Windows.Forms.PictureBox picCarroDerecha;
        private System.Windows.Forms.PictureBox picCarroIzquierda;
        private System.Windows.Forms.PictureBox picCarroTrasero;
        private System.Windows.Forms.Timer tmrCarroDerecha;
        private System.Windows.Forms.Timer tmrCarroIzquierda;
        private System.Windows.Forms.Timer tmrRecto;
        private System.Windows.Forms.Timer tmrAnimacion;
        private System.Windows.Forms.Timer tmrAnimacionDerecha;
        private System.Windows.Forms.Timer tmrAnimacionRecta;
        private System.Windows.Forms.Timer tmrParpadeo;
        private System.Windows.Forms.Timer tmrParpadeo2;
        private System.Windows.Forms.Timer tmrParpadeo3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

