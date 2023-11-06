using System;
using System.Collections;
using System.Collections.Generic;

namespace NKHook6.API
{
	// Token: 0x02000003 RID: 3
	public static class Extensions
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002048 File Offset: 0x00000248
		private static void ExampleOfIEnumerableExtensions()
		{
			new string[]
			{
				"NoSpace",
				"1Space ",
				"NoSpace",
				"2Spaces  "
			}.AllocAdd("5Spaces     ").AllThatApply((string i) => i.Contains(" ")).Do(delegate(string i)
			{
				Console.WriteLine("The string \"" + i + "\" has been chosen by the predicate.");
			});
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020CD File Offset: 0x000002CD
		public static IEnumerable<TSource> AllThatApply<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> condition) where TSource : class
		{
			IEnumerator enumerator = source.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (condition(enumerator.Current as TSource))
				{
					yield return enumerator.Current as TSource;
				}
			}
			yield break;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020E4 File Offset: 0x000002E4
		public static void Do<TSource>(this IEnumerable<TSource> source, Action<TSource> action) where TSource : class
		{
			foreach (object obj in source)
			{
				action(obj as TSource);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002118 File Offset: 0x00000318
		public static void DoIf<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Action<TSource> action) where TSource : class
		{
			IEnumerator enumerator = source.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (predicate(enumerator.Current as TSource))
				{
					action(enumerator.Current as TSource);
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002164 File Offset: 0x00000364
		public static IEnumerable<TSource> AllocAdd<TSource>(this IEnumerable<TSource> source, TSource addition)
		{
			foreach (TSource tsource in source)
			{
				yield return tsource;
			}
			IEnumerator<TSource> enumerator = null;
			yield return addition;
			yield break;
			yield break;
		}
	}
}
