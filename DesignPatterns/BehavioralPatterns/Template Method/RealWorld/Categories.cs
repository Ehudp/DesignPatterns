using System.Data;
using System.Data.OleDb;
using Logger;

namespace DesignPatterns.BehavioralPatterns.Template_Method.RealWorld
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Categories : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
                sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Categories");
        }

        public override void Process()
        {
            Log.WriteLine("Categories ---- ");

            DataTable dataTable = dataSet.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Log.WriteLine(row["CategoryName"].ToString());
            }
            Log.WriteLine("");
        }
    }
}