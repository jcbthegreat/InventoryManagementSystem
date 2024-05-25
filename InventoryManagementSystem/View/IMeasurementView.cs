using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface IMeasurementView
    {
        string MeasurementName { get; set; }
        string Code { get; set; }


        event EventHandler Measure;

        void SetBindingMeasureSource(BindingSource measure);
        void Show();
        void Hide();
        void RefreshDataGridView();
    }
}
