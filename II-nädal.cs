
Console.WriteLine("Please, select your gender (m/f):");

    char userGender = Char.Parse(Console.ReadLine()); // loeb konsoolist maha andmeid string (sõne) formaadis 

        if (usergender == 'm')

        {
            Console.WriteLine("Welcome, Mr.!");
        }

        else if (usergender == 'f')

        {
            Console.WriteLine("Welcome, Ms.!");
        }
        else
        {
            Console.WriteLine("Welcome!");
        }