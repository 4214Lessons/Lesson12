// using System.Linq;
// Linq



using Models;
using static System.Console;

namespace Lesson12_3;






static class ExtensionMethods
{
    public static void Print<T>(this IEnumerable<T> collection)
    {
        foreach (var item in collection)
            WriteLine(item);
    }
}




class Program
{
    static void Main()
    {
        List<int> numbers = new() { 3, 7, 4, 346, 4, 65 };

        var students = Student.GetStudents();


        //numbers = numbers.Distinct().ToList();

        //foreach (var n in numbers)
        //    WriteLine(n);



        // numbers.Distinct().Print();



        // numbers.FindAll(n => n % 2 == 0).Print();



        // students.FindAll(s => s.Score > 10).Print();


        // students.Select(s => s.Name).Print();
        // students.Select(s => s.Score).Print();
        // students.Select(s => $"{s.Name} {s.Surname}").Print();

        // students.Select(s => (s.Name, s.Surname, s.Score)).Print();



        // Func<Student, string?> f = s => s.Name;
        // students.Select(f).Print();
        // students.Select(f).Print();
        // students.Select(f).Print();
        // students.Select(f).Print();



        // WriteLine(students.Count(s => s.Score > 10));
        // WriteLine(students.Sum(s => s.Score));
        // WriteLine(students.Max(s => s.Score));
        // WriteLine(students.Min(s => s.Score));
        // WriteLine(students.Average(s => s.Score));



        // numbers = new List<int>();
        // students = new List<Student>();



        // WriteLine(students.First());
        // WriteLine(students.FirstOrDefault());


        // WriteLine(numbers.Single());

        // WriteLine(students.Single(s => s.Score > 10));
        // WriteLine(students.SingleOrDefault(s => s.Score > 10));



        // students
        //     .Skip(2)
        //     .Take(3)
        //     .Print();




        // students
        //     .SkipWhile(s=> s.Score > 10)
        //     .Take(3)
        //     .Print();



        // students.ForEach(s => s.Id += 10);
        // students.ForEach(s => WriteLine(s));




        // students
        //     .Where(s => s.Name?.Length <= 5)
        //     // .OrderBy(s=>s.Score) // ASC
        //     .OrderByDescending(s => s.Score)
        //     .Take(3)
        //     .ToList()
        //     .ForEach(s => WriteLine(s));



    }
}