namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            double Radius;
            do
            {
                Console.Write("Please Enter radius : ");

            } while (!double.TryParse(Console.ReadLine(), out Radius));
            Circle circleObj = new(Radius);
            double Area = circleObj.GetArea();
            Console.WriteLine($"Area of Circle is : {Area}");
            double Circumference = circleObj.GetCircumference();
            Console.WriteLine($"Circumference of Cirxle is : {Circumference}");


        }
    }
}