using Logger;

namespace DesignPatterns.StructuralPatterns.Bridge.RealWorld
{
    internal class CustomersBase
    {
        protected string group;

        public CustomersBase(string group)
        {
            this.group = group;
        }

        // Property
        public DataObject Data { set; get; }

        public virtual void Next()
        {
            Data.NextRecord();
        }

        public virtual void Prior()
        {
            Data.PriorRecord();
        }

        public virtual void Add(string customer)
        {
            Data.AddRecord(customer);
        }

        public virtual void Delete(string customer)
        {
            Data.DeleteRecord(customer);
        }

        public virtual void Show()
        {
            Data.ShowRecord();
        }

        public virtual void ShowAll()
        {
            Log.WriteLine("Customer Group: " + group);
            Data.ShowAllRecords();
        }
    }
}