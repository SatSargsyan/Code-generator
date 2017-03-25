# Const vs readonly

<h3>The value in a const variable is what's called a "compile-time" value, and is immutable (which means it does not change over 
the life of the program).
<p>
<a href=https://www.exceptionnotfound.net/const-vs-static-vs-readonly-in-c-sharp-applications>Only <b> primitive or "built-in" C# types</b> (e.g. int, string, double) are allowed to be declared const.</a> 
Therefore, we <b> cannot write </b>either of these:

```C#
public const DateTime DeclarationOfIndependence = new DateTime(1776,7,4);  
public const MyClass MyValue = new Class() {Name = "TestName"};
```

### A readonly field is one where assignment to that field can only occur as part of the declaration of the class or in a constructor.


```C#
public class TestClass  
{
    public readonly string ConnectionString = "TestConnection";

    public TestClass()
    {
        ConnectionString = "DifferentConnection";
    }

    public void TestMethod ()
    {
        ConnectionString = "NewConnection";//Will not compile
    }
}

```

## his means that a readonly variable can have different values for different constructors in the same class</h2>


#### The readonly keyword is different from the const keyword. A const field can only be initialized at the declaration of the field.
A readonly field can be initialized either at the declaration or in a constructor. Therefore, readonly fields can have different
values depending on the constructor used. Also, while a const field is a compile-time constant, the readonly field can be used 
for runtime constants as in the following example:

```C#
public static readonly uint l1 = (uint) DateTime.Now.Ticks;

```
#### Use static readonly when you have a variable of a type that you cannot know at runtime (objects) that you want all instances
or consumers of a class to have access to where the value should not change.
Use readonly when you have an instance level variable you will know at the time of object creation that should not change.

#### There is a minor difference between const and static readonly fields in C#.Netconst must be initialized with value
at compile time. 
const is by default static and needs to be initialized with constant value, which can not be modified later on. 
It can not be used with all datatypes. For ex- DateTime. It can not be used with DateTime datatype.</h4>

```C#
public const DateTime dt = DateTime.Today;  //throws compilation error
public const string Name = string.Empty;    //throws compilation error
public static readonly string Name = string.Empty; //No error, legal

```
<h4>readonly can be declared as static. Its value can be assigned or changed using constructor once, but if it isn't static We  can 
use <b>many constructors, wheras if it static, only one constructor.</b></h4>

```C#
 public class Test
        {
            public readonly int rdOnly = 3;
            public Test(int rdVal)
            {
                rdOnly = rdVal;
                Console.WriteLine(rdOnly);
            }

            public Test()
            {
                rdOnly = 5;
                Console.WriteLine(rdOnly);
            }

            public Test(string s)
            {
                Console.WriteLine(s);
                Console.WriteLine(rdOnly);
            }
            
```
            
<h2>wherefore</h2>
            
```C#
             public static class Test1
            {
                public static readonly int rdOnly1 = 3;
                
                static Test1()
                {
                    rdOnly1 = 15;
                    Console.WriteLine(rdOnly1);
                }
                
```
<h2>because static class can has only one constructor, and
                1. it must be<b> parameterless</b>, 2.it <b> cannot be public</b></h2>
                
                
<h2>There are situations where a const and a non-const have different semantics. For example:</h2>
                
```C#
            const int y = 42;
            static void Main(string[] args)
            { 
                     
            short x = 42;
            Console.WriteLine(x.Equals(y));
            Console.WriteLine(y.Equals(x));
            }
```
 <h2>is true(because const as a string, doesn't create new element), wherfore</h2>
 
```C#
            static readonly int z = 45;
            static void Main(string[] args)
            {
                     
            short t = 45;
            Console.WriteLine(t.Equals(z));  //false
            Console.WriteLine(z.Equals(t));  //true, because the first  parameter is type of <int>
           

            Console.ReadKey();
            }
 ```
 <h2>is false, <a href=https://referencesource.microsoft.com/#mscorlib/system/int32.cs,225942ed7b7a3252>because method equals is true, only it passes int parameter</a></h2>
 
 ```C#
  public override bool Equals(Object obj) {
            if (!(obj is Int32)) {
                return false;
            }
            return m_value == ((Int32)obj).m_value;
        }
 
        [System.Runtime.Versioning.NonVersionable]
        public bool Equals(Int32 obj)
        {
            return m_value == obj;
        }
        
```
            
       
                


