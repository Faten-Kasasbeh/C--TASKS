using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_11_tasks
{
    internal class information
    {
        private int Age;
        private string Gender;
        private string Name;
        private string Mail;
        private int ID;
        private string Phone;

        public information(int age, string gender, string name, string mail, int id , string phone)
        {
            if(age<=60 && age >= 18)
            {
                Age = age;
            }
            Gender= gender;
            Name= name;
            Mail= mail;
            ID= id;
          
            if (phone[0]=='0' && phone[1]=='7' && (phone[2]=='7'|| phone[2]=='8' || phone[3]=='9')) {
                Phone = phone; 
            }
            else
            {
                Console.WriteLine("THE PHONE NUM NOT VALID");
            }

            Console.WriteLine("Age = " + Age);
            Console.WriteLine("Gender is " + Gender);
            Console.WriteLine("Name is  " + Name);
            Console.WriteLine("E-Mail is "+ Mail);
            Console.WriteLine("phone is  " + Phone);

        }
        static void Main(string[] args)
        {

            information student1 = new information(27 , "Female" , "Faten", "fatenkasasbeh41@gmail.com", 8, "0787437374");

            //information student2 = new information(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
           
        }

    }


}
