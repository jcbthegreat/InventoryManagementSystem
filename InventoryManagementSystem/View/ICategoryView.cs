using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface ICategoryView
    {
        //int ID { get; set; }
        string CategoryName { get; set; }
        string Description { get; set; }


        event EventHandler Categ;

        void SetBindingCategorySource(BindingSource categ);
        void Show();
        void Hide();
        void RefreshDataGridView();
    }
}
