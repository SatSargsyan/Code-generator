# Const vs readonly

<h3>The value in a const variable is what's called a "compile-time" value, and is immutable (which means it does not change over 
the life of the program).
<p>
<a href=https://www.exceptionnotfound.net/const-vs-static-vs-readonly-in-c-sharp-applications>Only <b> primitive or "built-in" C# types</b> (e.g. int, string, double) are allowed to be declared const. </a>
Therefore, we <b> cannot write </b>either of these:</p></h3>
```C#
public const DateTime DeclarationOfIndependence = new DateTime(1776,7,4);  
public const MyClass MyValue = new Class() {Name = "TestName"};
```

<h3>A readonly field is one where assignment to that field can only occur as part of the declaration of the class or in a constructor.
</h3>

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
<h2>his means that a readonly variable can have different values for different constructors in the same class</h2>





<h4>The readonly keyword is different from the const keyword. A const field can only be initialized at the declaration of the field.
A readonly field can be initialized either at the declaration or in a constructor. Therefore, readonly fields can have different
values depending on the constructor used. Also, while a const field is a compile-time constant, the readonly field can be used 
for runtime constants as in the following example:</h4>

```C#
public static readonly uint l1 = (uint) DateTime.Now.Ticks;
```
<h4>Use static readonly when you have a variable of a type that you cannot know at runtime (objects) that you want all instances
or consumers of a class to have access to where the value should not change.
Use readonly when you have an instance level variable you will know at the time of object creation that should not change.</h4>

<h4>There is a minor difference between const and static readonly fields in C#.Netconst must be initialized with value
at compile time. 
const is by default static and needs to be initialized with constant value, which can not be modified later on. 
It can not be used with all datatypes. For ex- DateTime. It can not be used with DateTime datatype.</h4>
```C#
public const DateTime dt = DateTime.Today;  //throws compilation error
public const string Name = string.Empty;    //throws compilation error
public static readonly string Name = string.Empty; //No error, legal
```
<h4>readonly can be declared as static, but not necessary. No need to initialize at the time of declaration. 
Its value can be assigned or changed using constructor once. So there is a possibility to change value of readonly field 
once (does not matter, if it is static or not), which is not possible with const.</h4>


