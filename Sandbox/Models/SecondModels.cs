using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;

namespace Sandbox.Models
{
    public class SecondModel
    {
        public int[,] BoardValues { get; set; }

        public SecondModel()
        {
            BoardValues = new int[3,3];
        }
    }
}