namespace System.Collections.Generic {
	public static class IEnumerableExtensions {
		/// <summary>
		/// Joins elements with a Char
		/// </summary>
		/// <returns>Returns joined elements</returns>
		public static String Implode<TValue>(this IEnumerable<TValue> source, Char glue) {
			return String.Join(glue, source);
		}



		/// <summary>
		/// Joins elements with a String
		/// </summary>
		/// <returns>Returns joined elements</returns>
		public static String Implode<TValue>(this IEnumerable<TValue> source, String glue) {
			return String.Join(glue, source);
		}
	}
}
