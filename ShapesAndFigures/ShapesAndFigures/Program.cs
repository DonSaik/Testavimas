using System;

namespace ShapesAndFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, widht, radius, height;
            double a, b, c;
            Shape s;
            Figure f;
            int pasirinkimas = -1;
            while (pasirinkimas != 0)
            {
                Console.Write("Pasirinkimas:");
                if (!int.TryParse(Console.ReadLine(), out pasirinkimas))
                {
                    pasirinkimas = -1;
                }
                switch (pasirinkimas)
                {
                    case 1:
                        Console.WriteLine("Circle");
                        Console.Write("Radius:");
                        radius = Convert.ToDouble(Console.ReadLine());
                        s = new Circle(radius);
                        Console.WriteLine("A = " + s.GetArea());
                        Console.WriteLine("P = " + s.GetPerimeter());
                        break;
                    case 2:
                        Console.WriteLine("Pentagon");
                        Console.Write("Lenght:");
                        lenght = Convert.ToDouble(Console.ReadLine());
                        s = new Pentagon(lenght);
                        Console.WriteLine("A = " + s.GetArea());
                        Console.WriteLine("P = " + s.GetPerimeter());
                        break;
                    case 3:
                        Console.WriteLine("Rectangle");
                        Console.Write("Lenght:");
                        lenght = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Width:");
                        widht = Convert.ToDouble(Console.ReadLine()); 
                        s = new Rectangle(lenght, widht);
                        Console.WriteLine("A = " + s.GetArea());
                        Console.WriteLine("P = " + s.GetPerimeter());
                        break;
                    case 4:
                        Console.WriteLine("Triangle");
                        Console.WriteLine("Pirma");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Antra");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Trecia");
                        c = Convert.ToDouble(Console.ReadLine());
                        s = new Triangle(a, b, c);
                        Console.WriteLine("A = "+s.GetArea());
                        Console.WriteLine("P = "+ s.GetPerimeter());
                        break;
                    case 5:
                        Console.WriteLine("Cylinder");
                        Console.Write("Radius:");
                        radius = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Height:");
                        height = Convert.ToDouble(Console.ReadLine());
                        f = new Cylinder(radius, height);
                        Console.WriteLine("A = " + f.GetArea());
                        Console.WriteLine("bP = " + f.GetBasePerimeter());
                        Console.WriteLine("V = " + f.GetVolume());
                        break;
                    case 6:
                        Console.WriteLine("Cone");
                        Console.Write("Radius:");
                        radius = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Height:");
                        height = Convert.ToDouble(Console.ReadLine());
                        f = new Cone(radius, height);
                        Console.WriteLine("A = " + f.GetArea());
                        Console.WriteLine("bP = " + f.GetBasePerimeter());
                        Console.WriteLine("V = " + f.GetVolume());
                        break;
                    case 7:
                        Console.WriteLine("Sphere");
                        Console.Write("Radius:");
                        radius = Convert.ToDouble(Console.ReadLine());
                        f = new Sphere(radius);
                        Console.WriteLine("A = " + f.GetArea());
                        
                        try
                        {
                        Console.WriteLine("bP = " + f.GetBasePerimeter());
                            
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        Console.WriteLine("V = " + f.GetVolume());
                        break;
                    case 8:
                        Console.WriteLine("Regular Pyramid");
                        Console.Write("Lenght:");
                        lenght= Convert.ToDouble(Console.ReadLine());
                        Console.Write("Height:");
                        height = Convert.ToDouble(Console.ReadLine());
                        f = new Pyramid(lenght, height);
                        Console.WriteLine("A = " +f.GetArea());
                        Console.WriteLine("bP = "+ f.GetBasePerimeter());
                        Console.WriteLine("V = " +f.GetVolume());
                        break;
                    case 0:
                        Console.WriteLine("Cya!");
                        break;
                    default:
                        Console.WriteLine("Tokio pasirinkimo nera");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
    
}
