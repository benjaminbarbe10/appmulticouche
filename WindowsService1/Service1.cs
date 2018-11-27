using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public DataEntityTier.NorthwindDataSet.CustomersDataTable GetCustomers()
        {
            DataAccessTier.NorthwindDataSetTableAdapters.CustomersTableAdapter
                 CustomersTableAdapter1
                = new DataAccessTier.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            return CustomersTableAdapter1.GetCustomers();

        }
        public DataEntityTier.NorthwindDataSet.OrdersDataTable GetOrders()
        {
            DataAccessTier.NorthwindDataSetTableAdapters.OrdersTableAdapter
                 OrdersTableAdapter1
                = new DataAccessTier.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            return OrdersTableAdapter1.GetOrders();

        }

        public Service1()
        {
            InitializeComponent();

        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
