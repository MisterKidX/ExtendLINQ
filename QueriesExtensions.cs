using System.Collections.Generic;
using System.Linq;

public static class LINQExtensions
{

    // TODO: Using orderby is too slow, need to find the number manually with an iterator
    public static float GetClosestNumber(this IEnumerable<float> collection, float number)
    {
        return collection
            .OrderBy(n => System.Math.Abs(n - number))
            .First();
    }
}
