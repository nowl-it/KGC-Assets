using System;
using System.Collections.Generic;
using UnityEngine;

namespace SRF
{
	public class Hierarchy
	{
		private static readonly char[] Seperator;

		private static readonly Dictionary<string, Transform> Cache;

		[Obsolete("Use static Get() instead")]
		public Transform this[string key] => null;

		public static Transform Get(string key)
		{
			return null;
		}
	}
}
