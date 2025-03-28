using SRDebugger.Internal;
using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public abstract class OptionsControlBase : SRMonoBehaviourEx
	{
		private bool _selectionModeEnabled;

		[RequiredField]
		public Toggle SelectionModeToggle;

		public OptionDefinition Option;

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

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		public virtual void Refresh()
		{
		}
	}
}
