using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.automapper.IncludeMembers
{
    public class Source
    {
        public string Name { get; set; }
        public InnerSource InnerSource { get; set; }
        public OtherInnerSource OtherInnerSource { get; set; }
    }
}
