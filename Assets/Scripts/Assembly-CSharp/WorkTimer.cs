using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NMeCab.Core;
using UnityEngine;

public class WorkTimer : MonoBehaviour
{
	private class UpdateItem
	{
		public float time;

		public float timer;

		public Action callback;

		public Func<bool> condition;

		public bool loop;

		public int loopCount;

		public int index;

		private static int _indexer;

		public UpdateItem(float time, Action callback, Func<bool> condition, bool loop, int loopCount = -1)
		{
		}

		public void Set(float time, Action callback, Func<bool> condition, bool loop, int loopCount = -1)
		{
		}
	}

	private readonly struct KeyItem : IComparable<KeyItem>
	{
		public readonly ulong key;

		public readonly UpdateItem item;

		public KeyItem(ulong key, UpdateItem item)
		{
			this.key = 0uL;
			this.item = null;
		}

		public int CompareTo(KeyItem other)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoopTimerCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public Action callback;

		public ulong key;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLoopTimerCoroutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CTimerCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public Action callback;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CTimerCoroutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static WorkTimer _instance;

	private static Dictionary<ulong, bool> _keyMap;

	private static readonly List<UpdateItem> _updateItemPool;

	private static readonly Dictionary<ulong, UpdateItem> _updateMap;

	private static readonly Dictionary<object, ulong> _objectKeyMap;

	private static readonly Dictionary<ulong, UpdateItem> _addList;

	private static readonly PriorityQueue<KeyItem> _invokeList;

	private static readonly HashSet<ulong> _deleteList;

	private static bool _paused;

	private static uint _keyIndexer;

	private static uint _objectKeyIndexer;

	public static WorkTimer Instance => null;

	public static void DoCoroutine(float time, Action callback)
	{
	}

	public static void LoopCoroutine(float time, Action callback, ulong key)
	{
	}

	public static void StopLoopCoroutine(ulong key)
	{
	}

	[IteratorStateMachine(typeof(_003CTimerCoroutine_003Ed__7))]
	private static IEnumerator TimerCoroutine(float time, Action callback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoopTimerCoroutine_003Ed__8))]
	private static IEnumerator LoopTimerCoroutine(float time, Action callback, ulong key)
	{
		return null;
	}

	private static UpdateItem RentItem(float time, Action callback, Func<bool> condition, bool loop, int loopCount = -1)
	{
		return null;
	}

	private static void ReturnList(UpdateItem item)
	{
	}

	public static void Do(ulong key, float time, Action callback = null, Func<bool> condition = null, bool loop = false, int loopCount = -1, bool refresh = true)
	{
	}

	private static ulong GetObjectKey(object obj)
	{
		return 0uL;
	}

	public static ulong GenerateSimpleKey()
	{
		return 0uL;
	}

	public static ulong GenerateSimpleObjectKey()
	{
		return 0uL;
	}

	private static ulong ComposeKey(ulong objectKey, ulong postKey)
	{
		return 0uL;
	}

	public static void Do(object obj, ulong postKey, float time, Action callback = null, Func<bool> condition = null, bool loop = false, int loopCount = -1, bool refresh = true)
	{
	}

	public static ulong Do(float time, Action callback = null, Func<bool> condition = null, bool loop = false, int loopCount = -1)
	{
		return 0uL;
	}

	public static void Stop(ulong? key)
	{
	}

	public static void Stop(ulong key)
	{
	}

	public static void Stop(object obj, ulong postKey)
	{
	}

	public static void Complete(ulong key)
	{
	}

	public static void ChangeTime(ulong key, float time)
	{
	}

	public static void ChangeTime(object obj, ulong postKey, float time)
	{
	}

	public static bool IsDone(ulong key)
	{
		return false;
	}

	public static bool IsDone(object obj, ulong postKey)
	{
		return false;
	}

	public static float GetTime(ulong key)
	{
		return 0f;
	}

	public static float GetTime(object obj, ulong postKey)
	{
		return 0f;
	}

	public static int GetLoopCount(ulong key)
	{
		return 0;
	}

	public static int GetLoopCount(object obj, ulong postKey)
	{
		return 0;
	}

	public static int AddLoopCount(ulong key, int value)
	{
		return 0;
	}

	public static int AddLoopCount(object obj, ulong postKey, int value)
	{
		return 0;
	}

	private void UpdateList()
	{
	}

	public void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	private void UpdateImpl()
	{
	}

	public static void ClearAll()
	{
	}

	public static void Pause()
	{
	}

	public static void Resume()
	{
	}
}
