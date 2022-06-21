using System;

namespace Program{
    class Lab2{

        static void Main(string [] args){
                char S;
            do{
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if(num%2 == 0){
                    Console.WriteLine("Even");
                }
                else {
                    Console.WriteLine("Odd");
                    };
                Console.WriteLine("Do you want to enter another number (Y/N)");
                S = Convert.ToChar(Console.ReadLine());
            }while(S =='y'||S =='Y');
        }
    }
}