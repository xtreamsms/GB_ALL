int i = int.Parse(Console.ReadLine());
int j = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

int max = i;

    if(j > max)
    {
        max = j;
    }
    
    if(z > max)
    {
        max = z;
    }

    Console.WriteLine(max);
