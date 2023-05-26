using System;
using System.Collections.Generic;

public class CouponNumbers
{
    public static int GenerateDistinctCouponNumbers(int numDistinctCoupons)
    {
        HashSet<int> distinctCoupons = new HashSet<int>();

        Random random = new Random();
        int attempts = 0;

        while (distinctCoupons.Count < numDistinctCoupons)
        {
            int randomCoupon = random.Next(1, numDistinctCoupons + 1);
            attempts++;

            distinctCoupons.Add(randomCoupon);
        }

        return attempts;
    }
}
