using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace week_3_code_along
{
    class dog
    {
        public string breed;
        public int height; 
        public string name; 

        public void bark()
        {
            MessageBox.Show("Bark"); 
        }

        public void SayName()
        {
            MessageBox.Show("My name is " + name); 
        }
    }
}
