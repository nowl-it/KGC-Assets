using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace AlphaRaycaster
{
	[ExecuteInEditMode]
	[AddComponentMenu("Event/Alpha Raycaster")]
	public class AlphaRaycaster : GraphicRaycaster
	{
		private struct CharacterRect
		{
			public Rect Rect;

			public Text Text;

			public UIVertex UpperLeftVertex;

			public UIVertex UpperRightVertex;

			public UIVertex BottomRightVertex;

			public UIVertex BottomLeftVertex;

			public Rect ScaledRect => default(Rect);

			public CharacterRect(Text text, UIVertex ulv, UIVertex urv, UIVertex brv, UIVertex blv)
			{
				Rect = default(Rect);
				Text = null;
				UpperLeftVertex = default(UIVertex);
				UpperRightVertex = default(UIVertex);
				BottomRightVertex = default(UIVertex);
				BottomLeftVertex = default(UIVertex);
			}

			public bool Contains(Vector2 position)
			{
				return false;
			}

			public float GetTextureAlphaFromPosition(Vector2 position)
			{
				return 0f;
			}
		}

		[Header("Alpha test properties")]
		[Range(0f, 1f)]
		[Tooltip("Texture regions of the UI objects with opacity (alpha) lower than alpha threshold won't react to input events.")]
		public float AlphaThreshold;

		[Tooltip("Whether material tint color of the UI objects should affect alpha threshold.")]
		public bool IncludeMaterialAlpha;

		[Tooltip("When selective mode is active the alpha testing will only execute for UI objects with AlphaCheck component.")]
		public bool SelectiveMode;

		[Tooltip("Show warnings in the console when attempting to alpha test objects with a not-readable texture.")]
		public bool ShowTextureWarnings;

		protected override void OnEnable()
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		public static bool AlphaCheckImage(GameObject obj, Image objImage, Vector2 pointerPos, Camera eventCamera, float alphaThreshold, bool includeMaterialAlpha)
		{
			return false;
		}

		public static bool AlphaCheckText(GameObject obj, Text objText, Vector2 pointerPos, Camera eventCamera, float alphaThreshold, bool includeMaterialAlpha)
		{
			return false;
		}

		public static bool AlphaCheckRawImage(GameObject obj, RawImage objRawImage, Vector2 pointerPos, Camera eventCamera, float alphaThreshold, bool includeMaterialAlpha)
		{
			return false;
		}

		private static Vector3 ScreenToLocalObjectPosition(Vector2 screenPosition, RectTransform objTrs, Camera eventCamera)
		{
			return default(Vector3);
		}

		private static Rect GetImageTextureRect(Image objImage)
		{
			return default(Rect);
		}
	}
}
