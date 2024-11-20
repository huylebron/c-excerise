namespace BasicExcerise_full.Collection ;
/// <summary>
/// Yêu cầu: Tạo một List<int> chứa các số nguyên từ 1 đến 10. In tất cả các phần tử ra màn hình.
//Thực hành thêm:
//Thêm một phần tử vào cuối danh sách.
 // Xóa một phần tử theo chỉ số.
//  Tìm và hiển thị chỉ số của một phần tử cụ thể.
/// </summary>


public class BaiTapList
{
  public static List < int > CreateList ( ) {

    List < int > num = new List < int > ( ) ;
    for ( int i = 0 ; i <= 10 ; i ++ )
    {
        num.Add ( i );
    }

    return num ;
  }

  public static void PrintList ( List < int > number )      
      => number . ForEach ( x => Console . WriteLine (number + "" ) ) ;


  public void AddElement ( List < int > number , int element ) 
  {
      number . Add ( element ) ;
      PrintList ( number ) ;
  }

  public void RemoveElement ( List < int > number , int index ) {
      
        number . RemoveAt ( index ) ;
        PrintList ( number ) ;
  }




  public void findelementIndex ( List < int > number , int element ) {

      int index = number . IndexOf ( element ) ;
        Console . WriteLine ( "Index of element {0} is {1}" , element , index ) ;
        
  }

  public static void Main1 ( ) {

      List < int > number = new List < int > ( ) ;
      number = CreateList ( ) ;
        PrintList ( number ) ;
        BaiTapList btl = new BaiTapList ( ) ;
        btl.AddElement ( number , 11);
        btl . RemoveElement ( number , 5 ) ;
        btl . findelementIndex ( number , 7 ) ;

        Console . ReadKey ( ) ;
        

  }
      
      
    
}