using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_task
{
    public class Elnur_Ceferov:Football_team
    {
        public override void Player()
        {
            Console.WriteLine("Player: Elnur Ceferov");
        }
        public override void UniformNumber()
        {
            Console.WriteLine("Uniformnumber: 11");
        }
        public override void Position()
        {
            Console.WriteLine("Position: Attacking mid");
        }
        public override void Goal()
        {
            Console.WriteLine("Goal: 378");
        }
        public override void Assist()
        {
            Console.WriteLine("Assist: 280");
            Console.WriteLine("================");
        }
    }
}
