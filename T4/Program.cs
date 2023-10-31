//ایلیا اصغرحری
//تمرین چهارم


long x = -1, y = 1;

Console.WriteLine("How many Fibonacci numbers?(to sentence 94)");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The last number is your answer");
for (int i = 0; i < number; i++)
{
    long anw = y + x;
    x = y; y = anw;


    Console.WriteLine(anw);

}



