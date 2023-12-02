using System;
using MelonLoader;
using NKHook6.API;
using NKHook6.API.Registry;

namespace NKHook6_Impl
{
	// Token: 0x0200002F RID: 47
	public class Entry : MelonMod, BTDModStart
	{
		// Token: 0x06000078 RID: 120 RVA: 0x0000287E File Offset: 0x00000A7E
		public override void OnApplicationStart()
		{
			base.OnApplicationStart();
			MelonLogger.Log("Starting NKHook6 (Beta) API Implementation");
			new EventRegistry();
			MelonLogger.Log.Log("Google translate of NKHook6 (Beta) API to TARGET has begun".Replace("TARGET", "BloonsTD6"));
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000028AF File Offset: 0x00000AAF
		public void OnModLoaded()
		{
			EventRegistry.instance.Listen(typeof(Entry));
		}
	}
}
