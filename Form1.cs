using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Formulario : Form
    {
        List<Ciudadano> Ciudadanos = new List<Ciudadano>();
        public Formulario()
        {
            InitializeComponent();
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //ignorar los labels y textbox.
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            buttonCancelar.Enabled = false;
            buttonGuardar.Enabled = true;
            buttonCancelar.Enabled = true;
            Datos.Enabled = true;
            Foto.Enabled = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            var ciudadano = new Ciudadano
            {
                Cedula = Guid.NewGuid(),
                Nombres = Nombres.Text,
                Apellidos = Apellidos.Text,
                Sexo = Sexo.Text,
                Sangre = Sangre.Text,  
                Nacionalidad = Nacionalidad.Text,
                LugarDeNacimiento = Lugar.Text,
                FechaDeNacimiento = dateTimePickerFecha.Value,
                FechaDeExpiracion = dateTimePickerFecha2.Value,
                EstadoCivil = Estado.Text,
                Ocupacion = Ocupación.Text,
                Foto = Foto.Text,
            };

            Ciudadanos.Add(ciudadano);

            MessageBox.Show("Ciudadano enlistado");

            Limpiarpaneles();

            buttonCancelar.Enabled = true;
            buttonGuardar.Enabled = false;
            buttonCancelar.Enabled = false;
            Datos.Enabled = false;

            GetCiudadanos();
        }

        private void GetCiudadanos()
        {
            dataGridViewCiudadanos.DataSource = null;
            dataGridViewCiudadanos.DataSource = Ciudadanos;
        }

        private void Limpiarpaneles()
        {
            foreach (Control a in Datos.Controls)
            {
                if (a is TextBox)
                {
                    a.Text = string.Empty;
                }
            }
            Foto.Text = string.Empty;
            Marco.Image = null;

            //Nombres.Text = string.Empty;
            //Apellidos.Text = string.Empty;
            //Sexo.Text = string.Empty;
            //Sangre.Text = string.Empty;
            //Nacionalidad.Text = string.Empty;
            //Lugar.Text = string.Empty;
            //Estado.Text = string.Empty;
            //Ocupación.Text = string.Empty;
            //dateTimePickerFecha.Value = intEmpty; averiguar como es con los valores
            //dateTimePickerFecha2.Value = intEmpty;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpiarpaneles();
        }

        public class Ciudadano
        {
            public Guid Cedula { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Nacionalidad { get; set; }
            public string LugarDeNacimiento { get; set; }
            public string Sexo { get; set; }
            public string Sangre { get; set; }
            public string EstadoCivil{ get; set; }
            public string Ocupacion { get; set; }
            public string Imagen { get; set; }
            public string Foto { get; set; }
            public DateTime FechaDeNacimiento { get; set; }
            public DateTime FechaDeExpiracion { get; set; }
        }

        private void Foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Marco.Image = new Bitmap(openFileDialog.FileName);

                Foto.Text = openFileDialog.FileName;
            }
        }
    }
}
