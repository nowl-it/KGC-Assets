using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour, IClosable
{
	public enum Type
	{
		Ok = 0,
		YesNo = 1,
		BuyConfirm = 2
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public Popup _003C_003E4__this;

		public int id;

		public Predicate<(int id, bool responsed)> _003C_003E9__2;

		internal bool _003CShowAsync_003Eb__0()
		{
			return false;
		}

		internal bool _003CShowAsync_003Eb__2((int id, bool responsed) x)
		{
			return false;
		}

		internal bool _003CShowAsync_003Eb__1((int id, bool responsed) x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public Popup _003C_003E4__this;

		public int id;

		public Predicate<(int id, bool responsed)> _003C_003E9__2;

		internal bool _003CShowAsync_003Eb__0()
		{
			return false;
		}

		internal bool _003CShowAsync_003Eb__2((int id, bool responsed) x)
		{
			return false;
		}

		internal bool _003CShowAsync_003Eb__1((int id, bool responsed) x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CShowAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public Popup _003C_003E4__this;

		public string title;

		public string desc;

		public string text;

		public Type type;

		public string oneOffKey;

		public bool applyPrefix;

		public int soulItemPrice;

		public (int id, int count) idCount;

		public int tokenPrice;

		public int goldPrice;

		public int cashPrice;

		private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CShowAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public Popup _003C_003E4__this;

		public string text;

		public Type type;

		public string oneOffKey;

		public int soulItemPrice;

		public (int id, int count) idCount;

		public int tokenPrice;

		public int goldPrice;

		public int cashPrice;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

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

	[CanBeNull]
	public Text title;

	[CanBeNull]
	public Text desc;

	public Image bg;

	public Border border;

	public Text contentText;

	public GameObject okButton;

	public GameObject yesNoButtonGroup;

	public GameObject oneOffGroup;

	public ConditionalRoot oneOffRoot;

	public Image dimmedImage;

	public Price price;

	private Type _type;

	protected Action<bool> _callback;

	private List<(string text, Type type, Action<bool> callback, int goldPrice, int cashPrice, int id, bool blur)> _waitQueue;

	private static int _idStaticIndexer;

	private readonly Queue<int> _currentIds;

	private readonly List<(int id, bool responsed)> _waitForCallbacksById;

	private bool _lastCallbackResponse;

	private bool _closedByClick;

	private string _oneOffKey;

	private bool _applyPrefix;

	public bool _oneOffEnabled;

	private bool _isBlur;

	public void ShowImpl(string title, string desc, string text, Type type, Action<bool> callback, int goldPrice = 0, int cashPrice = 0)
	{
	}

	public void Show(string text, Type type = Type.Ok, Action<bool> callback = null, int goldPrice = 0, int cashPrice = 0)
	{
	}

	[AsyncStateMachine(typeof(_003CShowAsync_003Ed__26))]
	public virtual UniTask<bool> ShowAsync(string title, string desc, string text, Type type = Type.Ok, string oneOffKey = null, bool applyPrefix = true, int goldPrice = 0, int cashPrice = 0, int soulItemPrice = 0, (int id, int count) idCount = default((int id, int count)), int tokenPrice = 0)
	{
		return default(UniTask<bool>);
	}

	[AsyncStateMachine(typeof(_003CShowAsync_003Ed__27))]
	public virtual UniTask<bool> ShowAsync(string text, Type type = Type.Ok, string oneOffKey = null, int goldPrice = 0, int cashPrice = 0, int soulItemPrice = 0, (int id, int count) idCount = default((int id, int count)), int tokenPrice = 0)
	{
		return default(UniTask<bool>);
	}

	private void CompleteWaitCallback(bool response)
	{
	}

	public void OnClickOk()
	{
	}

	public void OnClickYes()
	{
	}

	public void OnClickNo()
	{
	}

	public void OnClickOnOffKey()
	{
	}

	private void RefreshOneOffGroup()
	{
	}

	private void CheckQueue()
	{
	}

	public virtual bool Close()
	{
		return false;
	}

	public void SetBlur()
	{
	}
}
