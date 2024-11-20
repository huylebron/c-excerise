namespace BasicExcerise_full.array ;

public class CountPrimesInArray
{

    public static bool  isPrimes ( int n ) {

        for ( int i = 2 ; i <= n / 2 ; i ++ )
        {
            if ( n % i == 0 )
            {
                return false ;
            }
            
        }

        return true ;
        
    }
    public static void Main1 ( string [ ] args ) {
        
        int n = int . Parse ( Console . ReadLine ( ) ) ;
        int [] a = new int [ n ] ;
       ;
        for ( int i = 0 ; i < n ; i ++ )
        {
            a [ i ]  = int.TryParse ( Console . ReadLine ( ) , out int result ) ? result : 0 ;
        }

        int average = 0 ;
        
        int count = 0 ;

        for ( int i = 0 ; i <= n ; i ++ )
        {
            if ( isPrimes ( a [ i ] )  ) 
            {
                average += a [ i ] ;
                count ++ ;
            }
        }
        
        average = average / count ;
        Console.WriteLine($"Trung binh cong cua so nguyen to trong mang la : {average}");
        Console . ReadKey ( ) ;
        
    
        
    }
}