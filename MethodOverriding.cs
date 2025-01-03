using System;


// example of method overriding



namespace OOPS{
    
    class Parent{
        public virtual void show(){
            Console.WriteLine("Parent");
        } 
  }
  class Child:Parent{
        public override void show()
        {
            Console.WriteLine("child");
        }
    }
    public class Program{
        public static void Main(string[] args)
        {
          Parent obj1=new Parent();
          obj1.show();

          Parent obj2=new Child();
          obj2.show();

          Child obj3=new Child();
          obj3.show();
        }
    }

}
