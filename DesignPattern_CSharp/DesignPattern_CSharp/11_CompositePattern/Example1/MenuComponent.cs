using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompositePattern.Example1
{
    public abstract class MenuComponent : IEnumerable<MenuComponent>
    {
        protected string MenuName;
        protected string MenuDescription;
        /// <summary>
        /// ChildCount小于0时代表当前节点是不会含有子节点的叶节点
        /// </summary>
        public abstract int ChildCount { get; }

        public string Name => MenuName;
        public string Description => MenuDescription;

        public virtual void Add(MenuComponent component)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent component)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public abstract double GetPrice();

        public abstract void Print();

        public abstract IEnumerator<MenuComponent> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
