using System;

class Program
{
    static void Main(string[] args)
    {
        float productCountForPromotion1 = float.Parse(Console.ReadLine());
        float discountPercentagePromotion2 = float.Parse(Console.ReadLine());
        float netPricePromotion1 = productCountForPromotion1/(productCountForPromotion1 + 1);
        float netPricePromotion2 = (100 - discountPercentagePromotion2)/100;
        if(netPricePromotion1 < netPricePromotion2)
        {
            Console.WriteLine("Lapee");
        }
        else if(netPricePromotion1 > netPricePromotion2)
        {
            Console.WriteLine("Shopzada");
        }
        else
        {
            Console.WriteLine("E-mazon");
        }
    }
}