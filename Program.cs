using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Variables section
            String prompt = "> ";
            String cheer_prefix = "Give me a";
            String requires_an = "halfnorsemix";

            //Prompts for UI
            Console.WriteLine("What's your name?");
            Console.Write(prompt);

            //Read from terminal save to a variable
            String user_name = Console.ReadLine().ToLower(); 

            //After your user enters their name, your program should ask for their birthdate.
			//The user should only have to enter the Day and Month
            Console.WriteLine("What's your birthday? (mm/dd)");
            Console.Write(prompt);
			
            //Read from terminal save to a variable for birthdate
			String user_birthday = Console.ReadLine(); 
			DateTime birthday = DateTime.Parse(user_birthday);
			Console.WriteLine(birthday);
			DateTime now = DateTime.Now;

            //Cheer Section
            //Loop thru user name response and add prefix w/a or an.

            for(int i = 0; i < user_name.Length; i++) {
                if (requires_an.IndexOf(user_name[i]) > -1) {
                    //Then its in the requires_an array!
                    Console.WriteLine(cheer_prefix + "n" + ".." + user_name[i]);
                }else{
                    //Does not require "an"
                    Console.WriteLine(cheer_prefix +  ".." + user_name[i]);
                }
            }
            Console.WriteLine(user_name.ToUpper() + " is.. GRAND!");

            //Birthday calculation section
            //After the cheer, your program should tell the user how many more days there are until their next birthday.
			//Once you have today's date, then subtract user's input.

			int result = DateTime.Compare(birthday, now);
            TimeSpan remainder = now.Subtract(birthday);

			if (result > 0) 
            {
                Console.WriteLine(remainder.Days.ToString() + " days until your next b-day!");
			}else if (remainder.Days.ToString() == "0"){
				Console.WriteLine("Happy Bitrthday!");
			}else
            {
                Console.WriteLine(remainder.Days.ToString() + " days until you are OLLLLLDDDD!");
            }
        }
    }
}
