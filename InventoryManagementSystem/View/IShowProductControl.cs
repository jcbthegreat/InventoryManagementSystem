﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.View
{
    public interface IShowProductControl
    {
        event EventHandler ShowItem;
        event EventHandler ShowProduct;
        event EventHandler ShowUpdateProduct;

        void RefreshDataGridView();
    }

    
}
