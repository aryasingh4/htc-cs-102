using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_3_code_along
{
    class goose
    {
        public string name;
        public int age;
        public int AttackDamage;


        public void Honk()
        {
            MessageBox.Show("Honk, my name is " + name + " I am " + age + " honks old "); 
        }

        public void Attack()
        {
            MessageBox.Show("I attack you for " + AttackDamage + " damage");
        }

        public void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            goose goose = new goose();
            goose.name = "GooseName";
            goose.age = 9001;
            goose.AttackDamage = 99999;

            goose.Honk();
            goose.Attack(); 
        }

    }









    
}
