using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Formulario de contacto que tome un nickname, mail y mensaje. Al agregar debe anexarse a 
 * los demás dados de alta (nickname, mail, 
 * mensaje y fecha de envio de mensaje) visualizados en una Label.*/

/*Vargas Maria Brisa*/

namespace TrabajoPractico1Vargas
{
    
    public partial class EnvioDeCorreos : Form
    {
        public EnvioDeCorreos()
        {
            InitializeComponent();
        }
        public string listado = "";
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime fechaEnvio = DateTime.Today;
                listado = listado + "Nickname: "+nick.Text + " - Mail: " + mail.Text + " - Mensaje: " + mensaje.Text + " (Fecha de envío: " + fechaEnvio.ToString("d") + ")\n------------\n";
                resultado.Text = listado;
                nick.Text = "";
                mail.Text = "";
                mensaje.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese valores");
            }
        }
    }
}
