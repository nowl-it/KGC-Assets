using SRDebugger.UI.Other;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI
{
	public class MobileMenuController : SRMonoBehaviourEx
	{
		private Button _closeButton;

		[SerializeField]
		private float _maxMenuWidth;

		[SerializeField]
		private float _peekAmount;

		private float _targetXPosition;

		[RequiredField]
		public RectTransform Content;

		[RequiredField]
		public RectTransform Menu;

		[RequiredField]
		public Button OpenButton;

		[RequiredField]
		public SRTabController TabController;

		public float PeekAmount => 0f;

		public float MaxMenuWidth => 0f;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void CreateCloseButton()
		{
		}

		private void SetRectSize(RectTransform rect)
		{
		}

		private void CloseButtonClicked()
		{
		}

		protected override void Update()
		{
		}

		private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab)
		{
		}

		[ContextMenu("Open")]
		public void Open()
		{
		}

		[ContextMenu("Close")]
		public void Close()
		{
		}
	}
}
