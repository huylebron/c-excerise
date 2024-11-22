namespace BasicExcerise_full.array ;
/// <summary>
/// Cho mảng số nguyên A[] gồm N phần tử, nhiệm vụ của bạn là in ra các phần tử là số chẵn ở chỉ số chẵn, nếu mảng không tồn tại phần tử như vậy thì in ra "NONE".
/// </summary>
public class SoChanVaChiSoChan
{

    public static void Main1 ( string [ ] args ) {
        
        Console . Write ( "Nhap so phan tu cua mang: " ) ;
        int n = int . Parse ( Console . ReadLine ( ) ) ;
        
        int [ ] a = new int [ n ] ;
        
        for ( int i = 0 ; i < n ; i ++ )
        {
            Console . Write ( $"a[{i}] = " ) ;
            a [ i ] = int . Parse ( Console . ReadLine ( ) ) ;
        }
        
        PrintEvenNumberAtEvenIndex ( a ) ;
        
        
    }
    
    public static void PrintEvenNumberAtEvenIndex ( int [ ] a ) {
        
        for ( int i = 0 ; i < a . Length ; i ++ )
        {
            if ( i % 2 == 0 && a [ i ] % 2 == 0 )
            {
                Console . WriteLine ( a [ i ] ) ;
            }
            else
            {
                Console . WriteLine ( "NONE" ) ;
            }
        }
        
        
    }
    
}