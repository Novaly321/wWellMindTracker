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
    public partial class frmProgreso : Form
    {

        private string nombreusuario;
        private static List<string> historial = new List<string>();
        private static int puntaje = 0;


        public frmProgreso(string nombre)
        {
            InitializeComponent();
            nombreusuario = nombre;
        }

        private void frmProgreso_Load(object sender, EventArgs e)
        {

            lblTitulo.Text = $"Progreso De {nombreusuario}";
            lstRegistro.Items.Clear();

            if (historial.Count == 0)
            {
                lstRegistro.Items.Add("Aún no has registrado emociones.");
            }
            else
            {
                foreach (var item in historial)
                {
                    lstRegistro.Items.Add(item);
                }
            }

            lblResumen.Text = $"Nivel de bienestar: {puntaje} puntos";

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmRegistrarEmocion registro = new frmRegistrarEmocion(nombreusuario);
            registro.Show();
            this.Hide();
        }


    }
}
