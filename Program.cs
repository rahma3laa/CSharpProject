namespace Task_Tracker_Project
{
    internal class Program
    {
        static string[] Tasks = new string[100];
        static int TaskIndex=1;
      
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*Welcome to my To Do List*\n");
            while (true)
            {
                Console.WriteLine("Enter your Choice from 1:5");  
                Console.WriteLine("1. Add");
                Console.WriteLine("2. View");
                Console.WriteLine("3. Complete ");
                Console.WriteLine("4. Remove");
                Console.WriteLine("4. Exit");
                string UserChoice = Console.ReadLine();
                switch (UserChoice)
                {
                    case "1":
                        AddTasks();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        MarkComplete();
                        break;
                    case "4":
                        RemoveTask();
                        break;
                    case "5":
                        Environment.Exit(0);
                        //Exit Loop
                        break;
                    default:
                        Console.WriteLine("Please choose number from 1 : 5 only");
                        break;
                        
                        
                }
                
            }
        }
        private static void AddTasks()
        {
            
            Console.WriteLine("Enter Task Title");
            string TaskTitle = Console.ReadLine();
            Tasks[TaskIndex] = TaskTitle;
            Console.WriteLine("Added Successfully!");
            TaskIndex++; 
        }
        private static void ViewTasks()
        {
            Console.WriteLine("All Tasks:");
            for (int i = 1; i < TaskIndex; i++)
            {
                Console.WriteLine($"{i}. {Tasks[i]}");
            }
        }
        private static void MarkComplete()
        {
            Console.WriteLine("Enter Task Number: ");
            int TaskNumber=int.Parse(Console.ReadLine());
            Tasks[TaskNumber]=Tasks[TaskNumber] + " ---COMPLETED";
        }
        private static void RemoveTask()
        {
            Console.WriteLine("Enter Task Number to delete: ");
            int TaskNumbertodelete=int.Parse(Console.ReadLine());
            Tasks[TaskNumbertodelete] =string.Empty;
        }
    }
}
