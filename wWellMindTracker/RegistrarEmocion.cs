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
        private List<string> emociones = new List<string>();
        private string nombreusuario;
        private int puntaje = 0;

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

                MessageBox.Show("Por favor selecciona una emoción antes de registrar.","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            string tipo = cmbEmociones.SelectedItem.ToString();
            emociones.Add(tipo);

            if (tipo.Contains("Positiva"))
            {
                puntaje += 10;
            }
            else if (tipo.Contains("Neutral"))
            {
                puntaje += 5;
            }
            else
            {
                puntaje += 2;
            }

            MessageBox.Show($"Emoción '{tipo}' registrada correctamente.","Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVerProgerso_Click(object sender, EventArgs e)
        {

            frmProgreso progreso = new frmProgreso(nombreusuario, emociones, puntaje);
            progreso.ShowDialog();
            this.Hide();

        }


    }
}
