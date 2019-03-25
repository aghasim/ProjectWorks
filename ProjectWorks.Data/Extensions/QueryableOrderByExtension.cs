using System.Collections.Generic;
using System.Linq.Expressions;
using ProjectWorks.Data;
using ProjectWorks.Data.Resources;



namespace System.Linq {
	public static class QueryableOrderByExtension {
		public static IQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, IEnumerable<ResourceParametersSorting> sorting) {
			// Get source expression to apply sorting to
			var expression = source.Expression;

			// Check if have any sorting properties
			if (sorting.Count() > 0) {
				// Initialize succeeded iterations count
				var iterations = 0;

				// Iterate sortable properties
				foreach (var sort in sorting) {
					try {
						// Create lambda parameter by type
						var entity = Expression.Parameter(typeof(TEntity), "m");

						// Create property selector expression "m => m.Property.DeepProperty"
						var property = ExpressionUtils.GetProperty(entity, sort.Property);
						var propertySelector = Expression.Lambda(property, entity);

						// Get the method to call
						var methodName = GetMethodName(sort, iterations == 0);

						// Create array that represents method return type
						var returnType = new Type[] {
						typeof(TEntity),
						property.Type
					};

						// Call ordering method and store returned expression for next iteration
						expression = Expression.Call(typeof(Queryable), methodName, returnType, expression, Expression.Quote(propertySelector));

						// Increment succeeded iterations count
						iterations += 1;
					} catch {
						// If any exception occurs - just ignore and continue to next property
					}
				}

				// Check if any ordering method has been added to default expression
				if (iterations > 0) {
					// Add ordering methods chain to source (source.OrderBy(m => m.Property).ThenBy(m => m.Property.DeepProperty))
					return source.Provider.CreateQuery<TEntity>(expression);
				}
			}

			// Return unchaged source
			return source;
		}



		/// <summary>
		/// Returns sorting method name to be used
		/// </summary>
		/// <param name="sort">Sorting definition</param>
		/// <param name="isFirstCall">
		/// If true - IQueryable (OrderBy, OrderByDescending) sorting methods will be used,
		/// else - methods on IOrderedQueryable (ThenBy, ThenByDescending)</param>
		/// <returns></returns>
		private static String GetMethodName(ResourceParametersSorting sort, Boolean isFirstCall = true) {
			if (sort.Direction.Equals("desc", StringComparison.OrdinalIgnoreCase)) {
				return isFirstCall ? "OrderByDescending" : "ThenByDescending";
			}

			return isFirstCall ? "OrderBy" : "ThenBy";
		}
	}
}
