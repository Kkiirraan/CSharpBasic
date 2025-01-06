using System;
using System.Net.Security;
using System.Text.RegularExpressions;


namespace Name{

   interface Rectangle{
    int show();
   }
   interface Circle{
    int show();
   }
   class Shape:Rectangle,Circle{
     int Rectangle.show(){
        return 22;
    }
     int Circle.show(){
        return 23;
    }
   }

    public class Name{
        public static void Main(string[] args){
            Circle shape=new Shape();
            Console.WriteLine(shape.show());
           
        }
    }
}
