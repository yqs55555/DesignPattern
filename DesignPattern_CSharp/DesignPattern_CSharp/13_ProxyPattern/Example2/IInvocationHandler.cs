using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DesignPattern_CSharp.ProxyPattern.Example2
{
    public interface IInvocationHandler
    {
        bool Invoke<T>(PropertyInfo property, out T result);
        bool Invoke<T>(PropertyInfo property, T parameters);
    }
}
