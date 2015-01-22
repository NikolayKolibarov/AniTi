using System;


    class AniTi
    {
        static void Main()
        {
            int aniCount;
            Console.WriteLine("Enter count of episodes: ");
            while (!int.TryParse(Console.ReadLine(),out aniCount) || aniCount <= 0)
            {
                Console.WriteLine("Enter possible count: ");
            }
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int aniTime = 20;
            int minutes = aniTime * aniCount;
            double hours = minutes / 60;
            double hoursRemain = minutes % 60;

            Console.WriteLine();
            Console.Beep();
            if (aniCount != 1 && aniCount != 2)
            {
                if (hours > 1)
                {
                Console.WriteLine("Time you need to watch {0} episodes: {1} hours and {2} minutes",aniCount ,hours ,hoursRemain); 
                }

                if (hours == 1)
                {
                    Console.WriteLine("Time you need to watch {0} episodes: {1} hour and {2} minutes", aniCount, hours, hoursRemain);
                }
            }
  
            else
            {
                if (aniCount == 2)
                {
                    Console.WriteLine("Time you need to watch {0} episodes: {1} minutes", aniCount, hoursRemain);
                }
                if (aniCount == 1)
                {
                    Console.WriteLine("Time you need to watch {0} episode: {1} minutes", aniCount, hoursRemain);
                }
            }
            Console.WriteLine("\nKolibarov Soft. \nAll Rights reserved \u00A9");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();

            
        }
    }

