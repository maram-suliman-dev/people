using System;
using System.Xml.Linq;
namespace project_2__maram
{
    public class people
    {
        private int id;
        private string name;
        private int age;
        private string password;


        public people( string name, int age, string password)
        {

            
            this.name = name;
            this.age = age;
            this.password = password;

        }

        public String Getname()
        {
            return this.name;
        }

        public int Getage()
        {
            return this.age;
        }

        public String Getpassword()
        {
            return this.password;
        }


        public void Setname()
        {
            this.name = name;
        }

        public void Setage()
        {
            this.age = age;
        }

        public void Setpassword()
        {
            this.password = password;
        }
    }

}



   