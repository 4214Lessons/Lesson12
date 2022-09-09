namespace Models;

public class Student
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Surname { get; set; }
	public double Score { get; set; }
	public DateOnly BirthDate { get; set; }


	public static List<Student> GetStudents() => new List<Student>
	{
		new(){ Id = 1, Name = "Vasif", Surname = "Babazade", Score = 10.4, BirthDate = new(2000, 1, 2) },
		new(){ Id = 2, Name = "Tural", Surname = "Haci-nebili", Score = 10.5, BirthDate = new(2000, 1, 2) },
		new(){ Id = 3, Name = "Elshad", Surname = "Hesenov", Score = 7.4, BirthDate = new(2000, 1, 2) },
		new(){ Id = 4, Name = "Kamran", Surname = "Kerimzade", Score = 11.4, BirthDate = new(2000, 1, 2) },
		new(){ Id = 5, Name = "Kenan", Surname = "Muradov", Score = 11.9, BirthDate = new(2000, 1, 2) },
		new(){ Id = 6, Name = "Ali", Surname = "Shamilzade", Score = 11.8, BirthDate = new(2000, 1, 2) },
		new(){ Id = 7, Name = "Leyla", Surname = "Shefiyeva", Score = 12, BirthDate = new(2000, 1, 2) },
		new(){ Id = 8, Name = "Isa", Surname = "Memmedli", Score = 9.5, BirthDate = new(2000, 1, 2) }
	};

	public override string ToString() => $@"
Id: {Id}
Name: {Name}
Surname: {Surname}
Score: {Score}
BirthDate: {BirthDate.ToShortDateString()}";

}