using System;
using System.Collections.Generic;
using System.Linq;

namespace NKHook6.API
{
	// Token: 0x02000004 RID: 4
	public class Registry<T>
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000217B File Offset: 0x0000037B
		public static Registry<T>operator +(Registry<T> inst, T item)
		{
			return inst.Register(item.ToString(), item);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002191 File Offset: 0x00000391
		public static Registry<T>operator -(Registry<T> inst, T item)
		{
			return inst.Unregister(item.ToString());
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021A6 File Offset: 0x000003A6
		public static T operator ^(Registry<T> inst, string item)
		{
			return inst.GetItem(item);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021C2 File Offset: 0x000003C2
		public virtual Registry<T> Register(string ID, T item)
		{
			if (!this.registryItems.ContainsKey(ID))
			{
				this.registryItems.Add(ID, item);
				return this;
			}
			throw new RegistryIDTakenException(ID);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021E8 File Offset: 0x000003E8
		public virtual Registry<T> Unregister(string ID)
		{
			using (Dictionary<string, T>.KeyCollection.Enumerator enumerator = this.registryItems.Keys.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == ID)
					{
						return this;
					}
				}
			}
			throw new RegistryIDNotFoundException(ID);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000224C File Offset: 0x0000044C
		public virtual T GetItem(string ID)
		{
			return this.registryItems[ID];
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000225A File Offset: 0x0000045A
		public virtual T[] GetItems()
		{
			return Enumerable.ToArray<T>(this.registryItems.Values);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000226C File Offset: 0x0000046C
		public virtual string[] GetIDs()
		{
			return Enumerable.ToArray<string>(this.registryItems.Keys);
		}

		// Token: 0x04000001 RID: 1
		private Dictionary<string, T> registryItems = new Dictionary<string, T>();
	}
}
