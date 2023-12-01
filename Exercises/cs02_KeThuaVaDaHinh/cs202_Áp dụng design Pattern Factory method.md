# Bài tập về design pattern Factory Method trong C#

## Bài tập 1: Xây dựng một ứng dụng đơn giản quản lý hình học. Sử dụng Factory Method để tạo ra các đối tượng hình học (hình vuông, hình chữ nhật, hình tròn) và tính diện tích của từng hình.

```csharp
using System;

public interface IShape
{
    double CalculateArea();
}

public class Square : IShape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double CalculateArea()
    {
        return side * side;
    }
}

public class Rectangle : IShape
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
}

public class Circle : IShape
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
}

public abstract class ShapeFactory
{
    public abstract IShape CreateShape();
}

public class SquareFactory : ShapeFactory
{
    private double side;

    public SquareFactory(double side)
    {
        this.side = side;
    }

    public override IShape CreateShape()
    {
        return new Square(side);
    }
}

public class RectangleFactory : ShapeFactory
{
    private double length;
    private double width;

    public RectangleFactory(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override IShape CreateShape()
    {
        return new Rectangle(length, width);
    }
}

public class CircleFactory : ShapeFactory
{
    private double radius;

    public CircleFactory(double radius)
    {
        this.radius = radius;
    }

    public override IShape CreateShape()
    {
        return new Circle(radius);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ShapeFactory factory = new SquareFactory(5);
        IShape shape = factory.CreateShape();
        Console.WriteLine("Area of Square: " + shape.CalculateArea());

        factory = new RectangleFactory(4, 6);
        shape = factory.CreateShape();
        Console.WriteLine("Area of Rectangle: " + shape.CalculateArea());

        factory = new CircleFactory(3);
        shape = factory.CreateShape();
        Console.WriteLine("Area of Circle: " + shape.CalculateArea());
    }
}
```

## Bài tập 2: Xây dựng một ứng dụng quản lý việc tạo đối tượng Employee trong một công ty. Sử dụng Factory Method để tạo ra các đối tượng Employee (Developer, Manager, Tester) dựa trên thông tin đầu vào.

```csharp
using System;

public abstract class Employee
{
    public string Name { get; set; }
    public abstract void PrintRole();
}

public class Developer : Employee
{
    public override void PrintRole()
    {
        Console.WriteLine("Developer");
    }
}

public class Manager : Employee
{
    public override void PrintRole()
    {
        Console.WriteLine("Manager");
    }
}

public class Tester : Employee
{
    public override void PrintRole()
    {
        Console.WriteLine("Tester");
    }
}

public abstract class EmployeeFactory
{
    public abstract Employee CreateEmployee();
}

public class DeveloperFactory : EmployeeFactory
{
    public override Employee CreateEmployee()
    {
        return new Developer();
    }
}

public class ManagerFactory : EmployeeFactory
{
    public override Employee CreateEmployee()
    {
        return new Manager();
    }
}

public class TesterFactory : EmployeeFactory
{
    public override Employee CreateEmployee()
    {
        return new Tester();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        EmployeeFactory factory = new DeveloperFactory();
        Employee employee = factory.CreateEmployee();
        employee.PrintRole();

        factory = new ManagerFactory();
        employee = factory.CreateEmployee();
        employee.PrintRole();

        factory = new TesterFactory();
        employee = factory.CreateEmployee();
        employee.PrintRole();
    }
}
```

## Bài tập 3: Xây dựng một ứng dụng quản lý đọc sách từ các định dạng khác nhau (PDF, EPUB, MOBI). Sử dụng Factory Method để tạo ra các đối tượng đọc sách cho từng định dạng và thực hiện một tác vụ đọc sách cơ bản.

```csharp
using System;

public interface IBookReader
{
    void OpenBook();
    void ReadBook();
    void CloseBook();
}

public class PDFReader : IBookReader
{
    public void OpenBook()
    {
        Console.WriteLine("Opening PDF book...");
    }

    public void ReadBook()
    {
        Console.WriteLine("Reading PDF book...");
    }

    public void CloseBook()
    {
        Console.WriteLine("Closing PDF book...");
    }
}

public class EPUBReader : IBookReader
{
    public void OpenBook()
    {
        Console.WriteLine("Opening EPUB book...");
    }

    public void ReadBook()
    {
        Console.WriteLine("Reading EPUB book...");
    }

    public void CloseBook()
    {
        Console.WriteLine("Closing EPUB book...");
    }
}

public class MOBIReader : IBookReader
{
    public void OpenBook()
    {
        Console.WriteLine("Opening MOBI book...");
    }

    public void ReadBook()
    {
        Console.WriteLine("Reading MOBI book...");
    }

    public void CloseBook()
    {
        Console.WriteLine("Closing MOBI book...");
    }
}

public abstract class BookReaderFactory
{
    public abstract IBookReader CreateReader();
}

public class PDFReaderFactory : BookReaderFactory
{
    public override IBookReader CreateReader()
    {
        return new PDFReader();
    }
}

public class EPUBReaderFactory : BookReaderFactory
{
    public override IBookReader CreateReader()
    {
        return new EPUBReader();
    }
}

public class MOBIReaderFactory : BookReaderFactory
{
    public override IBookReader CreateReader()
    {
        return new MOBIReader();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BookReaderFactory factory = new PDFReaderFactory();
        IBookReader reader = factory.CreateReader();
        reader.OpenBook();
        reader.ReadBook();
        reader.CloseBook();

        factory = new EPUBReaderFactory();
        reader = factory.CreateReader();
        reader.OpenBook();
        reader.ReadBook();
        reader.CloseBook();

        factory = new MOBIReaderFactory();
        reader = factory.CreateReader();
        reader.OpenBook();
        reader.ReadBook();
        reader.CloseBook();
    }
}
```

## Bài tập 4: Xây dựng một ứng dụng quản lý sản phẩm trong một cửa hàng. Sử dụng Factory Method để tạo ra các đối tượng sản phẩm (điện thoại, máy tính, máy ảnh) và thực hiện một số thao tác quản lý cơ bản.

```csharp
using System;

public interface IProduct
{
    void DisplayInfo();
}

public class Phone : IProduct
{
    public void DisplayInfo()
    {
        Console.WriteLine("This is a phone.");
    }
}

public class Computer : IProduct
{
    public void DisplayInfo()
    {
        Console.WriteLine("This is a computer.");
    }
}

public class Camera : IProduct
{
    public void DisplayInfo()
    {
        Console.WriteLine("This is a camera.");
    }
}

public abstract class ProductFactory
{
    public abstract IProduct CreateProduct();
}

public class PhoneFactory : ProductFactory
{
    public override IProduct CreateProduct()
    {
        return new Phone();
    }
}

public class ComputerFactory : ProductFactory
{
    public override IProduct CreateProduct()
    {
        return new Computer();
    }
}

public class CameraFactory : ProductFactory
{
    public override IProduct CreateProduct()
    {
        return new Camera();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ProductFactory factory = new PhoneFactory();
        IProduct product = factory.CreateProduct();
        product.DisplayInfo();

        factory = new ComputerFactory();
        product = factory.CreateProduct();
        product.DisplayInfo();

        factory = new CameraFactory();
        product = factory.CreateProduct();
        product.DisplayInfo();
    }
}
```


## Bài tập 5: Xây dựng một ứng dụng quản lý giao dịch tài chính. Sử dụng Factory Method để tạo ra các đối tượng giao dịch (Mua, Bán, Trả góp) và thực hiện các thao tác liên quan đến giao dịch.

```csharp
using System;

public interface ITransaction
{
    void Process();
}

public class BuyTransaction : ITransaction
{
    public void Process()
    {
        Console.WriteLine("Processing Buy transaction...");
    }
}

public class SellTransaction : ITransaction
{
    public void Process()
    {
        Console.WriteLine("Processing Sell transaction...");
    }
}

public class InstallmentTransaction : ITransaction
{
    public void Process()
    {
        Console.WriteLine("Processing Installment transaction...");
    }
}

public abstract class TransactionFactory
{
    public abstract ITransaction CreateTransaction();
}

public class BuyTransactionFactory : TransactionFactory
{
    public override ITransaction CreateTransaction()
    {
        return new BuyTransaction();
    }
}

public class SellTransactionFactory : TransactionFactory
{
    public override ITransaction CreateTransaction()
    {
        return new SellTransaction();
    }
}

public class InstallmentTransactionFactory : TransactionFactory
{
    public override ITransaction CreateTransaction()
    {
        return new InstallmentTransaction();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TransactionFactory factory = new BuyTransactionFactory();
        ITransaction transaction = factory.CreateTransaction();
        transaction.Process();

        factory = new SellTransactionFactory();
        transaction = factory.CreateTransaction();
        transaction.Process();

        factory = new InstallmentTransactionFactory();
        transaction = factory.CreateTransaction();
        transaction.Process();
    }
}
```

## Bài tập 6: Xây dựng một ứng dụng quản lý nhà hàng. Sử dụng Factory Method để tạo ra các đối tượng món ăn (Món chính, Món phụ, Tráng miệng) và thực hiện các thao tác quản lý đặt hàng.

```csharp
using System;

public interface IFoodItem
{
    void Display();
}

public class MainDish : IFoodItem
{
    public void Display()
    {
        Console.WriteLine("This is a main dish.");
    }
}

public class SideDish : IFoodItem
{
    public void Display()
    {
        Console.WriteLine("This is a side dish.");
    }
}

public class Dessert : IFoodItem
{
    public void Display()
    {
        Console.WriteLine("This is a dessert.");
    }
}

public abstract class FoodItemFactory
{
    public abstract IFoodItem CreateFoodItem();
}

public class MainDishFactory : FoodItemFactory
{
    public override IFoodItem CreateFoodItem()
    {
        return new MainDish();
    }
}

public class SideDishFactory : FoodItemFactory
{
    public override IFoodItem CreateFoodItem()
    {
        return new SideDish();
    }
}

public class DessertFactory : FoodItemFactory
{
    public override IFoodItem CreateFoodItem()
    {
        return new Dessert();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        FoodItemFactory factory = new MainDishFactory();
        IFoodItem foodItem = factory.CreateFoodItem();
        foodItem.Display();

        factory = new SideDishFactory();
        foodItem = factory.CreateFoodItem();
        foodItem.Display();

        factory = new DessertFactory();
        foodItem = factory.CreateFoodItem();
        foodItem.Display();
    }
}
```

## Bài tập 7: Xây dựng một ứng dụng quản lý đơn hàng trực tuyến. Sử dụng Factory Method để tạo ra các đối tượng phương thức thanh toán (Thẻ tín dụng, PayPal, Ngân lượng) và thực hiện các thao tác thanh toán.

```csharp
using System;

public interface IPaymentMethod
{
    void ProcessPayment();
}

public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing credit card payment...");
    }
}

public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing PayPal payment...");
    }
}

public class NganLuongPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing Ngan Luong payment...");
    }
}

public abstract class PaymentMethodFactory
{
    public abstract IPaymentMethod CreatePaymentMethod();
}

public class CreditCardPaymentFactory : PaymentMethodFactory
{
    public override IPaymentMethod CreatePaymentMethod()
    {
        return new CreditCardPayment();
    }
}

public class PayPalPaymentFactory : PaymentMethodFactory
{
    public override IPaymentMethod CreatePaymentMethod()
    {
        return new PayPalPayment();
    }
}

public class NganLuongPaymentFactory : PaymentMethodFactory
{
    public override IPaymentMethod CreatePaymentMethod()
    {
        return new NganLuongPayment();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        PaymentMethodFactory factory = new CreditCardPaymentFactory();
        IPaymentMethod paymentMethod = factory.CreatePaymentMethod();
        paymentMethod.ProcessPayment();

        factory = new PayPalPaymentFactory();
        paymentMethod = factory.CreatePaymentMethod();
        paymentMethod.ProcessPayment();

        factory = new NganLuongPaymentFactory();
        paymentMethod = factory.CreatePaymentMethod();
        paymentMethod.ProcessPayment();
    }
}
```
