using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MultiPriceButtonPopup : MonoBehaviour, IClosable
{
	public struct Response
	{
		public bool ok;

		public int idx;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CShowAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<Response> _003C_003Et__builder;

		public MultiPriceButtonPopup _003C_003E4__this;

		public string text;

		public List<(int itemId, int count)> items;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private RectTransform _buttonLayout;

	[SerializeField]
	private GameObject _prefab;

	[SerializeField]
	private Text _text;

	private List<(Price price, Button button)> _prices;

	private bool _responsePrepared;

	[NonSerialized]
	private Response _response;

	[AsyncStateMachine(typeof(_003CShowAsync_003Ed__7))]
	public UniTask<Response> ShowAsync(string text, List<(int itemId, int count)> items)
	{
		return default(UniTask<Response>);
	}

	private void InitPrice(Price price, Button button, int itemId, int count, int idx)
	{
	}

	public void OnClickYes(int idx)
	{
	}

	public void OnClickNo()
	{
	}

	public bool Close()
	{
		return false;
	}
}
