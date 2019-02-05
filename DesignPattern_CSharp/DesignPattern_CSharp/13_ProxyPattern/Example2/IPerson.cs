using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.ProxyPattern.Example2
{
    public interface IPerson
    {
        string Name { get; set; }
        string Gender { get; set; }
        string Interests { get; set; }
        int HotOrNotRating { get; set; }
    }
}
