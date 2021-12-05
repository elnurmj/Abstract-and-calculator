using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_task
{
    class Cavid_Bashirov:Football_team
    {
        public override void Player()
        {
            Console.WriteLine("Player: Cavid Bashirov");
        }
        public override void UniformNumber()
        {
            Console.WriteLine("Uniformnumber: 10");
        }
        public override void Position()
        {
            Console.WriteLine("Position: Striker");
        }
        public override void Goal()
        {
            Console.WriteLine("Goal: 2793");
        }
        public override void Assist()
        {
            Console.WriteLine("Assist: 3958");
            Console.WriteLine("================");
        }
    }
}
