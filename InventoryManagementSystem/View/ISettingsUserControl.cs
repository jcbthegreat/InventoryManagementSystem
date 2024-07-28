using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface ISettingsUserControl 
    {
        string RoleType { get; set; }
        int ModuleId { get; set; }
        int SubModuleId { get; set; }
        string SubModuleName { get; set; }
        bool IsActive { get; set; }
        event EventHandler ShowCategory;
        event EventHandler ShowSubCategory;
        event EventHandler ShowType;
        event EventHandler ShowVariant;
        event EventHandler ShowBrand;
        event EventHandler ShowMeasure;
        event EventHandler ShowStaff;
        event EventHandler ShowWarehouse;
        event EventHandler ShowCustomer;

        void ShowButtons();

        void SetButtonVisibility(int subModuleId, bool visible);
        void HideButtons();
      
    }
}
