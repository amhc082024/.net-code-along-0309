namespace _net_code_along_0309;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    
        int myNumber = 1;
        Console.WriteLine(myNumber);

        string greeting = ("Hola");
        Console.WriteLine(greeting);

        double MyDouble = 1.11;
        Console.WriteLine(MyDouble);

        char MyChar = 'C';
        Console.WriteLine(MyChar);

        int[] MyNumSeries = [10, 20, 40, 90];
        Console.WriteLine(MyNumSeries);
        for(int i=0; i<MyNumSeries.Length; i=i+1)
        {
            Console.WriteLine(MyNumSeries[i]);

        }

        foreach (int item in MyNumSeries)
        {
            Console.WriteLine(item);
        }






        
    }
}
