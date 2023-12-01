# Bài tập thực hành phần Class và Object

### Bài tập 1: Tạo lớp hình chữ nhật và tính diện tích và chu vi của nó.
```csharp
class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

// Hướng dẫn cách khai báo đối tượng
Rectangle rectangle = new Rectangle();
rectangle.Width = 5;
rectangle.Height = 3;
double area = rectangle.CalculateArea(); // Kết quả: 15
double perimeter = rectangle.CalculatePerimeter(); // Kết quả: 16
```

### Bài tập 2: Tạo lớp học sinh và tính điểm trung bình của học sinh đó.
```csharp
class Student
{
    public string Name { get; set; }
    public int[] Grades { get; set; }

    public double CalculateAverageGrade()
    {
        double sum = 0;
        foreach (int grade in Grades)
        {
            sum += grade;
        }
        return sum / Grades.Length;
    }
}

// Hướng dẫn cách khai báo đối tượng:
Student student = new Student();
student.Name = "John Doe";
student.Grades = new int[] { 85, 90, 92, 88, 95 };
double averageGrade = student.CalculateAverageGrade(); // Kết quả: 90
```

### Bài tập 3: Tạo lớp xe và tính tổng quãng đường đã đi dựa trên các lần di chuyển.
```csharp
class Car
{
    private double totalDistance;

    public void Move(double distance)
    {
        totalDistance += distance;
    }

    public double GetTotalDistance()
    {
        return totalDistance;
    }
}

// Hướng dẫn các khai báo đối tượng:
Car car = new Car();
car.Move(10.5);
car.Move(7.2);
double totalDistance = car.GetTotalDistance(); // Kết quả: 17.7
```

### Bài tập 4: Tạo lớp ngân hàng và thực hiện các giao dịch rút và gửi tiền.
```csharp
class Bank
{
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
    }

    public double GetBalance()
    {
        return balance;
    }
}

// Hướng dẫn các khai báo đối tượng:
Bank bank = new Bank();
bank.Deposit(100);
bank.Withdraw(50);
double balance = bank.GetBalance(); // Kết quả: 50
```
### Bài tập 5: Tạo lớp điện thoại di động và thực hiện cuộc gọi và nhắn tin.
```csharp
class MobilePhone
{
    public void MakeCall(string phoneNumber)
    {
        // Thực hiện cuộc gọi đến số điện thoại được chỉ định
    }

    public void SendTextMessage(string phoneNumber, string message)
    {
        // Gửi tin nhắn đến số điện thoại được chỉ định với nội dung tin nhắn được chỉ định
    }
}

// Hướng dẫn các khai báo đối tượng:
MobilePhone phone = new MobilePhone();
phone.MakeCall("0123456789");
phone.SendTextMessage("0123456789", "Xin chào!");
```

### Bài tập 6: Tạo lớp sách và thực hiện tính năng đọc sách và đặt dấu trang.
```csharp
class Book
{
    private int currentPage;

    public void ReadPage()
    {
        currentPage++;
        // Hiển thị nội dung trang hiện tại
    }

    public void SetBookmark()
    {
        // Đặt dấu trang tại trang hiện tại
    }
}

// Hướng dẫn các khai báo đối tượng:
Book book = new Book();
book.ReadPage();
book.ReadPage();
book.SetBookmark();
```

### Bài tập 7: Tạo lớp đèn và thực hiện tính năng bật/tắt đèn.
```csharp
class Light
{
    private bool isOn;

    public void TurnOn()
    {
        isOn = true;
        // Bật đèn
    }

    public void TurnOff()
    {
        isOn = false;
        // Tắt đèn
    }

    public bool IsOn()
    {
        return isOn;
    }
}

// Hướng dẫn các khai báo đối tượng:
Light light = new Light();
light.TurnOn();
bool isLightOn = light.IsOn(); // Kết quả: true
light.TurnOff();
isLightOn = light.IsOn(); // Kết quả: false
```

### Bài tập 8: Tạo lớp hình tròn và tính diện tích và chu vi của nó.
```csharp
class Circle
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

// Hướng dẫn các khai báo đối tượng:
Circle circle = new Circle();
circle.Radius = 3.5;
double area = circle.CalculateArea(); // Kết quả: khoảng 38.48
double perimeter = circle.CalculatePerimeter(); // Kết quả: khoảng 21.99
```

### Bài tập 9: Tạo lớp nhân viên và tính tổng lương nhân viên dựa trên mức lương và số giờ làm việc.
```csharp
class Employee
{
    public string Name { get; set; }
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}

// Hướng dẫn các khai báo đối tượng:
Employee employee = new Employee();
employee.Name = "Jane Doe";
employee.HourlyRate = 20;
employee.HoursWorked = 40;
double salary = employee.CalculateSalary(); // Kết quả: 800
```

### Bài tập 10: Tạo lớp đường và tính khoảng cách giữa hai điểm trên đường.
```csharp
class Road
{
    public double Distance { get; set; }

    public double CalculateDistanceBetweenPoints(double point1, double point2)
    {
        return Math.Abs(point1 - point2) * Distance;
    }
}

// Hướng dẫn các khai báo đối tượng:
Road road = new Road();
road.Distance = 100;
double distanceBetweenPoints = road.CalculateDistanceBetweenPoints(50, 30); // Kết quả: 2000
```

> Lưu ý những bài tập trên chỉ là code minh họa. Sinh viên hay hoàn thiện code cho những bài tập trên để có được chương trình hoàn chỉnh nhất.