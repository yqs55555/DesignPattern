using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FacadePattern.Example1
{
    public class HomeTheaterFacade
    {
        private Amplifier m_amp;
        private Tuner m_tuner;
        private DvdPlayer m_dvd;
        private CdPlayer m_cd;
        private Projector m_projector;
        private TheaterLights m_lights;
        private Screen m_screen;
        private PopcornPopper m_popper;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvd, CdPlayer cd, Projector projector,
            Screen screen, TheaterLights lights, PopcornPopper popper)
        {
            this.m_amp = amp;
            this.m_tuner = tuner;
            this.m_dvd = dvd;
            this.m_cd = cd;
            this.m_projector = projector;
            this.m_lights = lights;
            this.m_screen = screen;
            this.m_popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            m_popper.On();
            m_popper.Pop();
            m_lights.Dim(10);
            m_screen.Down();
            m_projector.On();
            m_projector.WideScreenMode();
            m_amp.On();
            m_amp.SetDvd(m_dvd);
            m_amp.SetSurroundSound();
            m_amp.SetVolume(5);
            m_dvd.On();
            m_dvd.Play(movie);
        }
    }
}
