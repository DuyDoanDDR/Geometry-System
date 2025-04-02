using System.ComponentModel.DataAnnotations;

public class Shaped
{
    private string color = "green";
    private bool filled = true;
    public Shaped()
    {
        
    }
    public Shaped(String color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }
    public string Color 
    {
        get { return color; }
        set { color = value; }
    }
    public bool Filled 
    { 
        get { return filled; }
        set { filled = value; }
    }
    public override string ToString()
    {
        return "A Shape with color of " + Color + " and " + (Filled ? " filled":" not filled");
    }
   

}
public class Circle : Shaped
{
    private double radius = 1.0;
    public Circle() { }
    public Circle(double radius, string color, bool filled) : base(color, filled)
    {
        this.radius = radius;
    }
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }
    public double GetArea()
    {
        return radius * radius * Math.PI;
    }
    public double GetPerimeter()
    {
        return radius * 2 * Math.PI;
    }
    public override string ToString()
    {
        return "A circle with radius = " + Radius + " which is a subclass of " + base.ToString();
    }
}
public class Rectangle : Shaped
{
    private double width = 1.0;
    private double length = 1.0;
    public Rectangle() { }
    public Rectangle(double width, double length, string color, bool filled):base(color, filled)
    {
        this.width = width;
        this.length = length;
    }
    public double Width
    { 
      get { return width; } 
      set { width = value; } 
    }
    public double Length
    {
        get { return length; }
        set { length = value; }
    }
    public override string ToString()
    {
        return "A rectangle with width " + Width + " and length " + Length + " which is a subclass of " + base.ToString();
    }
}
public class Squared : Rectangle
{
    private double side = 1.0;
    public Squared() 
    { }
    public Squared (double side):base(side, side, "white", false)
    { }
    public Squared(double side, String color, bool filled):base(side,side,color, filled)
    { }
    public double Side
    {
        get { return side; }
        set { side = value; }
    }
    public override string ToString()
    {
        return "A squared with size " + Side + ", which is a subclass of " + base.ToString();
    }
   


}
public class Program
{
     public static void Main(string[] args)
    {
        Squared squared = new Squared();
        Console.WriteLine(squared);
        squared = new Squared(2.3);
        Console.WriteLine(squared);
        squared = new Squared(5.8, "yellow", true);
        Console.WriteLine(squared);

    }
}