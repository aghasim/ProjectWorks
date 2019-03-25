using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;



namespace ProjectWorks.Data.Resources {
	public class ResourceParametersModelBinder : IModelBinder {
		private IQueryCollection query;



		public Task BindModelAsync(ModelBindingContext bindingContext) {
			// Get query string
			this.query = bindingContext.ActionContext.HttpContext.Request.Query;

			// Bind resource parameters
			bindingContext.Model = new ResourceParameters() {
				Filters = this.GetFilters(),
				Pagination = this.GetPagination(),
				Fields = this.GetFields(),
				Includes = this.GetIncludes(),
				Sorting = this.GetSorting(),
				Search = this.GetSearch(),
			};

			bindingContext.Result = ModelBindingResult.Success(bindingContext.Model);

			return Task.CompletedTask;
		}



		private String GetValue(String parameter) {
			// Get parameter name
			var key = this.query.Keys
				.FirstOrDefault(m => m.Equals(parameter, StringComparison.OrdinalIgnoreCase));

			// Check if query parameter has been passed
			if (key != null) {
				return this.query[key].ToString().TrimStart('_');
			}

			return String.Empty;
		}



		private Dictionary<String, String> GetFilters() {
			var exclude = new[] { "page", "size", "sort", "search", "fields", "expand" };

			return this.query
				.Where(m => Array.IndexOf(exclude, m.Key) == -1)
				.ToDictionary(m => m.Key.ToString(), m => m.Value.ToString());
		}



		private ResourceParametersPagination GetPagination() {
			var paging = new ResourceParametersPagination();

			var page = this.GetValue("page").Trim();
			var size = this.GetValue("size").Trim();

			if (String.IsNullOrWhiteSpace(page) == false) {
				paging.Index = Convert.ToInt32(page);
			}

			if (String.IsNullOrWhiteSpace(size) == false) {
				paging.Size = size.Equals("max", StringComparison.OrdinalIgnoreCase) ? Int32.MaxValue : Convert.ToInt32(size);
			}

			return paging;
		}



		private IEnumerable<String> GetFields() {
			return this.GetValue("fields")
				.Split(',')
				.Where(m => m.Length > 0)
				.Select(m => m.Trim());
		}



		private IEnumerable<ResourceParametersSorting> GetSorting() {
			return this.GetValue("sort")
				.Split(',')
				.Where(m => m.Length > 0)
				.Select(m => {
					return new ResourceParametersSorting() {
						Property = m.TrimStart('+', '-').Trim(),
						Direction = (m[0] == '-' ? "desc" : "asc")
					};
				});
		}



		private IEnumerable<String> GetIncludes() {
			return this.GetValue("expand")
				.Split(',')
				.Where(m => m.Length > 0)
				.Select(m => m.Trim());
		}



		private IEnumerable<KeyValuePair<String, String>> GetSearch() {
			var expression = this.GetValue("search");

			if (String.IsNullOrWhiteSpace(expression)) {
				return null;
			}

			return expression
				.Split('|', StringSplitOptions.RemoveEmptyEntries)
				.Select(m => new {
					Key = m.Split(':')?[0]?.Trim(),
					Value = m.Split(':')?[1]?.Trim(),
				})
				.Where(m =>
					m.Key.Length > 0
						&&
					m.Value.Length > 0
				)
				.Select(m => new KeyValuePair<String, String>(
					m.Key.ToString(),
					m.Value.ToString()
				));
		}
	}
}
