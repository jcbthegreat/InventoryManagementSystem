using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public class MeasurementModel
    {
        private int id;
        private string measurementname;
        private string measurementcode;
        private string createdby;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string MeasurementName
        {
            get { return measurementname; }
            set { measurementname = value; }
        }

        public string MeasurementCode
        {
            get { return measurementcode; }
            set { measurementcode = value; }
        }

        public string CreatedBy
        {
            get { return createdby; }
            set { createdby = value; }
        }
    }
}

