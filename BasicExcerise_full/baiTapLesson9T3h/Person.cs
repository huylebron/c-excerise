namespace BasicExcerise_full.baiTapLesson9T3h ;

public class Person
{
    public string Name { get ; set ; }
    public int  Age { get ; set ; }

    public Person ( string name , int age ) {
        Name = name ;
        Age = age ;
    }


   virtual public void PrintDetails ( ) {
        
        Console.WriteLine($"name : {Name} , age : {Age}");
        
        
    }
}