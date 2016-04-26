using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sandbox.Models
{
    public class FirstModel
    {
        public int CurrentValue { get; set; }
        public int ChosenNumber { get; set; }

        public bool IsWinner()
        {
            CurrentValue += ChosenNumber;
            if (CurrentValue >= 21)
                return true;
            return false;
        }

        public void Initiate()
        {
            //Random for who starts, assign starting value
            CurrentValue = 0;
        }
    }
}