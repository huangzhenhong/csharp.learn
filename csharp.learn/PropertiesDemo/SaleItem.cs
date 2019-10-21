using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.PropertiesDemo
{
    public class SaleItem
    {
        string _name;
        decimal _cost;
        public SaleItem(string name, decimal cost)
        {
            _name = name;
            _cost = cost;
        }

        /// <summary>
        /// Starting with C# 7.0, both the get and the set accessor 
        /// can be implemented as expression-bodied members.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal Price
        {
            get => _cost;
            set => _cost = value;
        }
    }
}
