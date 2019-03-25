using System.Collections.Generic;
using System.Linq.Expressions;
using ProjectWorks.Data;



namespace System.Linq {
	public static class QueryableWhereExtension {
		public static IQueryable<TEntity> Where<TEntity>(this IQueryable<TEntity> source, Dictionary<String, String> filters) {
			if (filters == null || filters.Keys.Count == 0) {
				return source;
			}

			var entity = Expression.Parameter(typeof(TEntity), "m");
			var conditions = new List<Expression>();

			// Iterate fields
			foreach (var filter in filters) {
				try {
					// Add resulter expression to expressions list
					conditions.Add(GetCondition(entity, filter));
				} catch {
				}
			}

			// Check if have any conditions
			if (conditions.Count > 0) {
				// Combine all conditions together
				var predicateBody = conditions.Skip(1).Aggregate(conditions.FirstOrDefault(), (a, b) => Expression.And(a, b));

				// Create predicate
				var predicate = Expression.Lambda<Func<TEntity, Boolean>>(predicateBody, entity);

				// Apply where clause
				return source.Where(predicate);
			}

			return source;
		}



		private static Expression GetCondition(Expression entity, KeyValuePair<String, String> filter) {
			// Define list of allowed operators
			var operators = new List<String> { ">=", "<=", ">", "<", "!?", "!", "?" };

			// Initialize value
			var @operator = String.Empty;
			var value = filter.Value;

			// Iterate allowed operators
			foreach (var entry in operators) {
				// Check if value contains operator
				if (value.StartsWith(entry)) {
					// Store operator
					@operator = entry;

					// Remove operator
					value = value.TrimStart(entry.ToCharArray());
				}
			}

			// Create lambda expression "m.Property.DeepProperty"
			var property = ExpressionUtils.GetProperty(entity, filter.Key);

			// Try convert value type
			Expression search;

			// Try substitute some keywords
			switch (value.Trim().ToLowerInvariant()) {
				case "null":
					search = Expression.Constant(null);
					break;

				case "now":
					search = Expression.Constant(DateTime.Now);
					break;

				case "empty":
					search = Expression.Empty();
					break;

				case "default":
					search = Expression.Default(property.Type);
					break;

				default:
					if (property.Type.IsEnum) {
						search = Expression.Constant(Enum.Parse(property.Type, value, true));
					} else {
						search = Expression.Constant(Convert.ChangeType(value, property.Type));
					}
					break;
			}

			// Return required expression
			switch (@operator) {
				case ">=":
					return Expression.GreaterThanOrEqual(property, search);

				case "<=":
					return Expression.LessThanOrEqual(property, search);

				case ">":
					return Expression.GreaterThan(property, search);

				case "<":
					return Expression.LessThan(property, search);

				case "!?":
					return Expression.NotEqual(
						Expression.Call(
							ExpressionUtils.GetNormalized(property),
							"Contains",
							null,
							ExpressionUtils.GetNormalized(
								Expression.Constant(value)
							)
						),
						Expression.Constant(true)
					);

				case "!":
					return Expression.NotEqual(property, search);

				case "?":
					return Expression.Call(
						ExpressionUtils.GetNormalized(property),
						"Contains",
						null,
						ExpressionUtils.GetNormalized(Expression.Constant(value))
					);

				default:
					return Expression.Equal(property, search);
			}
		}
	}
}
