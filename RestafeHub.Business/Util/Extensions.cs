using RestafeHub.Business.Abstraction.Common;
using System.Linq.Expressions;

namespace RestafeHub.Business.Util
{
    internal static class Extensions
    {
        public static IQueryable<T> ApplyFilters<T>(this IQueryable<T> query, List<FilterCondition> filters)
        {
            foreach (var filter in filters)
            {
                var parameter = Expression.Parameter(typeof(T), "x");
                var member = Expression.PropertyOrField(parameter, filter.Property);
                var constant = Expression.Constant(Convert.ChangeType(filter.Value, member.Type));

                Expression body = filter.Operator switch
                {
                    ">" => Expression.GreaterThan(member, constant),
                    "<" => Expression.LessThan(member, constant),
                    ">=" => Expression.GreaterThanOrEqual(member, constant),
                    "<=" => Expression.LessThanOrEqual(member, constant),
                    "=" => Expression.Equal(member, constant),
                    "!=" => Expression.NotEqual(member, constant),
                    ":" => Expression.Call(member, "Contains", null, constant),
                    _ => throw new NotSupportedException($"Operator {filter.Operator} not supported")
                };

                var lambda = Expression.Lambda<Func<T, bool>>(body, parameter);
                query = query.Where(lambda);
            }

            return query;
        }
    }
}
