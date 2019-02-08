using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example2
{
    public interface IBeatModel : IObservable<BeatModel.ObserverType>
    {
        void Initialize();
        void On();
        void Off();
        int BPM { get; set; }
    }
}
