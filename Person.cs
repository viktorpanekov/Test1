using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Football_team
{
    public class Person
    {
        private string name;
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty ,please enter an appropriate name !");                  
                }
                name = value;
            } 
        }
        private int age;
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                if(value <=0 )
                {
                    throw new ArgumentException("Age cannot be null or negative! ");
                }
                age = value;
            }
        }
    }
}
