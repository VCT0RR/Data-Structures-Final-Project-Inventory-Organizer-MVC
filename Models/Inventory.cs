using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InventoryOrganizingFinalProject.Models;

public class Inventory
{
    //6 private fields are declared
    private int _itemNumber; //represents the item number for the item as an integer
    private string _name; //represents the name of the item as a string
    private double _price; //represents the price of the item as a double data type
    private int _quantity; //represents the quantity of all the items as a integer
    private string _type; //represents the type of the item as a string
    private string _model; //represents the model of the item as a string

    //private static guitarBrands field is declared of type PriorityQueue<TElement, TPriority> from the PriorityQueue class using .NET 6.0
    private static PriorityQueue<string, int>? guitarBrands;

    //public getter method of return type int gets the item number
    public int getItemNumber()
    {
        return _itemNumber;
    }

    //public setter method of return type int has one parameter of data type int and sets the value for the item number
    public int setItemNumber(int itemNum)
    {
        return this._itemNumber = itemNum;
    }

    //public getter method of return type string returns the item name
    public string getName()
    {
        return _name;
    }

    //public setter method of return type string has one parameter of return type string and sets the value for the item name
    public string setName(string name)
    {
        return this._name = name;
    }

    //public getter method of return type double returns the item price
    public double getPrice()
    {
        return _price;
    }

    //public setter method of return type double has one parameter of return type double and sets the value for the item price
    public double setPrice(double price)
    {
        return _price = price;
    }

    //public getter method of return type int returns the item quantity
    public int getQuantity()
    {
        return _quantity;
    }

    //public setter method of return type int has one parameter of return type int and sets the value for the item quantity
    public int setQuantity(int quantity)
    {
        return this._quantity = quantity;
    }

    //public getter method of return type string returns the item type
    public string getType()
    {
        return _type;
    }

    //public setter method of return type string has one parameter of return type string and sets the value for the item type
    public string setType(string type)
    {
        return this._type = type;
    }

    //public getter method of return type string returns the item model
    public string getModel()
    {
        return _model;
    }

    //public setter method of return type string has one parameter of return type string and sets the value for the item model
    public string setModel(string model)
    {
        return this._model = model;
    }

    //public default no-arg constructor sets the values for each field
    public Inventory()
    {
        _itemNumber = 0;
        _name = "";
        _price = 0.0;
        _quantity = 0;
        _type = "";
        _model = "";
    }

    //public non-default constructor has 6 parameters and is used to set the values for each field4
    public Inventory(int itemNum, string name, double price, int quantity, string type, string model)
    {
        _itemNumber = itemNum;
        _name = name;
        _price = price;
        _quantity = quantity;
        _type = type;
        _model = model;
    }

    //public overridden ToString() method of return type string returns the values for each property within the class in a properly formatted string
    public override string ToString()
    {
        return "Item#: " + _itemNumber + "\nName: " + _name + "\nPrice: $" +
            _price + "\nQuantity: " + _quantity + "\nType: " + _type + "\nModel: " + _model;
    }

    //public void DisplayGuitarStore() method is used to display the entire guitar store page to the user
    //Within this method, all the various guitars are stored, labeled, displayed, and can be purchased here
    public void DisplayGuitarStore()
    {
        //guitarBrands field is initialized to the PriorityQueue<string, int>() class
        guitarBrands = new PriorityQueue<string, int>();

        //5 different guitar brands are added to the Priority Queue
        //Their access number on the left (string), their brand name in the middle (string), & their availability/left-in-stock number to the right (integer)
        guitarBrands.Enqueue("{1} Fender", 6);
        guitarBrands.Enqueue("{2} Gibson", 4);
        guitarBrands.Enqueue("{3} PRS", 3);
        guitarBrands.Enqueue("{4} Squire", 5);
        guitarBrands.Enqueue("{5} Gretsch", 7);

        //6 new objects are created from the Inventory class with data for all 6 parameters that represents the full guitar information for the fender guitars
        Inventory fenderGuitar1 = new Inventory(50549, "Fender JV Modified '60s Custom Telecaster", 1349.99, 6, "Electric", "JV Modified Series");
        Inventory fenderGuitar2 = new Inventory(50537, "Fender Player Plus Nashville Telecaster", 1149.99, 7, "Electric", "Player Plus Series");
        Inventory fenderGuitar3 = new Inventory(50550, "Fender Player Stratocaster", 849.99, 9, "Electric", "Player Series");
        Inventory fenderGuitar4 = new Inventory(50510, "Fender American Professional II Telecaster", 1699.99, 5, "Electric", "American Professional Series");
        Inventory fenderGuitar5 = new Inventory(50500, "Fender Kurt Cobain Jaguar", 1449.99, 1, "Electric", "60s Jaguar Series");
        Inventory fenderGuitar6 = new Inventory(50515, "Fender American Performer Stratocaster HSS", 1449.99, 2, "Electric", "American Performer Series");

        //4 new objects are created from the Inventory class with data for all 6 parameters that represents the full guitar information for the gibson guitars
        Inventory gibsonGuitar1 = new Inventory(50188, "Gibson Adam Jones Les Paul Standard - Antique Silverburst", 2999.99, 2, "Electric", "Les Paul Standard");
        Inventory gibsonGuitar2 = new Inventory(50133, "Gibson Les Paul Standard - Bourbon Burst", 2699.99, 4, "Electric", "Les Paul Standard");
        Inventory gibsonGuitar3 = new Inventory(50121, "Gibson SG Standard - Heritage Cherry", 1699.99, 8, "Electric", "SG Standard");
        Inventory gibsonGuitar4 = new Inventory(50101, "Gibson SG Standard '61 - Vintage Cherry", 1999.99, 5, "Electric", "SG Standard");

        //3 new objects are created from the Inventory class with data for all 6 parameters that represents the full guitar information for the PRS guitars
        Inventory prsGuitar1 = new Inventory(50632, "PRS Special Semi-Hollow - McCarty Sunburst", 4299.99, 6, "Electric", "PRS Special Series");
        Inventory prsGuitar2 = new Inventory(50631, "PRS SE Silver Sky - Stone Blue w/ Rosewood Fingerboard", 849.99, 9, "Electric", "SE Standard Series");
        Inventory prsGuitar3 = new Inventory(50670, "PRS S2 Custom 24-08 - Bonnie Pink/Cherry Burst", 1929.99, 8, "Electric", "S2 Custom Series");

        //5 new objects are created from the Inventory class with data for all 6 parameters that represents the full guitar information for the Squier guitars
        Inventory squierGuitar1 = new Inventory(50085, "Squier Classic Vibe '50s Telecaster - Butterscotch Blonde", 459.99, 5, "Electric", "Classic Series");
        Inventory squierGuitar2 = new Inventory(50082, "Squier Affinity Series Stratocaster - Surf Green w/ White Pearloid Pickguard", 319.99, 6, "Electric", "Afinity Series");
        Inventory squierGuitar3 = new Inventory(50084, "Squier 40th Anniversary Gold Edition Telecaster - Black", 599.99, 5, "Electric", "Affinity Series");
        Inventory squierGuitar4 = new Inventory(50087, "Squier Classic Vibe '70s Stratocaster HSS - Black w/ Maple Fingerboard", 459.99, 2, "Electric", "Classic Series");
        Inventory squierGuitar5 = new Inventory(50089, "Squier Classic Vibe '70s Jaguar - Black", 489.99, 1, "Electric", "Classic Series");

        //7 new objects are created from the Inventory class with data for all 6 parameters that represents the full guitar information for the Gretsch guitars
        Inventory gretschGuitar1 = new Inventory(50300, "Gretsch G5420TG - 59 - Vintage Orange", 899.99, 7, "Electric", "Classic Hollowbody Single-Cut");
        Inventory gretschGuitar2 = new Inventory(50366, "Gretsch G5410T Electromatic Rat Rod - Matte Black", 849.99, 5, "Electric", "Classic Hollowbody Single-Cut");
        Inventory gretschGuitar3 = new Inventory(50398, "Gretsch G6120TG - DS Players Edition Nashville w/ Dynasonics & Bigsby - Roundup Orange", 2699.99, 5, "Electric", "DS Players Edition");
        Inventory gretschGuitar4 = new Inventory(50389, "Gretsch G6134T - 58 Vintage Select Edition '58 Penguin - Vintage White", 3699.99, 2, "Electric", "Vintage Select Edition");
        Inventory gretschGuitar5 = new Inventory(50377, "Gretsch G5191 Tim Armstrong Signature", 1599.99, 3, "Electric", "Classic Hollowbody Single-Cut");
        Inventory gretschGuitar6 = new Inventory(50351, "Gretsch G6636T Players Edition Falcon Center Block - White Bigsby Tailpiece", 3599.99, 1, "Electric", "Players Edition");
        Inventory gretschGuitar7 = new Inventory(50313, "Gretsch G5422G - 12 Electromatic Classic Hollowbody Double-Cut 12 string - Single Barrel Burst", 899.99, 8, "Electric", "Classic Hollowbody Double-Cut");

        //new linkedList object is created from the LinkedList class of data type int
        LinkedList<int> list = new LinkedList<int>();

        //all guitars are added to the linked list based on their item number
        list.AddLast(fenderGuitar1.getItemNumber());
        list.AddLast(fenderGuitar2.getItemNumber());
        list.AddLast(fenderGuitar3.getItemNumber());
        list.AddLast(fenderGuitar4.getItemNumber());
        list.AddLast(fenderGuitar5.getItemNumber());
        list.AddLast(fenderGuitar6.getItemNumber());

        list.AddLast(gibsonGuitar1.getItemNumber());
        list.AddLast(gibsonGuitar2.getItemNumber());
        list.AddLast(gibsonGuitar3.getItemNumber());
        list.AddLast(gibsonGuitar4.getItemNumber());

        list.AddLast(prsGuitar1.getItemNumber());
        list.AddLast(prsGuitar2.getItemNumber());
        list.AddLast(prsGuitar3.getItemNumber());

        list.AddLast(squierGuitar1.getItemNumber());
        list.AddLast(squierGuitar2.getItemNumber());
        list.AddLast(squierGuitar3.getItemNumber());
        list.AddLast(squierGuitar4.getItemNumber());
        list.AddLast(squierGuitar5.getItemNumber());

        list.AddLast(gretschGuitar1.getItemNumber());
        list.AddLast(gretschGuitar2.getItemNumber());
        list.AddLast(gretschGuitar3.getItemNumber());
        list.AddLast(gretschGuitar4.getItemNumber());
        list.AddLast(gretschGuitar5.getItemNumber());
        list.AddLast(gretschGuitar6.getItemNumber());
        list.AddLast(gretschGuitar7.getItemNumber());

        //while loop is used to display all 5 guitar brands using the TryDequeue() method from the PriorityQueue class
        while (guitarBrands.TryDequeue(out string item, out int priority))
        {
            //prints each guitar brand in order of their available quantity from lowest to highest
            Console.WriteLine($"Guitar Brands: {item}. Available (in-stock): {priority}");
        }
        //prompts the user to enter the associated number (1 to 5) to view all the guitars for the desired guitar brand
        Console.WriteLine("Enter the number (1 - 5) to view all the available guitars for the desired guitar brand: ");
        int guitarBrandInput = Convert.ToInt32(Console.ReadLine()); //converts the input to an integer and then takes & reads the user input

        //while loop prompts the user to re-enter the number for the guitar brand if the input is less than 1 OR greater than 5
        while (guitarBrandInput < 1 || guitarBrandInput > 5)
        {
            Console.WriteLine("Invalid input. Enter the number (1 - 5) to view all the available guitars for the desired guitar brand: ");
            guitarBrandInput = Convert.ToInt32(Console.ReadLine()); //converts the input to an integer and then takes & reads the user input
        }

        //if the user enters '1' for the guitar brand, then all 6 fenderGuitar objects call the ToString() method displaying all the info for each guitar
        if (guitarBrandInput == 1)
        {
            Console.WriteLine(fenderGuitar1.ToString() + "\n");
            Console.WriteLine(fenderGuitar2.ToString() + "\n");
            Console.WriteLine(fenderGuitar3.ToString() + "\n");
            Console.WriteLine(fenderGuitar4.ToString() + "\n");
            Console.WriteLine(fenderGuitar5.ToString() + "\n");
            Console.WriteLine(fenderGuitar6.ToString() + "\n");

            const int SIZE = 6; //constant field of data type int is declared & initialized to 6 & represents the max size for the array

            //int array is created & calls all the item numbers for the guitars using the getItemNumber() method
            int[] array = new int[SIZE] { fenderGuitar1.getItemNumber(), fenderGuitar2.getItemNumber(), fenderGuitar3.getItemNumber(),
                                          fenderGuitar4.getItemNumber(), fenderGuitar5.getItemNumber(), fenderGuitar6.getItemNumber() };
            InsertionSort fenderSort = new InsertionSort(); //new fenderSort object is created from the InsertionSort class

            //InsertionSortAlgorithm() method is called with the array field as the parameter & is used to sort the item numbers for the guitars in the array
            fenderSort.InsertionSortAlgorithm(array);
            Console.Write("Fender Guitar Item Numbers: "); //title for the guitar item numbers

            //printSortedArray() method is called with the array field as the parameter & prints the fully sorted array of item numbers for the guitars
            fenderSort.printSortedArray(array);
        }

        //if the user enters '2' for the guitar brand, then all 4 gibsonGuitar objects call the ToString() method displaying all the info for each guitar
        else if (guitarBrandInput == 2)
        {
            Console.WriteLine(gibsonGuitar1.ToString() + "\n");
            Console.WriteLine(gibsonGuitar2.ToString() + "\n");
            Console.WriteLine(gibsonGuitar3.ToString() + "\n");
            Console.WriteLine(gibsonGuitar4.ToString() + "\n");

            const int SIZE = 4; //constant field of data type int is declared & initialized to 4 & represents the max size for the array

            //int array is created & calls all the item numbers for the guitars using the getItemNumber() method
            int[] array = new int[SIZE] { gibsonGuitar1.getItemNumber(), gibsonGuitar2.getItemNumber(), gibsonGuitar3.getItemNumber(),
                                          gibsonGuitar4.getItemNumber() };
            InsertionSort gibsonSort = new InsertionSort(); //new gibsonSort object is created from the InsertionSort class

            //InsertionSortAlgorithm() method is called with the array field as the parameter & is used to sort the item numbers for the guitars in the array
            gibsonSort.InsertionSortAlgorithm(array);
            Console.Write("Gibson Guitar Item Numbers: "); //title for the guitar item numbers

            //printSortedArray() method is called with the array field as the parameter & prints the fully sorted array of item numbers for the guitars
            gibsonSort.printSortedArray(array);
        }

        //if the user enters '3' for the guitar brand, then all 3 prsGuitar objects call the ToString() method displaying all the info for each guitar
        else if (guitarBrandInput == 3)
        {
            Console.WriteLine(prsGuitar1.ToString() + "\n");
            Console.WriteLine(prsGuitar2.ToString() + "\n");
            Console.WriteLine(prsGuitar3.ToString() + "\n");

            const int SIZE = 3; //constant field of data type int is declared & initialized to 3 & represents the max size for the array

            //int array is created & calls all the item numbers for the guitars using the getItemNumber() method
            int[] array = new int[SIZE] { prsGuitar1.getItemNumber(), prsGuitar2.getItemNumber(), prsGuitar3.getItemNumber() };
            InsertionSort prsSort = new InsertionSort(); //new prsSort object is created from the InsertionSort class

            //InsertionSortAlgorithm() method is called with the array field as the parameter & is used to sort the item numbers for the guitars in the array
            prsSort.InsertionSortAlgorithm(array);
            Console.Write("PRS Guitar Item Numbers: "); //title for the guitar item numbers

            //printSortedArray() method is called with the array field as the parameter & prints the fully sorted array of item numbers for the guitars
            prsSort.printSortedArray(array);
        }

        //if the user enters '4' for the guitar brand, then all 5 squierGuitar objects call the ToString() method displaying all the info for each guitar
        else if (guitarBrandInput == 4)
        {
            Console.WriteLine(squierGuitar1.ToString() + "\n");
            Console.WriteLine(squierGuitar2.ToString() + "\n");
            Console.WriteLine(squierGuitar3.ToString() + "\n");
            Console.WriteLine(squierGuitar4.ToString() + "\n");
            Console.WriteLine(squierGuitar5.ToString() + "\n");

            const int SIZE = 4; //constant field of data type int is declared & initialized to 4 & represents the max size for the array

            //int array is created & calls all the item numbers for the guitars using the getItemNumber() method
            int[] array = new int[SIZE] { squierGuitar1.getItemNumber(), squierGuitar2.getItemNumber(), squierGuitar3.getItemNumber(),
                                          squierGuitar4.getItemNumber() };
            InsertionSort squierSort = new InsertionSort(); //new squierSort object is created from the InsertionSort class

            //InsertionSortAlgorithm() method is called with the array field as the parameter & is used to sort the item numbers for the guitars in the array
            squierSort.InsertionSortAlgorithm(array);
            Console.Write("Squier Guitar Item Numbers: "); //title for the guitar item numbers

            //printSortedArray() method is called with the array field as the parameter & prints the fully sorted array of item numbers for the guitars
            squierSort.printSortedArray(array);

        }

        //if the user enters '5' for the guitar brand, then all 7 gretschGuitar objects call the ToString() method displaying all the info for each guitar
        else if (guitarBrandInput == 5)
        {
            Console.WriteLine(gretschGuitar1.ToString() + "\n");
            Console.WriteLine(gretschGuitar2.ToString() + "\n");
            Console.WriteLine(gretschGuitar3.ToString() + "\n");
            Console.WriteLine(gretschGuitar4.ToString() + "\n");
            Console.WriteLine(gretschGuitar5.ToString() + "\n");
            Console.WriteLine(gretschGuitar6.ToString() + "\n");
            Console.WriteLine(gretschGuitar7.ToString() + "\n");

            const int SIZE = 7; //constant field of data type int is declared & initialized to 7 & represents the max size for the array

            //int array is created & calls all the item numbers for the guitars using the getItemNumber() method
            int[] array = new int[SIZE] { gretschGuitar1.getItemNumber(), gretschGuitar2.getItemNumber(), gretschGuitar3.getItemNumber(),
                                          gretschGuitar4.getItemNumber(),gretschGuitar5.getItemNumber(),gretschGuitar6.getItemNumber(),
                                          gretschGuitar7.getItemNumber()};
            InsertionSort gretschSort = new InsertionSort(); //new gretschSort object is created from the InsertionSort class

            //InsertionSortAlgorithm() method is called with the array field as the parameter & is used to sort the item numbers for the guitars in the array
            gretschSort.InsertionSortAlgorithm(array);
            Console.Write("Gretsch Guitar Item Numbers: "); //title for the guitar item numbers

            //printSortedArray() method is called with the array field as the parameter & prints the fully sorted array of item numbers for the guitars
            gretschSort.printSortedArray(array);
        }
        else
        {   //otherwise, any other input that the user enters that is not within the range of 1 to 5 is given an error message
            Console.WriteLine("Invalid input. Value must be within the range of 1 - 5 to view guitars: ");
        }

        //user is prompted to enter the item number for the guitar that they wish to purchase
        Console.WriteLine("\nEnter the item number to add the guitar to your cart:");
        int input = Convert.ToInt32(Console.ReadLine()); //converts the input to an integer and then takes & reads the user input

        //if the user enters the exact item number for the desired guitar, then the PurchaseGuitar() method is called in order for the user to buy the guitar
        if (input == fenderGuitar1.getItemNumber())
        {
            PurchaseGuitar(fenderGuitar1);
        }
        else if (input == fenderGuitar2.getItemNumber())
        {
            PurchaseGuitar(fenderGuitar2);
        }
        else if (input == fenderGuitar3.getItemNumber())
        {
            PurchaseGuitar(fenderGuitar3);
        }
        else if (input == fenderGuitar4.getItemNumber())
        {
            PurchaseGuitar(fenderGuitar4);
        }
        else if (input == fenderGuitar5.getItemNumber())
        {
            PurchaseGuitar(fenderGuitar5);
        }
        else if (input == fenderGuitar6.getItemNumber())
        {
            PurchaseGuitar(fenderGuitar6);
        }

        //if the user enters the exact item number for the desired guitar, then the PurchaseGuitar() method is called in order for the user to buy the guitar
        else if (input == gibsonGuitar1.getItemNumber())
        {
            PurchaseGuitar(gibsonGuitar1);
        }
        else if (input == gibsonGuitar2.getItemNumber())
        {
            PurchaseGuitar(gibsonGuitar2);
        }
        else if (input == gibsonGuitar3.getItemNumber())
        {
            PurchaseGuitar(gibsonGuitar3);
        }
        else if (input == gibsonGuitar4.getItemNumber())
        {
            PurchaseGuitar(gibsonGuitar4);
        }

        //if the user enters the exact item number for the desired guitar, then the PurchaseGuitar() method is called in order for the user to buy the guitar
        else if (input == prsGuitar1.getItemNumber())
        {
            PurchaseGuitar(prsGuitar1);
        }
        else if (input == prsGuitar2.getItemNumber())
        {
            PurchaseGuitar(prsGuitar2);
        }
        else if (input == prsGuitar3.getItemNumber())
        {
            PurchaseGuitar(prsGuitar3);
        }

        //if the user enters the exact item number for the desired guitar, then the PurchaseGuitar() method is called in order for the user to buy the guitar
        else if (input == squierGuitar1.getItemNumber())
        {
            PurchaseGuitar(squierGuitar1);
        }
        else if (input == squierGuitar2.getItemNumber())
        {
            PurchaseGuitar(squierGuitar2);
        }
        else if (input == squierGuitar3.getItemNumber())
        {
            PurchaseGuitar(squierGuitar3);
        }
        else if (input == squierGuitar4.getItemNumber())
        {
            PurchaseGuitar(squierGuitar4);
        }
        else if (input == squierGuitar5.getItemNumber())
        {
            PurchaseGuitar(squierGuitar5);
        }

        //if the user enters the exact item number for the desired guitar, then the PurchaseGuitar() method is called in order for the user to buy the guitar
        else if (input == gretschGuitar1.getItemNumber())
        {
            PurchaseGuitar(gretschGuitar1);
        }
        else if (input == gretschGuitar2.getItemNumber())
        {
            PurchaseGuitar(gretschGuitar2);
        }
        else if (input == gretschGuitar3.getItemNumber())
        {
            PurchaseGuitar(gretschGuitar3);
        }
        else if (input == gretschGuitar4.getItemNumber())
        {
            PurchaseGuitar(gretschGuitar4);
        }
        else if (input == gretschGuitar5.getItemNumber())
        {
            PurchaseGuitar(gretschGuitar5);
        }
        else if (input == gretschGuitar6.getItemNumber())
        {
            PurchaseGuitar(gretschGuitar6);
        }
        else if (input == gretschGuitar7.getItemNumber())
        {
            PurchaseGuitar(gretschGuitar7);
        }
        else
        {
            //prints error message to the user if they enter an invalid item number
            Console.WriteLine("Invalid item number! Enter the item number to add the guitar to your cart: ");
            input = Convert.ToInt32(Console.ReadLine()); //converts the input to an integer and then takes & reads the user input
        }
    }


    //public void method has one parameter of type Inventory & is used to give the user the option to purchase the item in their cart
    public void PurchaseGuitar(Inventory guitars)
    {
        //prints message to the user saying that the item has been added to their cart
        Console.WriteLine("Item has been added to your cart.");

        //prompts user to enter 1 to buy the item or enter 2 to cancel their purchase
        Console.WriteLine("\nType '1' to purchase the items in your cart or type '2' to cancel purchase: ");
        int purchaseInput = Convert.ToInt32(Console.ReadLine()); //takes & reads user input and converts it into an integer

        //if the user enters '1', then the program displays all the item information by calling the getName(), getPrice(), & ToString() method
        if (purchaseInput == 1)
        {
            Console.WriteLine("\nYou have purchased " + guitars.getName() + " for a total of $" + guitars.getPrice() + "\nOrder Summary: " + guitars.ToString());
            guitarBrands.Dequeue(); //the items in the priority queue are emptied once the user purchases the guitar
        }
        else if (purchaseInput == 2)
        {
            //otherwise, if the user enters '2', then their purchased is canceled and they are returned to the main menu
            Console.WriteLine("Purchase has been canceled.\nYou have returned back to the Main Menu.");
        }
        else
        {
            //otherwise, any other input displays and error message to the user
            Console.WriteLine("Invalid input. Value must be either '1' or '2' to continue.");
        }
    }
}
