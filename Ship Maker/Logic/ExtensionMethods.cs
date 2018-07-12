﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Ship_Maker.Logic {
    public static class ExtensionMethods {
        
        public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> items)
        {
            items.ToList().ForEach(collection.Add);
        }  
    }
}