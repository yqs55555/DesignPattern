using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.StrategyPattern
{
    /// <summary>
    /// Character应该是不能被示例化的抽象类
    /// </summary>
    public abstract class Character
    {
        private IWeaponBehavior m_weapon;

        public virtual void Fight()
        {
            if (m_weapon != null)
            {
                m_weapon.UseWeapon();
            }
            else
            {
                Console.WriteLine("No Weapon Attack");
            }
        }

        public virtual void SetWeapon(IWeaponBehavior weapon)
        {
            this.m_weapon = weapon;
        }
    }
}
