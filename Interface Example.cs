using System;

//hacktoberfest
interface I1
{

 void method1( );
    
    
    
}

interface I2 : I1
{
 void method2( );

    
}

public abstract class Class1 : I2
{
    
 public    void method1( ){
 Console.WriteLine("I am from interface I1"); 
 Console.WriteLine("Method 1 from interface I1");
}
  public void method2( ){
 Console.WriteLine("I am from interface I2");   
}
public abstract void method3( );
}


public class InterfaceExample2 : Class1
{

public  override void method3( ){
    
 Console.WriteLine("I am from abstract class");   
    
}

public static void Main(string[] args)
{
    
    InterfaceExample2 i = new InterfaceExample2();
    i.method1();
    i.method2();
    i.method3();

}

}
