using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CommandPattern.Example1
{
    public class RemoteControl
    {
        private ICommand[] m_onCommands;
        private ICommand[] m_offCommands;
        private ICommand m_undoCommand;

        public RemoteControl()
        {
            m_onCommands = new ICommand[7];
            m_offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                m_onCommands[i] = noCommand;
                m_offCommands[i] = noCommand;
            }

            m_undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            m_onCommands[slot] = onCommand;
            m_offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            m_onCommands[slot].Execute();
            m_undoCommand = m_onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            m_offCommands[slot].Execute();
            m_undoCommand = m_offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            m_undoCommand.Undo();
        }
    }
}
