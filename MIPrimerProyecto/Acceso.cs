using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms; 



namespace MIPrimerProyecto.Conexion
{
    class Acceso 
    {
       SqlConnection conec;

        public string  conectado ()
        {
            try
            {
               // string  = "Data Source=NB-LANCASI\\SQLEXPRES.;Initial Catalog=db_pecopom;User ID=sa;Password=PasswordO1.;MultipleActiveResultSets=True;Connect Timeout=100;Encrypt=False;Application Name=MyApp;Current Language=spanish"; 
                conec = new SqlConnection("Server=NB-LANCASI\\SQLEXPRESS;DataBase=db_pecopom;Integrated Security=false; User Id=peco;Password=pecopom");
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
