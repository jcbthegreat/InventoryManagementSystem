using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Model
{
    public interface IMeasurementRepository
    {
        IEnumerable<MeasurementModel> GetByValue(string MeasurementName, string Code);
    }
}
