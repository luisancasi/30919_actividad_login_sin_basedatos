using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIPrimerProyecto.Conexion; 


namespace MIPrimerProyecto
{
    public partial class frmLogin : Form
    {
        private string usuario="admin";
        private string clave="1234";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="")
            {
                MessageBox.Show("Debe ingresar un usuario...");
                txtUsuario.Focus();
                return;
            }
            if (txtClave.Text==String.Empty)
            {
                MessageBox.Show("Debe ingresar una contraseña...");
                txtClave.Focus();
                return;
            }

            if (this.validar(txtUsuario.Text,txtClave.Text))
            {
                //   Conexion xcon = new  Conexion();
                Acceso xcon = new Acceso();
                xcon.conectado();
                MessageBox.Show("Usuario Válido!!!");
            }
            else
            {
                MessageBox.Show("El usuario no exite");
            }
        }

        private bool validar(string u,string c)
        {
            //if (txtUsuario.Text == this.usuario && txtClave.Text == this.clave)
            if (u == this.usuario && c == this.clave)
                return true;
            else
                return false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //   Conexion xcon = new  Conexion();
            Acceso xcon = new Acceso(); 
           // xcon.conectado();
        }
    }
}
