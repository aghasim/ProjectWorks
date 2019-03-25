using ProjectWorks.Data.Resources;



namespace System.Linq {
	public static class QueryableApplyExtension {
		public static IQueryable<TEntity> Apply<TEntity>(this IQueryable<TEntity> source, ResourceParameters parameters) {
			if (parameters == null) {
				return source;
			}

			if (parameters.Includes != null && parameters.Includes.Count() > 0) {
				source = source.Include(parameters.Includes);
			}

			if (parameters.Sorting != null && parameters.Sorting.Count() > 0) {
				source = source.OrderBy(parameters.Sorting);
			}

			if (parameters.Filters != null && parameters.Filters.Count > 0) {
				source = source.Where(parameters.Filters);
			}

			if (parameters.Search != null && parameters.Search.Count() > 0) {
				source = source.Search(parameters.Search);
			}

			if (parameters.Pagination != null) {
				source = source
					.Skip((parameters.Pagination.Index - 1) * parameters.Pagination.Size)
					.Take(parameters.Pagination.Size);
			}

			return source;
		}
	}
}
