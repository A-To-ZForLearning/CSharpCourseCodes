using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBaseClass
{

    public class Object
    {
       // Virtual members.
        //public virtual bool Equals(object obj);
        //protected virtual void Finalize();
        //public virtual int GetHashCode();
        //public virtual string ToString();

        // Instance-level, nonvirtual members.
        //public Type GetType();
        //protected object MemberwiseClone();

        // Static members.
        //public static bool Equals(object objA, object objB);
        //public static bool ReferenceEquals(object objA,object objB);
    }



    class Person 
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; set; } = "";

        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person() { }
        #region  class Object overrides 
        public override string ToString()
        {
            string myStr;
            myStr = string.Format("\nFirst Name: {0};\nLast Name: {1};\nAge: {2}\n",
              FirstName, LastName, Age);
            return myStr;
        }
        public override bool Equals(object obj)
        {
            // No need to cast "obj" to a Person anymore,
            // as everything has a ToString() method.
            return obj.ToString() == this.ToString();
        }

        // Return a hash code based on a point of unique string data.
        public override int GetHashCode()
        {
            return SSN.GetHashCode();
        }
        #endregion
   
    }
  
    class Program
    {
        static void StaticMembersOfObject()
    {
        // Static members of System.Object.

        Person p3 = new Person("Ahmed", "Abbas", 4);
        Person p4 = new Person("Ahmed", "Abbas", 4);
        Console.WriteLine("P3 and P4 have same state: {0}", object.Equals(p3, p4));
        Console.WriteLine("P3 and P4 are pointing to same object: {0}", object.ReferenceEquals(p3, p4));
    }
        static void Main(string[] args)
        {

            // NOTE: We want these to be identical to test
            // the Equals() and GetHashCode() methods.
            Person p1 = new Person("Ahmed", "Ali", 30);
            Person p2 = new Person("Ahmed", "Ali", 30);

            // Get stringified version of objects.
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}\n", p2.ToString());

            // Test overridden Equals().
            Console.WriteLine("p1 = p2?: {0}\n", p1.Equals(p2));

            // Test hash codes.
            Console.WriteLine("Both Objects has same hash codes?: {0}\n", 
                p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();

            // Change age of p2 and test again.
            p2.Age = 25;
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}\n", p2.ToString());
            Console.WriteLine("p1 = p2?: {0}\n", p1.Equals(p2));
            Console.WriteLine("Both Objects has same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());

            Console.WriteLine("\nUsing static methods\n");

            StaticMembersOfObject();

            Console.ReadLine();

           
        }
      
        }
}
