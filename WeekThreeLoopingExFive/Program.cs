

// Exercise 5 
// Write an application named DisplayMultiplicationnTable that prompts the user for an integer value, for example 7.
// Then display the product of every integer from 1 through 10 when multiplied by the entered value.
// For example, the first three lines of the table might read:

class DisplayMultiplicationnTable
{
    static void Main()
    {
        int count = 1;
        int userNum = 0;
        int product = 0;

        Console.WriteLine("Please enter an integer below: ");
        userNum = Convert.ToInt32(Console.ReadLine());

        for (count = 1; count < 11; count++)
        {
            product = userNum * count;
            Console.WriteLine("{0} X {1}", count, userNum);
            Console.WriteLine(product);
        }
    }
}