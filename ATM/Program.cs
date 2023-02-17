﻿using System;

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
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
        }
    }

}