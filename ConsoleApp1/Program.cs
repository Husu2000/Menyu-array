string[] names = new string[] 
{    "Ibo",
    "Cavad",
    "Maqa",
    "Ekber" };

int select = 0;
do 
{
    Console.Clear();
    for (int i = 0; i < names.Length; i++) 
    {
        bool ischek = false;
        if (select == i)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"--> {names[i]} ");
            Console.ForegroundColor = ConsoleColor.White;
            ischek = true; 
        }
        if (!ischek)
            Console.WriteLine(names[i]);





    }  
  ConsoleKeyInfo info = Console.ReadKey();
    if (info.Key == ConsoleKey.UpArrow || info.Key ==ConsoleKey.W)
    {
        if(select == 0) { select = 3; }
        else select--;
    }
    else if (info.Key == ConsoleKey.DownArrow || info.Key == ConsoleKey.S)
    {
        if (select == 3) { select = 0; }
        else select++;
    
    }
    if (info.Key == ConsoleKey.Enter) 
    {
    
    }

}
while (true);
