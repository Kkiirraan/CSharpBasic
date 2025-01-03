using System;
// example of method hiding

namespace OOPS{
    
  class Parent{
    public void show(){
        Console.WriteLine("Parent");
    }
  }
  class Child:Parent{
    public void show(){
        Console.WriteLine("Child");
    }
  }
    public class Program{
        public static void Main(string[] args)
        {
           Parent obj1=new Parent(); // when both the reference and object are same type
           obj1.show();

           Parent obj2=new Child();  // when reference is different
           obj2.show();

           Child obj3=new Child();
           obj3.show();
        }
    }

}
