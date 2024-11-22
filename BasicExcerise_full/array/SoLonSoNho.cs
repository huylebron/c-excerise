namespace BasicExcerise_full.array ;
/// <summary>
/// Cho mảng số nguyên A[] gồm N phần tử và số nguyên X , hãy đếm xem trong mảng có bao nhiêu số lớn hơn X và bao nhiêu số nhỏ hơn X.

//Đầu vào
//Dòng đầu tiên là số nguyên dương N

//Dòng thứ 2 gồm N số nguyên viết cách nhau một vài khoảng trắng

  //  Dòng thứ 3 là số nguyên X

//Giới hạn
//1<=N<=1000

    //-10^3<=A[i]<=10^3

//Đầu ra
//Dòng 1 in ra các số nhỏ hớn X, dòng 2 in ra các số lớn hơn X
/// </summary>
public class SoLonSoNho
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
        Console . Write ( "Nhap so nguyen X: " ) ;
        int x = int . Parse ( Console . ReadLine ( ) ) ;

        var countGreaterThanX = a.Count(num => num > x);
        var countLessThanX = a.Count(num => num < x);

        Console.WriteLine(countGreaterThanX);
        Console.WriteLine(countLessThanX);

        Console.ReadKey();

        Console . ReadKey ( ) ;

    }

    public int CountNumber ( int [ ] a , int x  ) {

        int count1 = 0 ;

        int count2 = 0 ;
        
        
        

        for ( int i = 0 ; i < a.Length ; i ++ )
        {
            if ( a[i] > x )
            {
                count1 ++ ;
            }
            else if ( a[i] < x )
            {
                count2 ++ ;
            }
        }

        return count1 ;
        return count2 ; 
    }
    
    
    
}