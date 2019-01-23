using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FacadePattern.Example1
{
    public class Example1Test
    {
        public static void Test()
        {
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(new Amplifier(), new Tuner(), 
                new DvdPlayer(), new CdPlayer(), new Projector(), new Screen(), new TheaterLights(), 
                new PopcornPopper());

            homeTheater.WatchMovie("Raiders of the Lost Ark");
        }
    }
}
