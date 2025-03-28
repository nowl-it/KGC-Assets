using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace SRF.UI
{
	[ExecuteInEditMode]
	[AddComponentMenu("SRF/UI/Style Component")]
	public class StyleComponent : SRMonoBehaviour
	{
		private Style _activeStyle;

		private StyleRoot _cachedRoot;

		private Graphic _graphic;

		private bool _hasStarted;

		private Image _image;

		private Selectable _selectable;

		[HideInInspector]
		[SerializeField]
		[FormerlySerializedAs("StyleKey")]
		private string _styleKey;

		public bool IgnoreImage;

		public string StyleKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void Refresh(bool invalidateCache)
		{
		}

		private StyleRoot GetStyleRoot()
		{
			return null;
		}

		private void ApplyStyle()
		{
		}

		private void SRStyleDirty()
		{
		}
	}
}
