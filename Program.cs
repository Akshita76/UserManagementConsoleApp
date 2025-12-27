using System;
using System.Collections.Generic;

public class UserManagementSystem
{
    public static void Main(string[] args)
    {
        List<string> users = new List<string>();
        int choice;

        do
        {
            Console.WriteLine("\n--- User Management Menu ---");
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Remove user");
            Console.WriteLine("3. View users");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddUser(users);
                    break;

                case 2:
                    RemoveUser(users);
                    break;

                case 3:
                    DisplayUsers(users);
                    break;

                case 4:
                    Console.WriteLine("Exiting application...");
                    break;

                default:
                    Console.WriteLine("Please choose between 1 and 4.");
                    break;
            }

        } while (choice != 4);
    }

    static string ValidateUsername(string username)
    {
        if (string.IsNullOrEmpty(username))
            return "Username cannot be null or empty";

        if (username.Length < 5)
            return "Username must have at least 5 characters";

        if (username.Contains(" "))
            return "Username must not contain spaces";

        return "OK";
    }

    static void AddUser(List<string> users)
    {
        Console.Write("Enter username to add: ");
        string username = Console.ReadLine();

        string validationResult = ValidateUsername(username);

        if (validationResult != "OK")
        {
            Console.WriteLine(validationResult);
            return;
        }

        if (users.Contains(username))
        {
            Console.WriteLine("Username already exists");
            return;
        }

        users.Add(username);
        Console.WriteLine("Username added successfully");
    }

    static void RemoveUser(List<string> users)
    {
        Console.Write("Enter username to remove: ");
        string username = Console.ReadLine();

        if (users.Contains(username))
        {
            users.Remove(username);
            Console.WriteLine("Username removed successfully");
        }
        else
        {
            Console.WriteLine("User not found");
        }
    }

    static void DisplayUsers(List<string> users)
    {
        if (users.Count == 0)
        {
            Console.WriteLine("No users available");
            return;
        }

        Console.WriteLine("\nCurrent users:");
        foreach (string user in users)
        {
            Console.WriteLine(user);
        }
    }
}
git status
git add .
git commit -m "Initial project setup with user management console app"
/* git status
git add .
git commit -m "Initial project setup with user management console app"
*/