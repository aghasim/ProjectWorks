using System.Collections.Generic;
using System.Linq;



namespace Microsoft.EntityFrameworkCore.ChangeTracking {
	public static class EntityEntryExtension {
		public static IEnumerable<PropertyEntry> GetChanges(this EntityEntry entity) {
			// Get changed properties
			var changes = entity.Properties
				.Where(m => m.IsModified == true && m.IsTemporary == false)
				.ToList();

			// Get changes from any navigation property
			var references = entity.References
				.Select(m => m.TargetEntry)
				.ToList();

			// Iterate navigation properties changes
			foreach (var reference in references) {
				// Add navigation properties changes to changes list
				changes.AddRange(reference.GetChanges());
			}

			//// Get collections changes
			//var collections = entity.Collections
			//	.Where(m => m.IsModified)
			//	.ToList();

			//// Iterate changed collections
			//foreach (var collection in collections) {
			//	changes.AddRange(collection.GetChanges());
			//}

			// Return complete list of detected changes
			return changes;
		}
	}
}
