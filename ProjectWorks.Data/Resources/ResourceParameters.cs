using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;



namespace ProjectWorks.Data.Resources {
	[ModelBinder(typeof(ResourceParametersModelBinder))]
	public class ResourceParameters {
		public ResourceParametersPagination Pagination { get; set; }

		public IEnumerable<ResourceParametersSorting> Sorting { get; set; }

		public Dictionary<String, String> Filters { get; set; }

		public IEnumerable<KeyValuePair<String, String>> Search { get; set; }

		public IEnumerable<String> Fields { get; set; }

		public IEnumerable<String> Includes { get; set; }



		public ResourceParameters() {
			this.Pagination = new ResourceParametersPagination();
			this.Sorting = new List<ResourceParametersSorting>();
			this.Filters = new Dictionary<String, String>();
			this.Search = new Dictionary<String, String>();
			this.Fields = new List<String>();
			this.Includes = new List<String>();
		}
	}



	public class ResourceParametersPagination {
		public Int32 Index { get; set; } = 1;

		public Int32 Size { get; set; } = 100;
	}



	public class ResourceParametersSorting {
		public String Property { get; set; }

		public String Direction { get; set; } = "asc";
	}
}
