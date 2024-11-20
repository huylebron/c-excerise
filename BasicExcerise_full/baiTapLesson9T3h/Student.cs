namespace BasicExcerise_full.baiTapLesson9T3h ;

public class Student : Person
{
    public int  StudentId { get ; set ; }
    public Student ( string name , int age , int studentId ) : base ( name , age ) {
        
        StudentId = studentId ;
        
    }

    public override void PrintDetails ( ) {
      Console.WriteLine($" nameStudent : {Name} , ageStudent : {Age} , studentId : {StudentId}");
    }
    
    public void Study ( ) {
        
        Console.WriteLine("Student is studying");
    }
    
    
}