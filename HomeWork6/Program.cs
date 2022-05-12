List<string> classRoster = new List<string>();
string inserts;

do
{
    Console.Write("Enter student name. (type end to quit): ");
    inserts = Console.ReadLine();

    if (inserts != "end")
    {
        classRoster.Add(inserts);
    }
    else if (inserts == "end")
    {
        Console.WriteLine(classRoster.Count + " students in the class.");
    }

} while (inserts != "end");
