
public class Record
{
    public string Name { get; set; }


    public Record(string name = "")
    {
        Name = name;
        
    }
}

public class SchoolRecord : Record
{
    public int NumberStudents { get; set; }


    public SchoolRecord(string schoolName = "", int numberStudents = 0)
    {
        int NumberStudents = numberStudents;
        this.Name = schoolName;

    }

}



class Program
{
    static void Main()
    {
        Console.WriteLine("How many records do you want to add? ");

        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<SchoolRecord>();

        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            Console.WriteLine("Enter the name for your record : ");

            var nameRecord = Console.ReadLine();
            
            var myClass = new SchoolRecord(nameRecord);
          
            Console.WriteLine("Enter the number of the students at the school. ");

            myClass.NumberStudents = int.Parse(Console.ReadLine());

            recordList.Add(myClass);
        }

        // Print out the list of records using Console.WriteLine()
       
        foreach (var elem in  recordList)
        {
            Console.WriteLine(elem.Name.ToString());
            Console.WriteLine(elem.NumberStudents.ToString());
        }

    }
}

