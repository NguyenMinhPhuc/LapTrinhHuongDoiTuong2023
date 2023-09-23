### 1. Lớp con kết thừa từ lớp cha
```Csharp
public class LopCha{
    public virtual void Method(){
        Console.Write("phuong thuc lop cha")
    }
}
public class LopCon:LopCha{
    public override void Method(){
        Console.Write("Phuong thuc lap con")
    }
}
```
### 2. lớp con kết thừa từ lớp cha trừu tượng
```Csharp
public abstract class LopCha{
    public abstract void Method();

    public void Method2(){
        Console.Write("PT khong Truu tuong")
    }
}

public class LopCon:LopCha{
    public override void Method(){
        Console.WriteLine("day la lop con");
    }
}
```

### 3. Dùng interface cho cha và con kế thừa từ interface

```Csharp
public interface ILopCha{
    void Method();
    int Method2(int a, int b);
}
public class LopCon:ILopCha{
    public void Method(){

    }

    public int Method2(int a, int b){
        return a+b;
    }

    public void Method3(){
        
    }
}
```