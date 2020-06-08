using System.Collections.Generic;

namespace NumericalCalculatorPwa.Extensions
{
    public static class ListExtensions
    {
        public static List<T> Populate<T>(this List<T> list, int count) where T : new()
        {
            for (int i = 0; i < count; i++)
                list.Add(new T());

            return list;
        }
    }
}