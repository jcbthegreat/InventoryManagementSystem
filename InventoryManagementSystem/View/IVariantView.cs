using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface IVariantView
    {
        string VariantName { get; set; }
        string Description { get; set; }

        string TypeID { get; set; }


        event EventHandler Variant;

        void SetBindingVariantSource(BindingSource variant);
        void Show();
        void Hide();
        void RefreshDataGridView();
    }
}
