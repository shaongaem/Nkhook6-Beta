using System;
using System.Linq;
using System.Reflection;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Simulation.SMath;
using NKHook6.API.Bloons;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x02000034 RID: 52
	public class NBloonEntity : IBloonEntity
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00002C02 File Offset: 0x00000E02
		public NBloonEntity(Bloon theBloon)
		{
			this.theBloon = theBloon;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002C14 File Offset: 0x00000E14
		public new IBloon GetType()
		{
			string b = this.theBloon.bloonModel.name + "Bloon";
			foreach (Type type in Enumerable.Where<Type>(Assembly.GetExecutingAssembly().GetTypes(), (Type t) => t.Namespace.StartsWith("NKHook6_Impl.Implementations.Bloons")))
			{
				if (type.Name == b)
				{
					return (NBloon)Activator.CreateInstance(type);
				}
			}
			return new NBloon(this.theBloon.bloonModel);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002CCC File Offset: 0x00000ECC
		public float GetProgress()
		{
			return this.theBloon.distanceTraveled;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002CDC File Offset: 0x00000EDC
		public float[] GetPosition()
		{
			Vector3Boxed position = this.theBloon.Position;
			return new float[]
			{
				position.X,
				position.Y,
				position.Z
			};
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002D16 File Offset: 0x00000F16
		public float GetRotation()
		{
			return this.theBloon.Rotation;
		}

		// Token: 0x04000023 RID: 35
		private Bloon theBloon;
	}
}
