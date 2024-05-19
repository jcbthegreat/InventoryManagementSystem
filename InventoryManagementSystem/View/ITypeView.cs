using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface ITypeView
    {
        string TypeName { get; set; }
        string Description { get; set; }

        string SubCategoryID { get; set; }


        event EventHandler Types;

        void SetBindingTypeSource(BindingSource type);
        void Show();
        void Hide();
        void RefreshDataGridView();
    }
}
