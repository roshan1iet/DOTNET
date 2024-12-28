
using System.Data;

namespace _33ConnectedWithDataset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";


            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataColumn col1 = new DataColumn("Id", typeof(int));
            DataColumn col2 = new DataColumn("Name", typeof(string));
            DataColumn col3 = new DataColumn("Address", typeof(string));
            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.PrimaryKey = new DataColumn[] { col1 };




             
            //SqlConnection con = new SqlConnection(conStr);
           // SqlCommand cmd = new SqlCommand("select * from Emp", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["Id"] = Convert.ToInt32(reader["Id"]);
                row["Name"] = reader["Name"].ToString();
                row["Address"] = reader["Address"].ToString();
                dt.Rows.Add(row);
            
            }

            con.Close();
            ds.Tables.Add(dt);
            ds.WriteXml(C: \Users\IET\Desktop\practice_Assignment\.Net\33ConnectedWithDataset\Data\EmpData.xml");          
        
                
        }
    }
}