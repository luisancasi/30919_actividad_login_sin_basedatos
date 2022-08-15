using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms; 



namespace MIPrimerProyecto.Conexion
{
    class Conexion
    {
       SqlConnection conec;

        public string  conectado ()
        {
            try
            {
                conec = new SqlConnection("Server=DESKTOP-UEPK13H\\RONETJOHN;DataBase= Practica;Integrated Security=true");
                conec.Open();
                MessageBox.Show("conectado");
            }
            catch(Exception e ) {
               MessageBox.Show(e.Message);
            }
            return "algo"; 
        
        }

    }


}
