using System;
/*
1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, 
display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered 
into input boxes need to be validated.)
*/

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //EchoNumber();
            
            //BiggerNumber();
            
            //Orientation();
            
            SpeedCamera();
            
        }
        
        static int EchoNumber()
        {
            Console.WriteLine("Hello World! What's the number?");
            string UserInput = Console.ReadLine();
            int MyNumber = Int32.Parse(UserInput);
            string Validity = "";
            
            if(MyNumber >0 && MyNumber <11)
                Validity = "Valid";
            else
                Validity = "Invalid";
                
            Console.WriteLine(Validity);
            
            return 0;
        }
        static int BiggerNumber()
        {
            /*
            Write a program which takes two numbers from the console and displays the maximum of the two.
            */
            Console.WriteLine("I'll compare two numbers and return the larger one.  What's the first number please?");
            string Input1 = Console.ReadLine();
            Console.WriteLine("What's the second number?");
            int MyNumber1 = Int32.Parse(Input1);
            string Input2 = Console.ReadLine();
            int MyNumber2 = Int32.Parse(Input2);
            string Bigger = "";
            
            if(MyNumber1 > MyNumber2)
                Bigger = MyNumber1.ToString();
            else
                Bigger = MyNumber2.ToString();
                
            Console.WriteLine(String.Format("The bigger number is: {0}", Bigger));
            
            return 0;
        }
        static int Orientation()
        {
            /*Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.*/
            Console.WriteLine("I'll tell you if it's portrait or landscape.  What's the height please?");
            string HeightInput = Console.ReadLine();
            Console.WriteLine("What's the width please?");
            int height = Int32.Parse(HeightInput);
            string WidthInput = Console.ReadLine();
            int width = Int32.Parse(WidthInput);
            string Orientation = "";
            
            if(height > width)
                Orientation = "Portrait";
            else
                Orientation = "Landscape";
                
            Console.WriteLine(String.Format("The orientation is: {0}", Orientation));
            
            return 0;
        }
        
        static int SpeedCamera()
        {
            /*Your job is to write a program for a speed camera. For simplicity, ignore the details 
            such as camera, sensors, etc and focus purely on the logic. Write a program that asks 
            the user to enter the speed limit. Once set, the program asks for the speed of a car. If 
            the user enters a value less than the speed limit, program should display Ok on the console. 
            If the value is above the speed limit, the program should calculate the number of demerit 
            points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and 
            displayed on the console. If the number of demerit points is above 12, the program should 
            display License Suspended.
            */
            Console.Write("What's the speed limit? ");
            string SpeedLimit = Console.ReadLine();
            int Limit = Int32.Parse(SpeedLimit);            
            Console.Write("Ok. How fast were you going? ");
            string Speed = Console.ReadLine();
            int MySpeed = Int32.Parse(Speed);
            string Punishment = "";
            
            int Points = (MySpeed - Limit) / 5;
            string MyPoints = Points.ToString();
            
            
            if(Points <= 0)
            {
                Punishment = "You were obeying the speed limit!";
                MyPoints = "0";
            }    
            else
            {
               Punishment = "You were not obeying the speed limit!";  
               if(Points > 11)
               {
                   Punishment = String.Format("{0} and your licence is being suspended.", Punishment);
               }
                //do Nothing
            }
            
            Console.WriteLine(Punishment);
                
            Console.WriteLine(String.Format("You have {0} points.", MyPoints));
            
            return 0;
        }
    }
}
