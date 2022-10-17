using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static partial class ExtensionMethods
{
    public static IEnumerable<T> EachDistinct<T>(this IEnumerable<T> source)
    {
        if (!source.Any())
            yield break;

        T prev = source.First();
        yield return prev;
        foreach (var item in source)
        {
            if (!Equals(item, prev))
            {
                yield return item;
                prev = item;
            }
        }
    }
}

