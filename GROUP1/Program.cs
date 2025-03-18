using System.Security;

bot bot1 = new bot();
bool GameStatus = true;

void Game()
{
    GameStatus = true;
    ShowPlayerField();
    PlayerBoatsSetup();

    while(GameStatus)
    {
        ShowPlayerField();

        try
        {
            while(true)
            {
                Console.WriteLine("Choose the cell Cords ");
                Console.Write("Position X: ");
                PosX = int.Parse(Console.ReadLine());
                Console.Write("Position Y: ");
                PosY = int.Parse(Console.ReadLine());

                if(cells[PosY - 1, PosX - 1].symbol != '#')
                {
                    Console.WriteLine("Cell has already exist !");
                } else
                {
                    break;
                }

            }

            Winner_Condition();

        }catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Set position inside the field !");
        }catch(FormatException)
        {
            Console.WriteLine("Please write correct numbers !");
        }
    }
}