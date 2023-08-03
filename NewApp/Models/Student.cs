namespace NewApp.Models
{
    public class Student
    {
        public string StudentName { get; set; }
        public int StudentID { get; set; }
        
        public void Du()
        {
            System.Console.Write("StudentName: ");
            StudentName = Console.ReadLine();

            System.Console.Write("StudentID: ");
            StudentID = Convert.ToInt16(Console.ReadLine());
            
        }
        public void In()
        {
            System.Console.WriteLine("{0} - {1}", StudentName, StudentID);
        }
    }
}