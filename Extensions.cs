using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate bool _Func<in T, out TResult>(T arg);
    public static class Extensions
    {
        public static T _LastOrDefault<T>(this IEnumerable<T> source, _Func<T, bool> func)
        {
            if (source == null) throw new ArgumentNullException();
            if (func == null) throw new ArgumentNullException();
            T result = default(T);
            foreach (T element in source)
            {
                if (func(element))
                {
                    result = element;
                }
            }
            return result;
        }
        public static int _Count<T>(this IEnumerable<T> source, _Func<T, bool> func)
        {
            if (source == null) throw new ArgumentNullException();
            if (func == null) throw new ArgumentNullException();
            int count = 0;
            foreach (T element in source)
            {
                checked
                {
                    if (func(element)) count++;
                }
            }
            return count;
        }
    }
}
