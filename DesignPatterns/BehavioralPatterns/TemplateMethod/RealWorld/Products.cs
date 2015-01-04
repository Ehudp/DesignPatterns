using System.Data;
using System.Data.SqlClient;
using Logger;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod.RealWorld
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Products : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select ProductName from Products";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Products");
        }

        public override void Process()
        {
            Log.WriteLine("Products ---- ");
            DataTable dataTable = dataSet.Tables["Products"];
            foreach (DataRow row in dataTable.Rows)
            {
                Log.WriteLine(row["ProductName"].ToString());
            }
            Log.WriteLine("");
        }
    }
}