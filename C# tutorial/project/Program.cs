using System;
namespace Project
{
    class Program
    {
        public static void Main(string[] args)
        {

            bool playagain=true;
            while(playagain){

            Console.WriteLine(@"Choose the option 
            1. Inheritance
            2. Method Overloading
            3. Method Overriding
            4. Extension Method
            5. Interface
            6. Non Generic Collection
            7. List     
            8. Stack    
            9. Queue
            10. Ref and Out 
            11.Hashset
            12.Inheritance
            13.Abstraction
            14.Encapsulation
            15.Dictionary " );

            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (choice)
            {
                case 1:
                    Inheritance.Run(args);
                    break;
                case 2:
                    Methodoverloading.Run(args);
                    break;
                case 3:
                    Methodoverridding.Run(args);
                    break;
                case 4:
                    Extensionmethod.Run(args);
                    break;
                case 5:
                    Interface.Run(args);
                    break;
                case 6:
                    Nongeneric.Run(args);
                    break;
                case 7:
                    Listcode.Run(args);
                    break;
                case 8:
                    Stackcode.Run(args);
                    break;
                case 9:
                    Queuecode.Run(args);
                    break;
                case 10:
                    Refandout.Run(args);
                    break;
                case 11:
                    Hashset.Run(args);
                    break;
                case 12:
                    Inheritance.Run(args);
                    break;
                case 13:
                    Abstraction.Run(args);
                    break;
                case 14:
                    Encapsulation.Run(args);
                    break;
                case 15:
                    Dictionary.Run(args);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine("continue = y");
            string ans=Console.ReadLine().ToLower();
            if(ans!="y"){
                playagain=false;
            }

            }
            


        }
    }
}