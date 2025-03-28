using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	public class CategoryGroup : SRMonoBehaviourEx
	{
		[RequiredField]
		public RectTransform Container;

		[RequiredField]
		public Text Header;

		[RequiredField]
		public GameObject Background;

		[RequiredField]
		public Toggle SelectionToggle;

		public GameObject[] EnabledDuringSelectionMode;

		private bool _selectionModeEnabled;

		public bool IsSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SelectionModeEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
