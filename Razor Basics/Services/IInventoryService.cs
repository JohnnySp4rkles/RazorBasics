﻿using RazorBasics.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBasics.Services {
    public interface IInventoryService {
        List<InventoryItem> GetInventoryItems(int threshold);
    }
}
