using System.Diagnostics;
using UnityEngine;

public static class SRDebugUtil
{
	public const int LineBufferCount = 512;

	public static bool IsFixedUpdate { get; set; }

	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void AssertNotNull(object value, string message = null, MonoBehaviour instance = null)
	{
	}

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	public static void Assert(bool condition, string message = null, MonoBehaviour instance = null)
	{
	}

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	[Conditional("UNITY_EDITOR")]
	public static void EditorAssertNotNull(object value, string message = null, MonoBehaviour instance = null)
	{
	}

	[Conditional("UNITY_EDITOR")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssert(bool condition, string message = null, MonoBehaviour instance = null)
	{
	}
}
