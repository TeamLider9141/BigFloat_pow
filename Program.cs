using System;
using static System.Math;

using System.Numerics;

namespace acmp1
{
    public class Program
    {
        static void Main(string[] args)   // pow(n,a) , pow(a,b)  BigFloat, BigDouble, BigDecimal,  BigInteger   a Degree b 
        {

            BigInteger s=1;   

            BigInteger n = BigInteger.Parse(Console.ReadLine());    // sonni kiritamiz :   input = a 
            BigInteger a = BigInteger.Parse(Console.ReadLine());    // darajani kiritamiz:   input = b 

            for (int i=1; i<=n; i++)  // sikl orqali qayta-qayta darajaga ko'taramiz  
            {
                 s = s * a;
            }
            Console.WriteLine(s);  //    output:  s=  pow(n,a)  

        }

    }
}