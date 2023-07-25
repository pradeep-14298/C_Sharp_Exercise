using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immidart
{
    public class DemoEncap
    {

        // private variables declared
        // these can only be accessed by
        // public methods of class
        private String studentName;
        private int studentAge;

        // using accessors to get and
        // set the value of studentName
        public String Name
        {
            set
            {
                studentName = value;
            }

            get
            {
                return studentName;
            }
        }

        // using accessors to get and
        // set the value of studentAge
        public int Age
        {
            set
            {
                studentAge = value;
            }

            get
            {
                return studentAge;
            }
        }
    }

    // Driver Class
    class TESTEncap
    {

        // Main Method
        static public void Main()
        {

            // creating object
            DemoEncap obj = new DemoEncap();

            // calls set accessor of the property Name,
            // and pass "Ankita" as value of the
            // standard field 'value'
            obj.Name = "Pradeep";
          
           

            // calls set accessor of the property Age,
            // and pass "21" as value of the
            // standard field 'value'
            obj.Age = 25;

            // Displaying values of the variables
            Console.WriteLine(" Name : " + obj.Name);
            Console.WriteLine(" Age : " + obj.Age);
        }
    }
}
/*
Name : Pradeep
 Age : 25
 */