using UnityEngine;
using UnityEngine.EventSystems;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/Unselectable")]
	public sealed class Unselectable : SRMonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		private bool _suspectedSelected;

		public void OnSelect(BaseEventData eventData)
		{
		}

		private void Update()
		{
		}
	}
}
