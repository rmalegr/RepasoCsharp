internal class Program
{
    private static void Main(string[] args)
    {
        int x;// declaration 
        x = 123;
        int y = 321; //declaration + initialization

        int z = x + y;
        int age = 40;
        double height = 300.5;
        bool alive = true;
        char symbol = '@';

        Console.WriteLine("The result of x + y is =  " + z);
        Console.WriteLine("Your age is " + age);
        Console.WriteLine("Your height  is " + height + " cm" );
        Console.WriteLine("Are you alive ?  " + alive);
        Console.WriteLine("Your symbol prefer " + symbol);

        Console.ReadKey();


    }
}