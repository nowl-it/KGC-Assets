using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/SRText")]
	public class SRText : Text
	{
		public event Action<SRText> LayoutDirty
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override void SetLayoutDirty()
		{
		}
	}
}
