﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_StrategyPattern
{
    public class SecondChoice : IChoice
    {
        public void MyChoice()
        {
            Console.WriteLine("Traveling to China");
        }
    }
}
