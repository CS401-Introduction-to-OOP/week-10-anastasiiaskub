namespace week10CS401;

class Program
{
    static void Main(string[] args)
    {
        Party myParty = new Party();
        myParty.AddCharacter(new Character{ Name = "Lisa", Gold = 300, HP = 45, Level = 7, Role = "magician", Status = "active"});
        myParty.AddCharacter(new Character{ Name = "Anastasiia", Gold = 100, HP = 70, Level = 6, Role = "archer", Status = "offline"});
        myParty.AddCharacter(new Character{ Name = "Masha", Gold = 400, HP = 10, Level = 10, Role = "military", Status = "active"});

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("choose what do you want");
            Console.WriteLine("1. show all characters");
            Console.WriteLine("2. show only active characters");
            Console.WriteLine("3. who is in crutial situation");
            Console.WriteLine("4. sort by gold");
            Console.WriteLine("5. average level ");
            Console.WriteLine("0. exit");

            string choice = Console.ReadLine();
            if (choice == "0")
            {
                isRunning = false;
            }
            else if (choice == "1")
            {
                foreach (var character in myParty)
                {
                    Console.WriteLine(character.Name + character.Role);
                }
                
            }
            else if (choice == "2")
            {
                foreach (var character in myParty.GetActiveCharacter())
                {
                    Console.WriteLine(character.Name + " is ready for battle");

                }
                
            }
            else if (choice == "3")
            {
                foreach (var character in myParty.GetWoundedMembers(30))
                {
                    Console.WriteLine(character.Name + " is wounded");
                }
            }
            else if (choice == "4")
            {
                var sorted = from character in myParty
                    orderby character.Gold descending
                    select character;
                    
                foreach (var character in sorted)
                {
                    Console.WriteLine(character.Name +" "+ character.Gold + " gold");

                }
            }
            else if (choice == "5")
            {
                var allLevels = from character in myParty
                    select character.Level;
                double avg = allLevels.Average(); 
                Console.WriteLine("average level:" + avg);
                
            }
            else
            {
                Console.WriteLine("invalid command");
            }
            

            
        }
    }
}