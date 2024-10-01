/*
* Classname:  BankingApp
* Information:  Logical operators demo
* Version:  1
* Author: Dr James Connolly
* Date:  August 2024
*/


BuildBankingApp();

void BuildBankingApp() {


    //Initialise variable 
    int choice;
    double depositAmount;
    double accountBalance = 1000.00;
    double withdrawAmount;

    //Display the main menu screen
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - deposit or withdraw funds");
    Console.WriteLine("2 - view current account information");
    Console.WriteLine("1 - deposit or withdraw funds");
    Console.WriteLine("Please choose an option (1-2)");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1 || choice == 2)
    {

        Console.WriteLine("Please choose an option");
        Console.WriteLine("1 - Deposit funds");
        Console.WriteLine("2 - Withdraw fund");
        Console.WriteLine("Please choose an option (1-2)");

        if (choice == 1){
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Entwer amount including pence using a demical point");

            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The original balance was {0}", accountBalance);

            accountBalance += depositAmount;
            Console.WriteLine("The new balance was {0}", accountBalance);
        }

        if (choice == 2){
            Console.WriteLine("How much do you want to withdraw from account?");
            Console.WriteLine("Entwer amount including pence using a demical point");

            withdrawAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The original balance was {0}", accountBalance);

            accountBalance -= withdrawAmount;
            Console.WriteLine("The new balance for account is {0}", accountBalance);
        }
    }
    else
    {
        Console.WriteLine("Please choose a valid menu option between 1-2");
    }



}
