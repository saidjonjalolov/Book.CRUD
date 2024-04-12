// See https://aka.ms/new-console-template for more information


using System;
using Book.CRUD.Broker.Storeage;
using Book.CRUD.Models;
using Book.CRUD.Service;

IBookService bookService = new BookService();
    
bool isContinue = true;
do
{
    Console.WriteLine("1. Get All Book");
    Console.WriteLine("2. Add Book");
    Console.WriteLine("3. Update one book");
    Console.WriteLine("4. Delete one book");
    Console.WriteLine("5. Get book");
    Console.Write("Enter command: ");
    string command = Console.ReadLine();

    if (command.Contains("1") is true)
    {
        bookService.ReadAllBook();
    }
    if (command.Contains("2") is true)
    {
        Books bookInfo = new Books();
        Console.Write("Enter yout Id: ");
        bookInfo.Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter yout Name: ");
        bookInfo.Name = Console.ReadLine();
        Console.Write("Enter your Author: ");
        bookInfo.Author = Console.ReadLine(); 
    }
    if (command.Contains("3") is true)
    {
        //Inomjon Safarov write Update() method impliment in Service
    }
    if (command.Contains("4") is true)
    {
        //Karimjon Abidjonov write Delete() method impliment in Service
    }
    if (command.Contains("5") is true)
    {
        Console.Write("Enter id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        bookService.GetBook(id);
    }

    Console.Write("Is Continue: ");
    string isCommand = Console.ReadLine();
    if (isCommand.ToLower().Contains("no") is true)
    {
        isContinue = false;
    }
} while (isContinue is true);
