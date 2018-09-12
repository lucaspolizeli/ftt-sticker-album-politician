using System;
using System.Collections.Generic;
using System.Linq;

namespace AlbumFigPoliticos.Generics
{
    public static class IEnumerableExtensions
    {
        public static T Random<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }
            var r = new Random();
            var list = enumerable as IList<T> ?? enumerable.ToLinkedList();
            return list.Count == 0 ? default(T) : list[r.Next(0, list.Count)];
        }

        public static LinkedList<T> ToLinkedList<T>(this IEnumerable<T> enumerable)
            => (enumerable == null) ?
                throw new ArgumentNullException(nameof(enumerable)) :
                new LinkedList<T>(enumerable.ToArray());
    }
}