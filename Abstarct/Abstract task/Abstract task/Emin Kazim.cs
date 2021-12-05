using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_task
{
    class Emin_Kazim:Football_team
    {
        public override void Player()
        {
            Console.WriteLine("Player: Emin Kazim");
        }
        public override void UniformNumber()
        {
            Console.WriteLine("Uniformnumber: 1");
        }
        public override void Position()
        {
            Console.WriteLine("Position: GoalKeeper");
        }
        public override void Goal()
        {
            Console.WriteLine("Goal: 0");
        }
        public override void Assist()
        {
            Console.WriteLine("Assist: 3");
            Console.WriteLine("================");
        }
    }
}
