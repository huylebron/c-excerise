namespace BasicExcerise_full.baiTapLesson9T3h ;

public class Teacher : Person
{

    public string Subject  { get ; set ; }
    public Teacher ( string name , int age  , string subject ) : base ( name , age ) {

        this . Subject = subject ;
        
    }

    public override void PrintDetails ( ) {
        Console.WriteLine($" nameTeacher : {Name} , ageTeacher : {Age} , subject : {Subject}");
    }
}