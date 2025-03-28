using System;
using System.Collections.Generic;
using System.Reflection;
using SRF.Components;
using UnityEngine;

namespace SRF.Service
{
	[AddComponentMenu("SRF/Service/Service Manager")]
	public class SRServiceManager : SRAutoSingleton<SRServiceManager>
	{
		[Serializable]
		private class Service
		{
			public object Object;

			public Type Type;
		}

		[Serializable]
		private class ServiceStub
		{
			public Func<object> Constructor;

			public Type InterfaceType;

			public Func<Type> Selector;

			public Type Type;

			public override string ToString()
			{
				return null;
			}
		}

		public const bool EnableLogging = false;

		public static int LoadingCount;

		private readonly SRList<Service> _services;

		private List<ServiceStub> _serviceStubs;

		private static bool _hasQuit;

		public static bool IsLoading => false;

		public static T GetService<T>() where T : class
		{
			return null;
		}

		public static object GetService(Type t)
		{
			return null;
		}

		private static object GetServiceInternal(Type t)
		{
			return null;
		}

		public static bool HasService<T>() where T : class
		{
			return false;
		}

		public static bool HasService(Type t)
		{
			return false;
		}

		public static void RegisterService<T>(object service) where T : class
		{
		}

		private static void RegisterService(Type t, object service)
		{
		}

		public static void UnRegisterService<T>() where T : class
		{
		}

		private static void UnRegisterService(Type t)
		{
		}

		protected override void Awake()
		{
		}

		protected void UpdateStubs()
		{
		}

		protected object AutoCreateService(Type t)
		{
			return null;
		}

		protected void OnApplicationQuit()
		{
		}

		private static object DefaultServiceConstructor(Type serviceIntType, Type implType)
		{
			return null;
		}

		private void ScanType(Type type)
		{
		}

		private static void ScanTypeForSelectors(Type t, List<ServiceStub> stubs)
		{
		}

		private static void ScanTypeForConstructors(Type t, List<ServiceStub> stubs)
		{
		}

		private static MethodInfo[] GetStaticMethods(Type t)
		{
			return null;
		}
	}
}
