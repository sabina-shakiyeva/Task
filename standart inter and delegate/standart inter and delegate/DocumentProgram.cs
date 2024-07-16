﻿namespace ConsoleApp11;

public class DocumentProgram
{
    public void OpenDocument()
    {
        Console.WriteLine("Document Opened");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Can Edit in Pro and Expert versions\r\n");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Can Save in Pro and Expert versions");
    }
}
