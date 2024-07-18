using System.Collections.Generic;

public struct Root
{
    public List<ActiveButtons> ActiveButtons { get; set; }

    public int Count { get; set; }
}

public struct ActiveButtons
{
    public string Name { get; set; }

    public string FullName { get; set; }

    public int SizeName { get; set; }

    public int SizeFullName { get; set; }

    public string Link { get; set; }
}