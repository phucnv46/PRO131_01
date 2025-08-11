using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PRO131_01.Extentions
{
    public static class FilterExtention // tạo static class
    {
        public static ICollection<T> TimKiem<T>(this ICollection<T> source,
           string search) // Extention method
        {

            var stringProperties = typeof(T).GetProperties().Where(prop => prop.PropertyType == typeof(string)); // lấy các thuộc tính


            string filterExp = string.Join(" || ", stringProperties.Select(p => $"{p.Name}.Contains(@0,StringComparison.CurrentCultureIgnoreCase)"));


            return source.AsQueryable().Where(filterExp, search).ToList();

        }

        public static List<T> Loc<T>(this ICollection<T> source, params Expression<Func<T, bool>>[] predicates)
        {
            var query = source.AsQueryable();
            foreach (var pre in predicates)
            {
                query = query.Where(pre);
            }

            return query.ToList();
        }

        public static List<T> Loc<T>(this ICollection<T> source, params string[] predicates)
        {
            var query = source.AsQueryable();
            foreach (var pre in predicates)
            {
                query = query.Where(pre);
            }

            return query.ToList();
        }

    }
}
