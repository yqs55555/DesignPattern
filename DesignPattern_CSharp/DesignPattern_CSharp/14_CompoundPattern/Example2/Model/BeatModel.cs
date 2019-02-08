using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example2
{
    public class BeatModel : IBeatModel
    {
        public enum ObserverType
        {
            BEAT = 0,
            BPM,
        }
        private int m_bpm = 90;
        public int BPM
        {
            get => m_bpm;
            set
            {
                m_bpm = value;
                NotifyObservers(ObserverType.BPM);
            }
        }

        private Action<IObservable<ObserverType>, ObserverType> m_beatNotifyEventHandler;   //observer 0
        private Action<IObservable<ObserverType>, ObserverType> m_bpmNotifyEventHandler;    //observer 1

        public void Initialize()
        {
            Console.WriteLine("Beat Model Initialize");
            SetupMidi();
            BuildTrackAndStart();
        }

        public void On()
        {
            Console.WriteLine("Beat On");
            this.BPM = 90;
        }

        public void Off()
        {
            this.BPM = 0;
            Console.WriteLine("Beat off");
        }

        private void SetupMidi()
        {
            Console.WriteLine("SetupMidi");
        }

        private void BuildTrackAndStart()
        {
            Console.WriteLine("BuildTrackAndStart");
        }

        public void RegisterObserver(Action<IObservable<ObserverType>, ObserverType> notifyEventHandler, ObserverType args)
        {
            switch (args)
            {
                case ObserverType.BEAT:
                {
                    m_beatNotifyEventHandler += notifyEventHandler;
                    break;
                }
                case ObserverType.BPM:
                {
                    m_bpmNotifyEventHandler += notifyEventHandler;
                    break;
                }
            }
        }

        public void RemoveObserver(Action<IObservable<ObserverType>, ObserverType> notifyEventHandler, ObserverType args)
        {
            switch (args)
            {
                case ObserverType.BEAT:
                {
                    m_beatNotifyEventHandler -= notifyEventHandler;
                    break;
                }
                case ObserverType.BPM:
                {
                    m_bpmNotifyEventHandler -= notifyEventHandler;
                    break;
                }
            }
        }

        public void NotifyObservers(ObserverType args)
        {
            switch (args)
            {
                case ObserverType.BEAT:
                {
                    m_beatNotifyEventHandler?.Invoke(this, args);
                    break;
                }
                case ObserverType.BPM:
                {
                    m_bpmNotifyEventHandler?.Invoke(this, args);
                    break;
                }
            }
        }
    }
}
