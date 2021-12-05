using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_task
{
    class Elman_Nagdeliyev:Football_team
    {
        public override void Player()
        {
            Console.WriteLine("Playeer: Elman Nagdaliyev");
        }
        public override void UniformNumber()
        {
            Console.WriteLine("Uniformnumber: 7");
        }
        public override void Position()
        {
            Console.WriteLine("Position: Forward");
        }
        public override void Goal()
        {
            Console.WriteLine("Goal: 131");
        }
        public override void Assist()
        {
            Console.WriteLine("Assist: 284");
            Console.WriteLine("================");
        }
    }
}
