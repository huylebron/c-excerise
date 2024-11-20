namespace BasicExcerise_full.baiTapLesson9T3h ;

public class Program
{

    public static void Main1 ( string [ ] args ) {
        Student stu = new Student ( "huy " , 10 , 42 ) ;
        Teacher tea = new Teacher ( "hong " , 40 , "phisic" ) ;
        stu . PrintDetails ( ) ;
        tea . PrintDetails ( ) ;
        stu . Study ( ) ;
        Console . ReadKey ( ) ;
    }
    
}