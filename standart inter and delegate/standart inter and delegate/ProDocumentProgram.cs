﻿namespace ConsoleApp11;

public class ProDocumentProgram:DocumentProgram
{
    public sealed override void EditDocument()
    {
        Console.WriteLine("Document Edited");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
    }
}

