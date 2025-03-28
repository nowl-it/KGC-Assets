using SRF;
using SRF.UI;
using UnityEngine;

namespace SRDebugger.UI.Other
{
	[RequireComponent(typeof(StyleComponent))]
	public class DebugPanelBackgroundBehaviour : SRMonoBehaviour
	{
		private string _defaultKey;

		private bool _isTransparent;

		private StyleComponent _styleComponent;

		public string TransparentStyleKey;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
