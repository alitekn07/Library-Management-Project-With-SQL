using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWPF
{
    public class SqlConnectionClass
    {
        public static SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=LibraryProject;Integrated Security=True");

        public static string oledbconnection = "Provider=SQLOLEDB;Data Source=.;database=LibraryProject;Integrated Security=SSPI";

        public static OleDbClass Oledbedit(string srQuery)
        {
            DataSet tempdataset = new DataSet();
            OleDbDataAdapter tempadapter = new OleDbDataAdapter();
            OleDbCommandBuilder tempbuilder = new OleDbCommandBuilder();
            OleDbConnection connection = new OleDbConnection(oledbconnection);
            connection.Open();

            tempadapter.SelectCommand = new OleDbCommand(srQuery, connection);
            tempbuilder = new OleDbCommandBuilder(tempadapter);
            tempadapter.Fill(tempdataset);

            return new OleDbClass { dataset = tempdataset, adaptor = tempadapter, builder = tempbuilder };
        }
    }
}
