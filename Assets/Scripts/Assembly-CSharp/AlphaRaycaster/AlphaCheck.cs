using UnityEngine;
using UnityEngine.UI;

namespace AlphaRaycaster
{
	[ExecuteInEditMode]
	[AddComponentMenu("Event/Alpha Check")]
	public class AlphaCheck : MonoBehaviour, ICanvasRaycastFilter
	{
		[Range(0f, 1f)]
		[Tooltip("Texture regions with opacity (alpha) lower than alpha threshold won't react to input events.")]
		public float AlphaThreshold;

		[Tooltip("Whether material tint color should affect alpha threshold.")]
		public bool IncludeMaterialAlpha;

		private GameObject gameObj;

		private Image checkedImage;

		private RawImage checkedRawImage;

		private Text checkedText;

		private bool isSetupValid;

		private void Awake()
		{
		}

		public bool IsRaycastLocationValid(Vector2 screenPosition, Camera eventCamera)
		{
			return false;
		}
	}
}
