using RestafeHub.Abstraction.Common;
using System.Linq.Expressions;

namespace RestafeHub.Abstraction.Util
{
    public static class QueryableComparableExtensions
    {
        public static IQueryable<T> ApplyComparableFilter<T, TFilter>(this IQueryable<T> query, TFilter filter)
        {
            if (filter == null) return query;

            var entityType = typeof(T);
            var filterType = typeof(TFilter);
            var parameter = Expression.Parameter(entityType, "x");

            foreach (var filterProp in filterType.GetProperties())
            {
                var filterValue = filterProp.GetValue(filter);
                if (filterValue == null) continue;

                var filterTypeDef = filterProp.PropertyType;
                if (!filterTypeDef.IsGenericType || filterTypeDef.GetGenericTypeDefinition() != typeof(Comparable<>))
                    continue;

                var op = filterTypeDef.GetProperty("Operator")?.GetValue(filterValue) as string;
                var val = filterTypeDef.GetProperty("Value")?.GetValue(filterValue);
                if (string.IsNullOrWhiteSpace(op) || val == null)
                    continue;

                var entityProp = entityType.GetProperty(filterProp.Name);
                if (entityProp == null) continue; // property name mismatch

                var left = Expression.Property(parameter, entityProp);
                var right = Expression.Constant(val, entityProp.PropertyType);

                Expression condition = op.ToLower() switch
                {
                    "eq" => Expression.Equal(left, right),
                    "ne" => Expression.NotEqual(left, right),
                    "gt" => Expression.GreaterThan(left, right),
                    "gte" => Expression.GreaterThanOrEqual(left, right),
                    "lt" => Expression.LessThan(left, right),
                    "lte" => Expression.LessThanOrEqual(left, right),

                    // short versions
                    "c" or "contains" when entityProp.PropertyType == typeof(string) =>
                        Expression.Call(left, nameof(string.Contains), null, right),

                    "nc" or "notcontains" when entityProp.PropertyType == typeof(string) =>
                        Expression.Not(Expression.Call(left, nameof(string.Contains), null, right)),

                    "sw" or "startswith" when entityProp.PropertyType == typeof(string) =>
                        Expression.Call(left, nameof(string.StartsWith), null, right),

                    "ew" or "endswith" when entityProp.PropertyType == typeof(string) =>
                        Expression.Call(left, nameof(string.EndsWith), null, right),

                    _ => throw new NotSupportedException($"Unsupported operator '{op}' for property '{filterProp.Name}'")
                };

                var lambda = Expression.Lambda<Func<T, bool>>(condition, parameter);
                query = query.Where(lambda);
            }

            return query;
        }
    }
}
