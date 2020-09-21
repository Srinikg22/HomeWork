using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeWork
{
    public class MethodCall : Program
    {
        public void Display()
        {
            Program p = new Program();
            p.DisplayOutVariable(out int i);
            i = 50;
        }  
    }
}
