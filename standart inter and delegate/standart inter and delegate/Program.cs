using ConsoleApp11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter choice:basic,pro,expert");
        string word=Console.ReadLine();
        DocumentProgram docProgram;
        if (word == "pro")
        {
             docProgram = new ProDocumentProgram();

        }
        else if(word == "expert") {
             docProgram = new ExpertDocument();
        }
        else 
        {
             docProgram = new DocumentProgram();
        }
        docProgram.OpenDocument();
        docProgram.EditDocument();
        docProgram.SaveDocument();
    }
}