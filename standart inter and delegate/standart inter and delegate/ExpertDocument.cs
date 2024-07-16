namespace ConsoleApp11;

public class ExpertDocument:ProDocumentProgram
{
    public sealed override void SaveDocument()
    {
        Console.WriteLine("Document Saved in pdf format");
    }

}
