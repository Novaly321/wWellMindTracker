using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wWellMindTracker
{
    public partial class frmRegistrarEmocion : Form
    {

        private string nombreusuario;

        public frmRegistrarEmocion(string nombre)
        {
            InitializeComponent();
            nombreusuario = nombre;
        }

        private void frmRegistrarEmocion_Load(object sender, EventArgs e)
        {

            lblBienvedida.Text = $"Hola {nombreusuario}, Como Te Sientes hoy?";
            cmbEmociones.Items.AddRange(new string[] {"Positiva", "Negativa", "Neutra"});
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (cmbEmociones.SelectedIndex == -1)
            {

                MessageBox.Show("Selecciona una emoción antes de continuar.");
                return;

            }

            string tipo = cmbEmociones.SelectedItem.ToString();
            Emocion emocion = EmocionFactory.CrearEmocion(tipo);


            lblResultado.Text = emocion.Mensaje();
            MessageBox.Show(emocion.Mensaje(), "Registro exitoso");


        }

        private void btnVerProgerso_Click(object sender, EventArgs e)
        {

            frmProgreso progreso = new frmProgreso(nombreusuario);
            progreso.Show();
            this.Hide();


        }






    }
}
