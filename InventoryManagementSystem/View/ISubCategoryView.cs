using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface ISubCategoryView
    {
       // string CategoryName { get; set; }
        string SubCategoryName { get; set; }
        string Description { get; set; }
        
        string MainCategoryId { get; set; }


        event EventHandler SubCateg;

        void SetBindingCategorySource(BindingSource subcateg);
        void Show();
        void Hide();
        void RefreshDataGridView();
    }
}
