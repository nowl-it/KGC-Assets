using System;
using UnityEngine;

namespace SRF.UI
{
	[Serializable]
	public class Style
	{
		public Color ActiveColor;

		public Color DisabledColor;

		public Color HoverColor;

		public Sprite Image;

		public Color NormalColor;

		public Style Copy()
		{
			return null;
		}

		public void CopyFrom(Style style)
		{
		}
	}
}
