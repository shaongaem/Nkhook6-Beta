using System;
using System.Collections.Generic;
using System.Reflection;
using NKHook6.API.Events;

namespace NKHook6.API.Registry
{
	// Token: 0x0200000F RID: 15
	public class EventRegistry : Registry<List<MethodInfo>>
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000022C2 File Offset: 0x000004C2
		public static EventRegistry subscriber
		{
			get
			{
				return EventRegistry.instance;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000022CC File Offset: 0x000004CC
		internal EventRegistry()
		{
			EventRegistry.instance = this;
			this.CreateEvent("UpdateEvent");
			this.CreateEvent("KeyPressEvent");
			this.CreateEvent("KeyHeldEvent");
			this.CreateEvent("KeyReleaseEvent");
			this.CreateEvent("BloonCreatedEvent");
			this.CreateEvent("BloonDamagedEvent");
			this.CreateEvent("BloonLeakedEvent");
			this.CreateEvent("BloonDeletedEvent");
			this.CreateEvent("BloonMoveEvent");
			this.CreateEvent("BloonRotateEvent");
			this.CreateEvent("TowerCreatedEvent");
			this.CreateEvent("TowerDeletedEvent");
			this.CreateEvent("TowerSoldEvent");
			this.CreateEvent("TowerSelectedEvent");
			this.CreateEvent("TowerDeselectedEvent");
			this.CreateEvent("TowerUpgradeEvent");
			this.CreateEvent("CashChangedEvent");
			this.CreateEvent("CashLostEvent");
			this.CreateEvent("CashGainedEvent");
			this.CreateEvent("HealthChangedEvent");
			this.CreateEvent("HealthLostEvent");
			this.CreateEvent("HealthGainedEvent");
			this.CreateEvent("WeaponCreatedEvent");
			this.CreateEvent("WeaponDeletedEvent");
			this.CreateEvent("VictoryEvent");
			this.CreateEvent("StartMatchEvent");
			this.CreateEvent("RoundStartEvent");
			this.CreateEvent("RoundEndEvent");
			this.CreateEvent("DefeatedEvent");
			this.CreateEvent("ProjectileCreatedEvent");
			this.CreateEvent("ProjectileDeletedEvent");
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000243A File Offset: 0x0000063A
		public void CreateEvent(string eventName)
		{
			this.Register(eventName, new List<MethodInfo>());
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000244C File Offset: 0x0000064C
		public void Listen(Type toSubscribe)
		{
			foreach (MethodInfo methodInfo in toSubscribe.GetMethods())
			{
				if (methodInfo.IsStatic)
				{
					using (IEnumerator<Attribute> enumerator = methodInfo.GetCustomAttributes().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current is Event)
							{
								ParameterInfo parameterInfo = methodInfo.GetParameters()[0];
								if (parameterInfo != null)
								{
									Type parameterType = parameterInfo.ParameterType;
									if (parameterType.IsSubclassOf(typeof(EventBase)))
									{
										using (IEnumerator<Attribute> enumerator2 = parameterType.GetCustomAttributes().GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												Attribute attribute = enumerator2.Current;
												if (attribute is EventHeader)
												{
													EventHeader eventHeader = attribute as EventHeader;
													bool flag = false;
													foreach (string text in this.GetIDs())
													{
														if (text == eventHeader.eventName)
														{
															this.GetItem(text).Add(methodInfo);
															flag = true;
														}
													}
													if (!flag)
													{
														throw new UnknownEventException(eventHeader.eventName);
													}
												}
											}
											continue;
										}
									}
									throw new Exception("Invalid event parameter type! Must be an EventBase!");
								}
								throw new Exception("The event method doesn't have any valid paramters!");
							}
						}
					}
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000025D0 File Offset: 0x000007D0
		public void DispatchEvent<T>(ref T e) where T : EventBase
		{
			foreach (Attribute attribute in e.GetType().GetCustomAttributes())
			{
				if (attribute is EventHeader)
				{
					EventHeader eventHeader = attribute as EventHeader;
					List<MethodInfo> item = this.GetItem(eventHeader.eventName);
					if (item != null && item.Count != 0)
					{
						using (List<MethodInfo>.Enumerator enumerator2 = item.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								MethodInfo methodInfo = enumerator2.Current;
								methodInfo.Invoke(null, new object[]
								{
									e
								});
							}
							break;
						}
					}
				}
			}
		}

		// Token: 0x04000008 RID: 8
		public static EventRegistry instance;
	}
}
