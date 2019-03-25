using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Query.Internal;



namespace System.Linq {
	public static class QueryableIncludeExtension {
		public static IQueryable<TEntity> Include<TEntity>(this IQueryable<TEntity> source, IEnumerable<String> includes) {
			if (includes == null || includes.Count() == 0) {
				return source;
			}

			foreach (var include in includes) {
				source = source.Include(include);
			}

			return source;
		}



		public static IQueryable<TEntity> Include<TEntity>(this IQueryable<TEntity> source, String navigationPropertyPath) {
			if ((source.Provider is EntityQueryProvider) == false) {
				return source;
			}

			var method = typeof(QueryableIncludeExtension)
				.GetTypeInfo()
				.GetDeclaredMethods(nameof(Include))
				.Single(mi => mi.GetParameters().Any(pi => pi.Name == "navigationPropertyPath" && pi.ParameterType == typeof(String)));

			var expression = Expression.Call(
				instance: null,
				method: method.MakeGenericMethod(typeof(TEntity)),
				arg0: source.Expression,
				arg1: Expression.Constant(navigationPropertyPath)
			);

			return source.Provider.CreateQuery<TEntity>(expression);
		}
	}
}
