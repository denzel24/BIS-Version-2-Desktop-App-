using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class dbConnection
    {
        public SqlConnection con = new SqlConnection("Data Source=" + Properties.Settings.Default.ServerName + "; Initial Catalog=" + Properties.Settings.Default.DatabaseName + "; Persist Security Info=True;User ID=" + Properties.Settings.Default.UserName + "; Password=" + Properties.Settings.Default.Password + "");
        public String serverName = Properties.Settings.Default.ServerName;
        public String dbName = Properties.Settings.Default.DatabaseName;
        public String userName = Properties.Settings.Default.UserName;
        public String pass = Properties.Settings.Default.Password;

        public SqlConnection getcon()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }

            return con;

        }

        public SqlConnection crys()
        {
            con.Close();
            return con;
        }
        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;

        }

        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;

        }

        public DataTable ExeReader(SqlCommand cmd)
        {

            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;


        }
    }
}
