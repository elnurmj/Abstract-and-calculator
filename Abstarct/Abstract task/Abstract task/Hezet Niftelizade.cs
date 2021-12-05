using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_task
{
    class Hezet_Niftelizade:Football_team
    {
        public override void Player()
        {
            Console.WriteLine("Player: Hezret Niftelizade");
        }
        public override void UniformNumber()
        {
            Console.WriteLine("Uniformnumber: 6");
        }
        public override void Position()
        {
            Console.WriteLine("Position: Defensive mid");
        }
        public override void Goal()
        {
            Console.WriteLine("Goal: 53");
        }
        public override void Assist()
        {
            Console.WriteLine("Assist : 168");
            Console.WriteLine("================");
        }
    }
}
