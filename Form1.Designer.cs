namespace Formulario
{
    partial class Formulario
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Nacionalidad = new System.Windows.Forms.TextBox();
            this.Sexo = new System.Windows.Forms.TextBox();
            this.Sangre = new System.Windows.Forms.TextBox();
            this.Lugar = new System.Windows.Forms.TextBox();
            this.Número = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.TextBox();
            this.Ocupación = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecha2 = new System.Windows.Forms.DateTimePicker();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridViewCiudadanos = new System.Windows.Forms.DataGridView();
            this.Marco = new System.Windows.Forms.PictureBox();
            this.Foto = new System.Windows.Forms.Button();
            this.textFoto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiudadanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Marco)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Formulario.Properties.Resources.JCE_logo;
            this.pictureBox2.Location = new System.Drawing.Point(994, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Formulario.Properties.Resources.Escudo_RD;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Republica Dominicana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cédula de identidad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.textFoto);
            this.Datos.Controls.Add(this.Foto);
            this.Datos.Controls.Add(this.Marco);
            this.Datos.Controls.Add(this.dateTimePickerFecha2);
            this.Datos.Controls.Add(this.dateTimePickerFecha);
            this.Datos.Controls.Add(this.Ocupación);
            this.Datos.Controls.Add(this.Estado);
            this.Datos.Controls.Add(this.Número);
            this.Datos.Controls.Add(this.Lugar);
            this.Datos.Controls.Add(this.Sangre);
            this.Datos.Controls.Add(this.Sexo);
            this.Datos.Controls.Add(this.Nacionalidad);
            this.Datos.Controls.Add(this.Apellidos);
            this.Datos.Controls.Add(this.Nombres);
            this.Datos.Controls.Add(this.label13);
            this.Datos.Controls.Add(this.label12);
            this.Datos.Controls.Add(this.label11);
            this.Datos.Controls.Add(this.label10);
            this.Datos.Controls.Add(this.label9);
            this.Datos.Controls.Add(this.label8);
            this.Datos.Controls.Add(this.label7);
            this.Datos.Controls.Add(this.label6);
            this.Datos.Controls.Add(this.label5);
            this.Datos.Controls.Add(this.label4);
            this.Datos.Controls.Add(this.label3);
            this.Datos.Enabled = false;
            this.Datos.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(12, 104);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(644, 332);
            this.Datos.TabIndex = 4;
            this.Datos.TabStop = false;
            this.Datos.Text = "Ficha de datos";
            this.Datos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellidos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nacionalidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Número de cédula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Lugar de nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Fecha de nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Sangre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Estado Civil";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ocupación";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(447, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 18);
            this.label13.TabIndex = 10;
            this.label13.Text = "Fecha de expiración";
            // 
            // Nombres
            // 
            this.Nombres.Location = new System.Drawing.Point(16, 52);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(97, 25);
            this.Nombres.TabIndex = 11;
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(16, 101);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(97, 25);
            this.Apellidos.TabIndex = 12;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.Location = new System.Drawing.Point(16, 302);
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.Size = new System.Drawing.Size(97, 25);
            this.Nacionalidad.TabIndex = 13;
            // 
            // Sexo
            // 
            this.Sexo.Location = new System.Drawing.Point(192, 269);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(44, 25);
            this.Sexo.TabIndex = 14;
            // 
            // Sangre
            // 
            this.Sangre.Location = new System.Drawing.Point(267, 269);
            this.Sangre.Name = "Sangre";
            this.Sangre.Size = new System.Drawing.Size(46, 25);
            this.Sangre.TabIndex = 15;
            // 
            // Lugar
            // 
            this.Lugar.Location = new System.Drawing.Point(192, 128);
            this.Lugar.Name = "Lugar";
            this.Lugar.Size = new System.Drawing.Size(137, 25);
            this.Lugar.TabIndex = 16;
            // 
            // Número
            // 
            this.Número.Location = new System.Drawing.Point(259, 42);
            this.Número.Name = "Número";
            this.Número.Size = new System.Drawing.Size(176, 25);
            this.Número.TabIndex = 17;
            this.Número.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(450, 128);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(122, 25);
            this.Estado.TabIndex = 18;
            // 
            // Ocupación
            // 
            this.Ocupación.Location = new System.Drawing.Point(450, 197);
            this.Ocupación.Name = "Ocupación";
            this.Ocupación.Size = new System.Drawing.Size(122, 25);
            this.Ocupación.TabIndex = 19;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(192, 197);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(137, 25);
            this.dateTimePickerFecha.TabIndex = 20;
            // 
            // dateTimePickerFecha2
            // 
            this.dateTimePickerFecha2.Location = new System.Drawing.Point(450, 267);
            this.dateTimePickerFecha2.Name = "dateTimePickerFecha2";
            this.dateTimePickerFecha2.Size = new System.Drawing.Size(122, 25);
            this.dateTimePickerFecha2.TabIndex = 21;
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.Yellow;
            this.buttonCrear.Location = new System.Drawing.Point(159, 442);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(110, 25);
            this.buttonCrear.TabIndex = 22;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Lime;
            this.buttonGuardar.Enabled = false;
            this.buttonGuardar.Location = new System.Drawing.Point(301, 442);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(110, 25);
            this.buttonGuardar.TabIndex = 23;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Red;
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancelar.Location = new System.Drawing.Point(449, 442);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(110, 25);
            this.buttonCancelar.TabIndex = 24;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dataGridViewCiudadanos
            // 
            this.dataGridViewCiudadanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCiudadanos.Location = new System.Drawing.Point(677, 104);
            this.dataGridViewCiudadanos.Name = "dataGridViewCiudadanos";
            this.dataGridViewCiudadanos.Size = new System.Drawing.Size(403, 360);
            this.dataGridViewCiudadanos.TabIndex = 5;
            // 
            // Marco
            // 
            this.Marco.BackColor = System.Drawing.Color.Tan;
            this.Marco.Location = new System.Drawing.Point(16, 132);
            this.Marco.Name = "Marco";
            this.Marco.Size = new System.Drawing.Size(94, 92);
            this.Marco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Marco.TabIndex = 22;
            this.Marco.TabStop = false;
            // 
            // Foto
            // 
            this.Foto.BackColor = System.Drawing.Color.Cyan;
            this.Foto.Enabled = false;
            this.Foto.Location = new System.Drawing.Point(19, 230);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(90, 33);
            this.Foto.TabIndex = 23;
            this.Foto.Text = "Subir foto";
            this.Foto.UseVisualStyleBackColor = false;
            this.Foto.Click += new System.EventHandler(this.Foto_Click);
            // 
            // textFoto
            // 
            this.textFoto.Location = new System.Drawing.Point(6, 166);
            this.textFoto.Name = "textFoto";
            this.textFoto.Size = new System.Drawing.Size(8, 25);
            this.textFoto.TabIndex = 24;
            this.textFoto.Visible = false;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1092, 476);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridViewCiudadanos);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiudadanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Marco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.TextBox Ocupación;
        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.TextBox Número;
        private System.Windows.Forms.TextBox Lugar;
        private System.Windows.Forms.TextBox Sangre;
        private System.Windows.Forms.TextBox Sexo;
        private System.Windows.Forms.TextBox Nacionalidad;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Nombres;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.DataGridView dataGridViewCiudadanos;
        private System.Windows.Forms.Button Foto;
        private System.Windows.Forms.PictureBox Marco;
        private System.Windows.Forms.TextBox textFoto;
    }
}

