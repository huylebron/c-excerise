using System.Security.Cryptography;

namespace BasicExcerise_full.array
{
    /// <summary>
    ///  Cho mảng số nguyên A[] gồm N phần tử, hãy đếm xem trong mảng của bạn có bao nhiêu số có cùng giá trị nhỏ nhất. Ví dụ mảng A = {1, 2, 1, 3, 5} thì số nhỏ nhất trong mảng là 1 xuất hiện 2 lần.
    /// </summary>
    public class SmallestNumber
    {

        public static (int min , int count )   FindSmallestNumber ( int [ ] a ) {

            int min = a [ 0 ] ;
            int count = 0 ;

            for ( int i = 0 ; i < a . Length ; i ++ )
            {
                if ( a [ i ] < min )
                {
                    min = a [ i ] ;
                    count = 1 ;
                }
                else if ( a [ i ] == min )
                {
                    count ++ ;
                }
                
            }

            return ( min , count ) ;
       
            
        }
        public static void Main1(string[] args)
        {
         
            int n = int.Parse(Console.ReadLine());
            
           
            int[] a = new int[n];
           
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }

           
           var result =  FindSmallestNumber(a);
            Console.WriteLine($"Số nhỏ nhất trong mảng là: {result.min} và xuất hiện {result.count} lần");
            Console . ReadKey ( ) ;
        }
    }
}