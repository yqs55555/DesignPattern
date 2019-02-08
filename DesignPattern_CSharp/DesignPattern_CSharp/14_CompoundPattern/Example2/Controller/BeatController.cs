using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example2
{
    public class BeatController : IController
    {
        private IBeatModel m_model;
        private DJView m_view;

        public BeatController(IBeatModel model)
        {
            Console.WriteLine("Beat Controller Create");
            this.m_model = model;
            this.m_view = new DJView(this, this.m_model);
            m_model.Initialize();
            m_view.IncreaseBPM();
            m_view.DecreaseBPM();
        }

        public void Start()
        {
            this.m_model.On();
        }

        public void Stop()
        {
            this.m_model.Off();
        }

        public void IncreaseBPM()
        {
            m_model.BPM++;
        }

        public void DecreaseBPM()
        {
            m_model.BPM--;
        }

        public void SetBPM(int bpm)
        {
            m_model.BPM = bpm;
        }
    }
}
