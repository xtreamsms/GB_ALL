int i = 5;
int j = 10;
int max = 0;
int min = 0;

if (i > j)
{
    max = i;
    min = j;
}   
else
{
    max = j;
    min = i;
}

Console.WriteLine ("min: " + min + "max: " + max);