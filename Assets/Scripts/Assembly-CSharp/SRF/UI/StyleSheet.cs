using System;
using System.Collections.Generic;
using UnityEngine;

namespace SRF.UI
{
	[Serializable]
	public class StyleSheet : ScriptableObject
	{
		[SerializeField]
		private List<string> _keys;

		[SerializeField]
		private List<Style> _styles;

		[SerializeField]
		public StyleSheet Parent;

		public Style GetStyle(string key, bool searchParent = true)
		{
			return null;
		}
	}
}
