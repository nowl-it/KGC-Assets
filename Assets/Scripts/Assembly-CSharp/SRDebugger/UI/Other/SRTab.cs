using System;
using SRDebugger.UI.Controls;
using SRF;
using UnityEngine;
using UnityEngine.Serialization;

namespace SRDebugger.UI.Other
{
	public class SRTab : SRMonoBehaviourEx
	{
		public RectTransform HeaderExtraContent;

		[HideInInspector]
		[Obsolete]
		public Sprite Icon;

		public RectTransform IconExtraContent;

		public string IconStyleKey;

		public int SortIndex;

		[HideInInspector]
		public SRTabButton TabButton;

		[SerializeField]
		[FormerlySerializedAs("Title")]
		private string _title;

		[SerializeField]
		private string _longTitle;

		[SerializeField]
		private string _key;

		public string Title => null;

		public string LongTitle => null;

		public string Key => null;
	}
}
