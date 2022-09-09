namespace Lesson12_2;

// Discard

class Program
{
    static int GetValue() => 42;
    static (int, bool, string) GetTuple() => (10, true, "Hello");


    static void Main()
    {
        _ = 10;
        _ = true;
        _ = "str";
        _ = new int[] { 1, 5, 2 };


        _ = GetValue();



        (int n, bool b, _) = GetTuple();
    }
}