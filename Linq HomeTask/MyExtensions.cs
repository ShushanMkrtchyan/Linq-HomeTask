using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Linq_HomeTask
{
    static class MyExtensions
    {
        public static IEnumerable<T> GetWhereCondition<T>(this IEnumerable<T> collection, Predicate<T>predicate)
        {
            foreach(T item in collection)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> MySkipWhile<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            bool flag = true;

            foreach(T item in collection)
            {
                if (!predicate(item))
                {
                    flag = false;
                }
                else
                {
                    continue;
                }
                yield return item ;
            }
        }

        public static IEnumerable<T> MyExcept<T>(this IEnumerable<T> colfirst, IEnumerable<T> colsecond)
        {
            foreach(T item in colfirst)
            {
                if (colsecond.Contains(item))
                {
                    continue;
                }
                
                yield return item;
                              
            }
        }
        public static IEnumerable<T> MySingle<T>(this IEnumerable<T> collection, Predicate <T> predicate)
        {
            foreach(T item in collection)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static bool MyAll <T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            bool flag = true;

            foreach (T item in collection)
            {
                if (!predicate(item))
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
          
        }

        public static bool MyAny<T>(this IEnumerable<T>collection, Predicate<T> predicate)
        {
            bool flag = true;
            foreach(T item in collection)
            {
                if (predicate(item))
                {
                    flag = true;
                    break;
                    
                }
                else
                {
                    flag = false;
                }
                
            } return flag;
           
        }
    }
}
