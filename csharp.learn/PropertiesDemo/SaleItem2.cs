using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.PropertiesDemo
{
    /// <summary>
    /// In some cases, property get and set accessors just 
    /// assign a value to or retrieve a value from a backing 
    /// field without including any additional logic. By using 
    /// auto-implemented properties, you can simplify your code 
    /// while having the C# compiler transparently provide the
    /// backing field for you.
    /// </summary>
    public class SaleItem2
    {
        public string Name
        { get; set; }

        public decimal Price
        { get; set; }
    }
}
