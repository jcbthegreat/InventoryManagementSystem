using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface ISettingsUserControl 
    {
        event EventHandler ShowCategory;
        event EventHandler ShowSubCategory;
        event EventHandler ShowType;
        event EventHandler ShowVariant;
        event EventHandler ShowBrand;
        event EventHandler ShowMeasure;
        event EventHandler ShowStaff;
    }
}
