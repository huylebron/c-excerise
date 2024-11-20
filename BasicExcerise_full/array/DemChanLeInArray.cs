namespace BasicExcerise_full.array ;

public class DemChanLeInArray
{
   

    public static void Main1 ( string [ ] args ) {

        int n = int . Parse ( Console . ReadLine ( ) ) ;
        int [] a = new int [ n ] ;

        for ( int i = 0 ; i <= n ; i ++ )
        {
             a [ i ] = int . Parse ( Console . ReadLine ( ) ) ;
        }

        int chan = 0 ;
       int  SChan = 0 ;
       int Sle = 0 ; 
        int le = 0 ;

        for ( int i = 0 ; i <= n ; i ++ )
        {
            if ( a [ i ] % 2 == 0 )
            {
                chan ++ ;
                SChan += a [ i ] ;
            }
            else
            {
                le ++ ;
                Sle += a [ i ] ;
                
            }
        }
        
        Console.WriteLine($"chan : {chan} , tong chan : {SChan}");
        Console.WriteLine($" le : {le} , tong le : {Sle}");
        Console . ReadKey ( ) ;



    }
}