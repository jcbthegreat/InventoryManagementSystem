using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface IBrandView
    {
        string BrandName { get; set; }
        string Description { get; set; }

        string VariantID { get; set; }


        event EventHandler Brands;

        void SetBindingBrandSource(BindingSource brands);
        void Show();
        void Hide();
        void RefreshDataGridView();
    }
}
