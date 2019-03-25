using System;
using System.Collections.Generic;



namespace ProjectWorks.Data.Resources {
	public class ResourceResponse {
		public Boolean Success { get; set; }

		public Object Data { get; set; }

		public IEnumerable<ResourceLink> Links { get; set; }

		public IEnumerable<String> Messages { get; set; }

		public IEnumerable<ResourceError> Errors { get; set; }
	}
}
