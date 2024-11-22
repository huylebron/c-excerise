namespace BasicExcerise_full.array ;
 /// <summary>
///
/// Cho mảng số nguyên A[] gồm N phần tử cách nhau bởi khoảng trắng, hãy tìm độ chênh lệch nhỏ nhất giữa 2 phần tử trong mảng.
/// </summary>
public class differenceCoupleNumber
{

    public static void Main ( string [ ] args ) {
        
    
        int n = int . Parse ( Console . ReadLine ( ) ) ;


        int [ ] a = Console . ReadLine ( ) . Split ( ' ' ) . Select ( int . Parse ) . ToArray ( ) ;
        
        
        Console . WriteLine ( FindMinDifference ( a ) ) ;
        Console . ReadKey ( ) ;

    }
    
    public static int FindMinDifference ( int [ ] a ) {
        
        int min = Math . Abs ( a [ 0 ] - a [ 1 ] ) ;
        
        for ( int i = 0 ; i < a . Length - 1 ; i ++ )
        {
            for ( int j = i + 1 ; j < a . Length ; j ++ )
            {
                if ( Math . Abs ( a [ i ] - a [ j ] ) < min )
                {
                    min = Math . Abs ( a [ i ] - a [ j ] ) ;
                }
            }
        }
        
        return min ;
    }
    
    
}