using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_103022300147
{
    internal class FanLaptop
    {
        private enum State {Quiet, Balanced, Performance, Turbo }
        private State currentState;

        public FanLaptop()
        {
            currentState = State.Quiet;
            Console.WriteLine("Fan Quiet");
        }

        public void modeBalanced()
        {
            if (currentState == State.Quiet)
            {
                currentState = State.Balanced;
                Console.WriteLine("Fan Quiet berubah menjadi Balanced");
            }
            else
            {
                Console.WriteLine("Sudah Mode Balanced");
            }
            
        }

        public void modePerformance()
        {
            if (currentState == State.Balanced)
            {
                currentState = State.Performance;
                Console.WriteLine("Fan Balanced berubah menjadi Performance");
            }
            else
            {
                Console.WriteLine("Sudah Mode Performance");
            }
        }

        public void modeTurbo()
        {
            if (currentState == State.Performance)
            {
                currentState = State.Turbo;
                Console.WriteLine("Fan Performance berubah menjadi Turbo");
            }
            else if (currentState == State.Quiet)
            {
                currentState = State.Turbo;
                Console.WriteLine("Fan Quiet berubah menjadi Turbo");
            }
            else {
                Console.WriteLine("Sudah Mode Turbo");
            }
        }
    }
}
