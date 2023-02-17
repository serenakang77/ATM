using System;
using System.Runtime.InteropServices;

public class cardHolder
{
    string cardnum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardnum, int pin, string firstName, string lastName, double balance)
    {
        this.cardnum = cardnum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getNum()
    {
        return cardnum;
    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName() { 
        return firstName;
    }

    public String getLastName() {
        return lastName;    
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(String newCardNum)
    {
        cardnum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;   
    }

    public void setFirstName(String newFirstName) {
        firstName= newFirstName;
    }

    public void setLastName(String newLastName) {
        lastName= newLastName;
    }

    public void setBalance(double newBalance) {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw: ");
            double withdraw = Double.Parse(Console.ReadLine());
            //Check if the user has enough money
            if(currentUser.getBalance() > withdraw)
            {
            currentUser.setBalance(currentUser.getBalance() - withdraw);
            Console.WriteLine("Thank you for withdrawing $$. Your new balance is " + currentUser.getBalance());
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
        
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Your current balance is: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("455555521323", 1234, "John", "Griffith", 150.31));
        cardHolders.Add(new cardHolder("453121515123", 4567, "Asheley", "Jones", 321.13));
        cardHolders.Add(new cardHolder("512838215165", 9999, "Frida", "Dickerson", 105.59));
        cardHolders.Add(new cardHolder("601118351235", 2468, "Muneeb", "Harding", 851.84));
        cardHolders.Add(new cardHolder("349065521565", 4826, "Dawn", "Smith", 54.27));

        //Prompt user
        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum= Console.ReadLine();
                //Check against our db
                //FirstOrDefault finds the first one that is matching
                currentUser = cardHolders.FirstOrDefault(a => a.cardnum== debitCardNum);
                if(currentUser != null) { break; }
                else { Console.WriteLine("Card not recognized. Please try again"); }
            }
            catch
            {
                Console.WriteLine("Card not recognized. Please try again"); 

            }
        }

        Console.WriteLine("Please enter your pin");
        int userPin = 0;
        while(true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if(currentUser.getPin() == userPin) { break; } else { Console.WriteLine("Card pin is wrong. Please try again"); }
            }
            catch
            {
                Console.WriteLine("Card pin is wrong.Please try again");
            }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstName());
        int option = 0;
        do
        {
            printOptions();
            try
            {
             option = int.Parse(Console.ReadLine());

            }
            catch(FormatException)
            {
                Console.WriteLine("please enter right number");
            }
            if (option == 1)
            {
                deposit(currentUser);
            }
            else if(option == 2)
            {
                withdraw(currentUser);
            }
            else if(option == 3){
                balance(currentUser);
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                option = 0;
            }
        }
        while (option != 4);
            Console.WriteLine("Thank you, have a nice day!");
        
    }

}