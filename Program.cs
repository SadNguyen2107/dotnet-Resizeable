class Program
{
  public static void Main(string[] args)
  {
    IResizeable circle = new Circle(10);
    IResizeable rectangle = new Rectangle(20, 30);
    circle.Resize(2);
    rectangle.Resize(3);
  }
}