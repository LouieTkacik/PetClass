using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petClassConsole
{
    //Louie Tkacik 0290449 BASIC USE OF CLASSES
    class Pet
    {
        //definte the attributes/fields of pet object
        private string type;
        private string name;
        private int age;

        //define methods to set or get values of the vields
        public void setData(string t, string n, int a)
        {
            type = t;
            name = n;
            age = a;
        }
        public Pet()//this is the constructor
        {
            type = "";
            name = "";
            age = 0;
        }
        public string getName()
        {
            return name;
        }
        public string getType()
        {
            return type;
        }
        public int getAge()
        {
            return age;
        }
        
    }
    class Program
    {
    
        static void Main(string[] args)
        {
            Pet myPet = new Pet();
            Console.WriteLine("Write your pet's name: ");
            string n = Console.ReadLine();

            Console.WriteLine("Write your pet's breed: ");
            string t = Console.ReadLine();

            Console.WriteLine("Write your pet's age: ");
            int a = int.Parse(Console.ReadLine());

            //set the field values for the pet object
            myPet.setData(t, n, a);

            //display the values stored in the fields

            Console.WriteLine("Here is your pet's info: ");
            Console.WriteLine("Name: " + myPet.getName() + ". Breed: " + myPet.getType() + ". Age: " + myPet.getAge() + ".");
            Console.ReadKey();
        }
    }
}
