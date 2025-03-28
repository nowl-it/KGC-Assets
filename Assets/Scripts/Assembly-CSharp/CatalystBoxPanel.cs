using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AwesomeData.Encrypted;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class CatalystBoxPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public bool processed;

		internal void _003COnClickConfirm_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickConfirm_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CatalystBoxPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		private EncryptedInt _003Ccount_003E5__2;

		private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	private Image _selectedCatalyst;

	[SerializeField]
	private Text _selectedCountTop;

	[SerializeField]
	private Text _selectedCountBottom;

	[SerializeField]
	private Text _ownCount;

	[SerializeField]
	private ConditionalGroup _actionButton;

	[SerializeField]
	private Text _type;

	[SerializeField]
	private Text _name;

	[SerializeField]
	private Transform _catalystGrid;

	[SerializeField]
	private GameObject _catalystItemPrefab;

	[SerializeField]
	private Slider _countSlider;

	private CatalystItemToggle _target;

	private List<CatalystItemToggle> _catalysts;

	private int _boxCount;

	private EncryptedInt _addCount;

	private ArtifactModel _artifactModel;

	private bool _isProcessing;

	private Action _onClose;

	public void Show(ArtifactModel artifactModel, Action onClose = null)
	{
	}

	private void AddCatalystItem(int catalystId, int index)
	{
	}

	public void Reload()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickConfirm_003Ed__20))]
	public void OnClickConfirm()
	{
	}

	public void OnClickClose()
	{
	}

	public void OnToggleItem()
	{
	}

	public void OnClickMin()
	{
	}

	public void OnClickMax()
	{
	}

	public void OnClickMinus()
	{
	}

	public void OnClickPlus()
	{
	}

	public void OnSliderValueChanged()
	{
	}

	public bool Close()
	{
		return false;
	}

	private void OnDestroy()
	{
	}
}
