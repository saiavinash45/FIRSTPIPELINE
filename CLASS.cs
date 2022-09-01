using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class student
{
    public int id;
    public string name;
    public void insert(int i, string n)
    {
        id = i;
        name = n;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name);
    }
}
class TestStudent
{
    public static void Main(string[] args)
    {
        student s1 = new student();
        student s2 = new student();
        s1.insert(101, "Nitin");
        s2.insert(102, "Thomar");
        s1.display();
        s2.display();
        Console.ReadLine();
    }
}

