using System;

public class Document
{
    public Document()
    {

    }

    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public int Name { get; set; }
    public int Description { get; set; }
    public int Category { get; set; }

    public bool Upload()
    {
        return 0;
    }

    public bool Download(int id)
    {
        return 0;
    }
}
