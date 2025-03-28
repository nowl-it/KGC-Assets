using System;
using System.Collections.Generic;

public static class RegisteredComponentController
{
	public class InstanceContainer : HashSet_Flash<IRegisteredComponent>
	{
	}

	private static Dictionary<Type, InstanceContainer> _instanceContainers;

	public static T[] GetAllOfType<T>() where T : IRegisteredComponent
	{
		return null;
	}

	public static object[] GetAllOfType(Type type)
	{
		return null;
	}

	public static int InstanceCountOfType<T>() where T : IRegisteredComponent
	{
		return 0;
	}

	private static InstanceContainer _GetInstanceContainer(Type type)
	{
		return null;
	}

	private static void _RegisterType(IRegisteredComponent component, Type type)
	{
	}

	internal static void _Register(IRegisteredComponent component)
	{
	}

	internal static void _UnregisterType(IRegisteredComponent component, Type type)
	{
	}

	internal static void _Unregister(IRegisteredComponent component)
	{
	}
}
