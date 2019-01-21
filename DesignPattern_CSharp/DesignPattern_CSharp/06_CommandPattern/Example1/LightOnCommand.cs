using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CommandPattern.Example1
{
    public class LightOnCommand : ICommand
    {
        private Light m_light;

        public LightOnCommand(Light light)
        {
            this.m_light = light;
        }

        public void Execute()
        {
            m_light.On();
        }

        public void Undo()
        {
            m_light.Off();
        }
    }
}
