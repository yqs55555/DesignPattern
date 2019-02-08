using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example2
{
    public class DJView : IObserver<BeatModel.ObserverType>
    {
        private IBeatModel m_model;
        private IController m_controller;

        public DJView(IController controller, IBeatModel model)
        {
            this.m_controller = controller;
            this.m_model = model;
            this.m_model.RegisterObserver(this.Update, BeatModel.ObserverType.BEAT);
            this.m_model.RegisterObserver(this.Update, BeatModel.ObserverType.BPM);
        }

        public void IncreaseBPM()
        {
            m_controller.IncreaseBPM();
        }

        public void DecreaseBPM()
        {
            m_controller.DecreaseBPM();
        }

        public void Update(IObservable<BeatModel.ObserverType> sender, BeatModel.ObserverType args)
        {
            switch (args)
            {
                case BeatModel.ObserverType.BEAT:
                {
                    Console.WriteLine("Beat Bar Set Value 100");
                    break;
                }
                case BeatModel.ObserverType.BPM:
                {
                    if (m_model.BPM == 0)
                    {
                        Console.WriteLine("offline");
                    }
                    else
                    {
                        Console.WriteLine("Current BPM: " + m_model.BPM);
                    }
                    break;
                }
            }
        }
    }
}
