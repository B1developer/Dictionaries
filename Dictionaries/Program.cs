class Program
{
    static void Main()
    {
        #region Creating and initializing a dictionary
        // Creating a dictionary to store player names and their scores

        Dictionary<string, int> playerScores = new Dictionary<string, int>();

        // Adding elements to the Dictionary
        playerScores.Add("Alice", 50);
        playerScores.Add("Bob", 40);
        playerScores.Add("Charlie", 30);
        playerScores.Add("Dave", 20);

        // Displaying the elements in the dictionary
        Console.WriteLine("Player Scores: ");
        foreach (KeyValuePair<string, int> kvp in playerScores)
        {
            Console.WriteLine("Player: " + kvp.Key + ", Score: " + kvp.Value);
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////

        #region Accessing and modifying dictionary elements
        Dictionary<string, int> playerScores1 = new Dictionary<string, int>
        {
            {"Alice", 50 },
            {"Bob", 40 },
            {"Charlie", 30 },
            {"Dave", 20 }
        };

        // Accessing a value using the key

        int aliceScore = playerScores1["Alice"];
        Console.WriteLine("Alice's score: " + aliceScore); // Output: 50

        // Modifying a value using the key
        playerScores1["Bob"] = 45; // Bob's new score

        // Displaying the updated dictionary
        Console.WriteLine("\nUpdated player scores: ");

        foreach (KeyValuePair<string, int> kvp in playerScores1)
        {
            Console.WriteLine("Player: " + kvp.Key + ", Score: " + kvp.Value);
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////

        #region Adding and removing elements
        Dictionary<string, int> playerScores2 = new Dictionary<string, int>
        {
            {"Alice", 50 },
            {"Bob", 45 },
            {"Charlie", 30 },
            {"Dave", 20 }
        };

        // Adding a new Player
        if (!playerScores2.ContainsKey("Eve"))
        {
            playerScores2.Add("Eve", 35);
        }

        // Removing a player
        playerScores2.Remove("Charlie");

        // Displaying the updated dictionary

        Console.WriteLine("\nPlayer scores after modifications:");
        foreach (KeyValuePair<string, int> kvp in playerScores2)
        {
            Console.WriteLine("Player: " + kvp.Key + ", Score: " + kvp.Value);
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////

        #region Common dictionary methods and properties

        Dictionary<string, int> playerScores3 = new Dictionary<string, int>
        {
            {"Alice", 50 },
            {"Bob", 45 },
            {"Eve", 35 },
            {"Dave", 20 }

        };
        // Checking if a key exists

        bool hasCharlie = playerScores3.ContainsKey("Charlie");
        Console.WriteLine("\nDictionary contains 'Charlie': " + hasCharlie); // Output: false

        // Safely trying to get a value
        if (playerScores3.TryGetValue("Bob", out int bobScore))
        {
            Console.WriteLine("Bob's score: " + bobScore); // Output: 45
        }

        // Getting the total count of elements
        Console.WriteLine("Number of player: " + playerScores3.Count); // Output: 4

        // Displaying all keys and values separately
        Console.WriteLine("All player names: " + string.Join(", ", playerScores3.Keys));
        Console.WriteLine("All scores: " + string.Join(", ", playerScores3.Values));

        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////

        #region Challenge: Create a Contact Book
        Dictionary<string, string> contactBook = new Dictionary<string, string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nContact Book Menu: ");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Search Contact");
            Console.WriteLine("3. Display All Contacts");
            Console.WriteLine("4. Remove Contact");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AddContact(contactBook);
            }
            else if (choice == "2")
            {
                SearchContact(contactBook);
            }
            else if (choice == "3")
            {
                DisplayContacts(contactBook);
            }
            else if (choice == "4")
            {
                RemoveContact(contactBook);
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Exiting the Contact Book. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }

            static void AddContact(Dictionary<string, string> contactBook)
            {
                Console.Write("Enter contact Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter contact Number: ");
                string number = Console.ReadLine();

                contactBook[name] = number; // Simply add or update the contact
                Console.WriteLine("Contact added.");

            }

            static void SearchContact(Dictionary<string, string> contactBook)
            {
                Console.WriteLine("Enter contact name to Search: ");
                string name = Console.ReadLine();

                if (contactBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} - {contactBook[name]}");

                }
                else
                {
                    Console.WriteLine("Contact not found");

                }
            }

            static void DisplayContacts(Dictionary<string, string> contactBook)
            {
                Console.WriteLine("All Contacts: ");
                foreach (var contact in contactBook)
                {
                    Console.WriteLine($"{contact.Key} - {contact.Value}");
                }
            }

            static void RemoveContact(Dictionary<string, string> contactBook)
            {
                Console.WriteLine("Enter contact name to remove: ");
                string name = Console.ReadLine();

                if (contactBook.ContainsKey(name))
                {
                    contactBook.Remove(name);
                    Console.WriteLine("Contact removed.");

                }
                else
                {
                    Console.WriteLine("Contact not found.");
                }
            }
            #endregion

        }
    }
}