public class bot
{
    char[,] botField = new char[9,11];
    Random rand = new Random();
    int randX, randY;
    public void FillField()
    {
        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 11; j++)
            {
                botField[i,j] = '*';
            }
        }
    }
    public void ShowField()
    {
        Console.WriteLine("\\| 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10| 11|");
        Console.WriteLine("-+-------------------------------------------|");
        for(int i = 0; i < 9; i++)
        {
            Console.Write($"{i+1}|");
            for(int j = 0; j < 11; j++)
            {
                Console.Write($" {botField[i,j]} |");                
            }
            Console.WriteLine();
            Console.WriteLine("-|---|---|---|---|---|---|---|---|---|---|---|");
        }
    }
    void SetAllBoats()
    {
        SetBoatsOne();
        SetBoatsTwo();
        SetBoatsThree();
        SetBoatsCorner();
    }
    public void SetBoatsOne()
    {
        int k = 0;
        while(k < 4)
        {
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 11; j++)
                {
                    randX = rand.Next(0, 12);
                    randY = rand.Next(0, 10);
                    if(Check3x3())
                    {
                        botField[randX,randY] = '#';
                    }
                }
            }
            k++;
        }
    }
    void  SetBoatsTwo()
    {

    }
    void  SetBoatsThree()
    {
        
    }
    void  SetBoatsCorner()
    {
        
    }
    
    bool Check3x3()
    {
        for(int i = randX; i < randX + 4; i++)
        {
            for(int j = randY; j < randY + 4; j++)
            {
                if(botField[i,j] == '#')
                {
                    return false;
                }
            } 
        }
        return true;
    }
}