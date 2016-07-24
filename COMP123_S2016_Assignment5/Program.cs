using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
     *Student Name: Golden Pamela Apillanes 
     *Student no.#: 300867201
     *Due Date: July 21st 2016
     *Description: Assignment 5 - File I/O and Exception Handling 
    */
namespace COMP123_S2016_Assignment5
{
    /**
        * <summary>
        * The Maim method for our driver class program
        * </summary> 
        * 
        * @class: program
        */
    class Program
    {
        private static List<string> student = new List<string>();
        /**
        * <summary>
        * The Main method for our driver class program
        * </summary> 
        * 
        * @constructor:Main
        * @param {string[]}args
        */
        static void Main(string[] args)
        {
            showMenu();
        }

             /**
              * <summary>
              * This method displays the menu using a while loop
              * </summary>
              * 
              * @static
              * @method DisplayMenu
              * 
              * @returns {void}
              */
        public static void showMenu()
        {
           
            bool selection = true;

            
            while (selection)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("||           Grade Viewer              ||");
                Console.WriteLine("||                                     ||");
                Console.WriteLine("||       1 -  Display Grades           ||");
                Console.WriteLine("||       2 -  Exit                     ||");
                Console.WriteLine("||                                     ||");
                Console.WriteLine("=========================================");
                Console.WriteLine();

                switch (Console.ReadKey().Key)
                {
                        // selects option 1 on the grade menu
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("+ Student Grades +");
                        Console.WriteLine("+ Please enter the file name");
                        string fileInput = Console.ReadLine();
                        textFile(fileInput);
                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        // selects option 2 on the grade menu
                    case ConsoleKey.D2: 
                        selection = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }

        public static void textFile(string fileName)
        {
            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader fileReader = new StreamReader(fileStream);
                string line = fileReader.ReadLine();
                while (line != null)
                {
                    student.Add(line);

                    Console.WriteLine(line);
                    line = fileReader.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {
                Console.Clear();
                showMenu();
                Console.WriteLine("ERROR: File Not Found");
            }


        }


    }
}
         
