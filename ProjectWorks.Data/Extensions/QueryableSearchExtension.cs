using System.Collections.Generic;
using System.Linq.Expressions;
using ProjectWorks.Data;



namespace System.Linq {
	public static class QueryableSearchExtension {
		public static IQueryable<TEntity> Search<TEntity>(this IQueryable<TEntity> source, IEnumerable<KeyValuePair<String, String>> filters) {
			if (filters == null || filters.Count() == 0) {
				return source;
			}

			var entity = Expression.Parameter(typeof(TEntity), "m");
			var conditions = new List<Expression>();

			// Iterate fields
			foreach (var filter in filters) {
				try {
					// Create lambda expression "m.Property.DeepProperty"
					var property = ExpressionUtils.GetProperty(entity, filter.Key);
					var propertyValue = ExpressionUtils.GetNormalized(property);

					// Create lambda expression "value.ToUpper()"
					var search = Expression.Constant(filter.Value.TrimStart('!'));
					var searchValue = ExpressionUtils.GetNormalized(search);

					// Create lambda expression "m.PropertyName.ToUpper().Contains(value.ToUpper())"
					var contains = Expression.Call(propertyValue, "Contains", null, searchValue);

					// Create lambda expression "m.PropertyName.ToString().ToUpper().Contains(value.ToUpper()) == (true|false)"
					var condition = Expression.Equal(contains, filter.Value[0] == '!' ? Expression.Constant(false) : Expression.Constant(true));

					// Add resulter expression o expressions list
					conditions.Add(condition);
				} catch {
				}
			}

			// Check if have any conditions
			if (conditions.Count > 0) {
				// Combine all conditions together
				var predicateBody = conditions.Skip(1).Aggregate(conditions.FirstOrDefault(), (a, b) => Expression.Or(a, b));

				// Create predicate
				var predicate = Expression.Lambda<Func<TEntity, Boolean>>(predicateBody, entity);

				// Apply where clause
				return source.Where(predicate);
			}

			return source;
		}
	}
}
