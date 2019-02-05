using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Proxies;
using System.Text;

namespace DesignPattern_CSharp.ProxyPattern.Example2
{
    public class OwnerInvocationHandler : IInvocationHandler
    {
        private IPerson m_person;
        private List<string> m_errors;
        private object[] m_param;

        public OwnerInvocationHandler(IPerson person)
        {
            this.m_person = person;
            m_errors = new List<string>()
            {
                "Name"
            };
            m_param = new object[1];
        }

        public bool Invoke<T>(PropertyInfo property, out T result)
        {
            result = default(T);
            if (!m_errors.Contains(property.Name))
            {
                result = (T)property.GetGetMethod().Invoke(m_person, null);
                return true;
            }
            return false;
        }

        public bool Invoke<T>(PropertyInfo property, T parameter)
        {
            if (!m_errors.Contains(property.Name))
            {
                m_param[0] = parameter;
                property.GetSetMethod().Invoke(m_person, m_param);
                return true;
            }
            return false;
        }
    }
}
