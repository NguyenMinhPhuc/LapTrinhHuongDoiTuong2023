﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_StrategyPattern
{
    public class Context
    {
        IChoice choice;
        /*It's our choice. We prefer to use a setter method instead of 
       using a constructor. We can call this method whenever we want to 
       change the "choice behavior" on the fly*/
        public void SetChoice(IChoice choice)
        {
            this.choice = choice;
        }
        /* This method will help us to delegate the particular
        object's choice behavior/characteristic*/
        public void ShowChoice()
        {
            choice.MyChoice();
        }
    }
}
