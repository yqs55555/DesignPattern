using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CommandPattern.Example1
{
    public class LightOffCommand : ICommand
    {
        private Light m_light;

        public LightOffCommand(Light light)
        {
            this.m_light = light;
        }

        public void Execute()
        {
            m_light.Off();
        }

        public void Undo()
        {
            m_light.On();
        }
    }
}
