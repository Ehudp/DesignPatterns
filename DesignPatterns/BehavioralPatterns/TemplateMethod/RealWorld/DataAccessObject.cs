using System.Data;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod.RealWorld
{
    internal abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;

        public virtual void Connect()
        {
            // Make sure mdb is available to app
            connectionString = global::DesignPatterns.Properties.Settings1.Default.Database1ConnectionString;
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        // The 'Template Method' 
        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}