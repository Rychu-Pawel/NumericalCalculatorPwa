using System.Collections.Generic;

namespace NumericalCalculatorPwa.Extensions
{
    public static class ListExtensions
    {
        public static List<T> Populate<T>(this List<T> list) where T : new()
        {
            for (int i = 0; i < list.Count; i++)
                list[i] = new T();

            return list;
        }
    }
}