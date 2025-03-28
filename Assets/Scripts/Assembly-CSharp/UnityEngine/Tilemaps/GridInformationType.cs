using System;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	internal enum GridInformationType
	{
		Integer = 0,
		String = 1,
		Float = 2,
		Double = 3,
		UnityObject = 4,
		Color = 5
	}
}
