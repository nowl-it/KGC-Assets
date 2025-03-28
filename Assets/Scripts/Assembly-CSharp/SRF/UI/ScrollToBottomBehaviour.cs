using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("SRF/UI/Scroll To Bottom Behaviour")]
	[ExecuteInEditMode]
	public class ScrollToBottomBehaviour : MonoBehaviour
	{
		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		public void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void Trigger()
		{
		}

		private void OnScrollRectValueChanged(Vector2 position)
		{
		}

		private void Refresh()
		{
		}

		private void SetVisible(bool truth)
		{
		}
	}
}
