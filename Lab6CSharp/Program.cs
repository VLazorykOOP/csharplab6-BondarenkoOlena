namespace Lab6CSharp
{
    internal class Program
    {
        interface IUserInterface
        {
            void Display();
        }
        interface IDotNetInterface
        {
            void Method();
        }
        class Person
        {
            protected string name;
            protected int age;
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public virtual void Show()
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
        }
        class Student : Person, IUserInterface
        {
            private string studentID;
            public Student(string name, int age, string studentID) : base(name, age)
            {
                this.studentID = studentID;
            }
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"Student ID: {studentID}");
            }
            public void Display()
            {
                Console.WriteLine("Student Interface Display Method");
            }
        }
        class Teacher : Person, IDotNetInterface
        {
            private string subject;
            public Teacher(string name, int age, string subject) : base(name, age)
            {
                this.subject = subject;
            }
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"Subject: {subject}");
            }
            public void Method()
            {
                Console.WriteLine("Teacher .NET Method");
            }
        }
        class DepartmentChair : Person, IUserInterface, IDotNetInterface
        {
            private string department;
            public DepartmentChair(string name, int age, string department) : base(name, age)
            {
                this.department = department;
            }
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"Department: {department}");
            }
            public void Display()
            {
                Console.WriteLine("Department Chair Interface Display Method");
            }
            public void Method()
            {
                Console.WriteLine("Department Chair .NET Method");
            }
        }
        static void task1()
        {
            Student student = new Student("Olena Bondarenko", 20, "S12345");
            Teacher teacher = new Teacher("Taras Panchenko", 35, "Mathematics");
            DepartmentChair chair = new DepartmentChair("Kateryna Cherkas", 45, "Computer Science");

            Console.WriteLine("Student Information:");
            student.Show();
            student.Display();

            Console.WriteLine("\nTeacher Information:");
            teacher.Show();
            teacher.Method();

            Console.WriteLine("\nDepartment Chair Information:");
            chair.Show();
            chair.Display();
            chair.Method();
        }
        interface IFigure
        {
            double CalculateArea(); 
            double CalculatePerimeter(); 
            void DisplayInfo();
        }
        class Rectangle : IFigure
        {
            private double length;
            private double width;
            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }
            public double CalculateArea()
            {
                return length * width;
            }
            public double CalculatePerimeter()
            {
                return 2 * (length + width);
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Rectangle - Length: {length}, Width: {width}, Area: {CalculateArea()}, Perimeter: {CalculatePerimeter()}");
            }
        }
        class Circle : IFigure
        {
            private double radius;
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public double CalculateArea()
            {
                return Math.PI * radius * radius;
            }
            public double CalculatePerimeter()
            {
                return 2 * Math.PI * radius;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Circle - Radius: {radius}, Area: {CalculateArea()}, Circumference: {CalculatePerimeter()}");
            }
        }
        class Triangle : IFigure
        {
            private double sideA;
            private double sideB;
            private double sideC;
            public Triangle(double sideA, double sideB, double sideC)
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
            public double CalculateArea()
            {
                double s = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            }
            public double CalculatePerimeter()
            {
                return sideA + sideB + sideC;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Triangle - Side A: {sideA}, Side B: {sideB}, Side C: {sideC}, Area: {CalculateArea()}, Perimeter: {CalculatePerimeter()}");
            }
        }
        static void task2()
        {
            IFigure[] figures = new IFigure[3];
            figures[0] = new Rectangle(5, 4);
            figures[1] = new Circle(3);
            figures[2] = new Triangle(3, 4, 5);

            foreach (var figure in figures)
            {
                figure.DisplayInfo();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 5 ");
            Console.Write("Enter task number: ");
            int task_id = int.Parse(Console.ReadLine());
            switch (task_id)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                default:
                    Console.WriteLine("No task under such number!");
                    break;
            }
        }
    }
}
