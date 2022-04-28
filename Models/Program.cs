using System;
using System.Collections.Generic;
using System.Text;
/**************************************************************
* Name        : FinalProjectRyan
* Author      : Abhishek Ryan
* Created     : 04/29/2022
* Course      : CIS 152 - Data Structures
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Program demonstrates a basic online electric guitar store with a main menu, shopping cart, and checkout. 
*               The user can pick any electric guitar from a large list of guitars and purchase the guitar of their choice
*               Input:  User Input
*               Output: "Item#: " + _itemNumber + "\nName: " + _name + "\nPrice: $" + 
                        _price + "\nQuantity: " + _quantity + "\nType: " + _type + "\nModel: " + _model;
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

namespace InventoryOrganizingFinalProject
{
    public class Program //---Tester class for insertion sort, linked list, and priority queue
    {
        public static void Main(string[] args)
        {
            //opening messages that the user will read when they first open the program
            Console.WriteLine("Hello! Welcome to Abhi's Electric Guitar Store!\n");
            Console.WriteLine("Here, we sell a wide variety of electric guitars!");
            Console.WriteLine("Feel free to browse through our list of guitars below.\n");

            Console.WriteLine("Enter the required information below to log into your music store account and browse our store.\n");

            //try-catch block surrounds the rest of the entire program and is used to handle input exceptions from the user
            try
            {
                //tells the user to enter their user ID to log into the guitar store application
                Console.WriteLine("Please enter your user ID to log in (must be 4 digits only):");
                int userIdInput = Convert.ToInt32(Console.ReadLine()); //converts the input to an integer and then takes & reads the user input

                //while loops prompts the user to re-enter their userID if their input is less than OR greater than 4 digits
                while (userIdInput < 1000 || userIdInput > 9999)
                {
                    Console.WriteLine("Invalid input. User ID must be 4 digits.");
                    userIdInput = Convert.ToInt32(Console.ReadLine()); //converts the input to an integer and then takes & reads the user input
                }

                //tells the user to enter their password for their account
                Console.WriteLine("\nEnter your password for your account: ");
                string userPassword = Console.ReadLine(); //takes & reads user input as a string

                //while loop prompts the user to re-enter their password if the input length is less than 8 OR greater than 50
                while (userPassword.Length < 8 || userPassword.Length > 50)
                {
                    Console.WriteLine("Invalid input. Password must be at least 8 characters long: ");
                    userPassword = Console.ReadLine(); //takes & reads user input as a string
                }

                //tells the user to enter their first name
                Console.WriteLine("\nEnter your first name: ");
                string userFName = Console.ReadLine(); //takes & reads user input as a string

                //while loop prompts the user to re-renter their first name if it is less than 2 characters OR greater than 25 characters
                while (userFName.Length < 2 || userFName.Length > 25)
                {
                    Console.WriteLine("Invalid input. First name must be a string text: ");
                    userFName = Console.ReadLine(); //takes & reads user input as a string
                }

                //tells the user to enter their last name
                Console.WriteLine("\nEnter your last name: ");
                string userLName = Console.ReadLine(); //takes & reads user input as a string

                //while loop prompts the user to re-enter their last name if it is less than 2 characters OR greater than 25 characters
                while (userLName.Length < 2 || userLName.Length > 25)
                {
                    Console.WriteLine("Invalid input. Last name must be a string text: ");
                    userLName = Console.ReadLine(); //takes & reads user input as a string
                }

                //tells the user to enter their email address
                Console.WriteLine("\nEnter your email address: ");
                string userEmail = Console.ReadLine().ToLower(); //takes & reads user input as a string & converts it to all lowercase

                //while loop prompts the user to re-enter their email if it is less than 12 characters OR greater than 50 characters
                while (userEmail.Length < 12 || userEmail.Length > 50)
                {
                    Console.WriteLine("Invalid input. Email must be at least 12 characters long: ");
                    userEmail = Console.ReadLine().ToLower(); //takes & reads user input as a string & converts it to all lowercase
                }

                //tells the user to enter their phone number
                Console.WriteLine("\nEnter your phone number: ");
                string userPhoneNum = Console.ReadLine(); //takes & reads user input as a string

                //while loop prompts the user to re-enter their phone number if it is not exactly 10 characters long
                while (userPhoneNum.Length != 10)
                {
                    Console.WriteLine("Invalid input. Phone number must be 10 characters long. No hypens or special characters needed: ");
                    userPhoneNum = Console.ReadLine(); //takes & reads user input as a string
                }

                //creates a new LinkedList variable of data type int
                var userList = new LinkedList<int>();

                //while the size of the userList is greater than 0, the userID for each user is added & stored in the Linked List
                while (userList.Count > 0)
                {
                    userList.AddFirst(userIdInput);
                }

                //prints a welcome message to the user and prints their first & last name and only capitalizes the first letter for the first & last name
                Console.WriteLine("\nWelcome " + userFName.Substring(0, 1).ToUpper() + userFName.Substring(1) +
                    " " + userLName.Substring(0, 1).ToUpper() + userLName.Substring(1) + "!\n\n"); //calls the Substring() & ToUpper() methods

                int userInput = 1; //int field is declared & initialized to 1

                InventoryOrganizingFinalProject.Models.Inventory guitars = new Models.Inventory(); //new object is created from the Inventory class

                //while the userInput does not equal 0, the code below continously executes
                while (userInput != 0)
                {
                    //do while loop is used to execute the code below at least once to display the Main Menu to the user
                    do
                    {
                        //the Main Menu for the program is displayed showing the different options that the user can choose
                        //the user can enter '1' to view all their account information that they previously entered
                        //the user can enter '2' to view the Guitar Store and purchase a guitar
                        //the user can enter '0' to simply exit out of the application and end the program
                        Console.WriteLine("-------Main Menu-------\n");
                        Console.WriteLine("{1} View Your Account: ");
                        Console.WriteLine("{2} View Guitar Store: ");
                        Console.WriteLine("{0} Exit Application: ");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Enter '1' or '2' to continue or enter 0 to quit: ");
                        userInput = Convert.ToInt32(Console.ReadLine()); //converts the input to an integer and then takes & reads the user input

                        //if the user enters a value that is not 1, 2, or 0, then an error message is displayed to the user
                        if (userInput < 0 || userInput > 2)
                        {
                            Console.WriteLine("Invalid input. Value must be an integer and within the given range of 1 - 2: ");
                        }
                    }
                    while (userInput < 0 || userInput > 2); //while the userInput is less than 0 OR greater than 2, the Main Menu is displayed

                    //if the user enters '1', then their userID is displayed from the LinkedList
                    if (userInput == 1)
                    {
                        //foreach loop prints the user ID by calling the LinkedList for the userID
                        foreach (int str in userList)
                        {
                            Console.WriteLine("User ID: " + str);
                        }
                        //new Customer object is created from the Customer class with 6 parameters and utilizes the non-default constructor
                        Customers customerInfo = new Customers(userIdInput, userPassword, userFName, userLName, userEmail, userPhoneNum);

                        //prints all the customer information by using the customerInfo object to call the ToString() method from the Customer class
                        Console.WriteLine(customerInfo.ToString());
                    }
                    //otherwise, if the user enters '2', then the Guitar Store is displayed to the user
                    else if (userInput == 2)
                    {
                        Console.WriteLine("Guitar Store: "); //title for the guitar store page
                        guitars.DisplayGuitarStore(); //guitars object calls the DisplayGuitarStore() method from the Inventory class
                    }
                    else
                    {
                        //otherwise, if the user enters 0, then the while loop is exited and the program is finished
                        Console.WriteLine("\nYou have exited the application.");
                    }
                }
            }
            //catches the input exception if the user enters input that is not in the correct format or the correct data type
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //prints error message to the user
            }
        }
    }
}
