using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using CodeStage.AntiCheat.ObscuredTypes;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Firebase.Analytics;
using Google.Protobuf;
using JetBrains.Annotations;
using Protocol;
using UnityEngine;
using UnityEngine.UI;

public static class Utility
{
	[Serializable]
	public class TestData
	{
		[Serializable]
		public class ItemWithOptions
		{
			public int id;

			public List<Item.Option> options;
		}

		public int id;

		public int level;

		public int boss;

		public Vector2 pos;

		public List<ItemWithOptions> equips;
	}

	[Serializable]
	public class TestField
	{
		public int mode;

		public List<TestData> fieldUnits;

		public BaseAI.SaveDatas fieldUnitAIs;

		public List<TestData> enemies;

		public BaseAI.SaveDatas enemyAIs;

		public List<TestData> obstacles;
	}

	public enum KeySize
	{
		Short = 0,
		Long = 1
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass342_0<T>
	{
		public bool processed;

		public Scene_Base scene;

		internal void _003CShowLoading_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CFadeCoroutine_003Ed__354 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CanvasGroup target;

		public float endValue;

		public float duration;

		public Action onComplete;

		private float _003Ctimer_003E5__2;

		private float _003CoriginAlpha_003E5__3;

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
		public _003CFadeCoroutine_003Ed__354(int _003C_003E1__state)
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
	private sealed class _003CFadeCoroutine_003Ed__355 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Image target;

		public float endValue;

		public float duration;

		public Action onComplete;

		private float _003Ctimer_003E5__2;

		private float _003CoriginAlpha_003E5__3;

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
		public _003CFadeCoroutine_003Ed__355(int _003C_003E1__state)
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
	private sealed class _003CFadeCoroutine_003Ed__356 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpriteRenderer target;

		public float endValue;

		public float duration;

		public Action onComplete;

		private float _003Ctimer_003E5__2;

		private float _003CoriginAlpha_003E5__3;

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
		public _003CFadeCoroutine_003Ed__356(int _003C_003E1__state)
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
	private sealed class _003CPerformLoadResource_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WWW www;

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
		public _003CPerformLoadResource_003Ed__61(int _003C_003E1__state)
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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CShowLoading_003Ed__342<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

		public UniTask<T> task;

		private _003C_003Ec__DisplayClass342_0<T> _003C_003E8__1;

		private UniTask<T>.Awaiter _003C_003Eu__1;

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

	private static List<GameObject> _searchList;

	private static Dictionary<int, int> _seedCallCount;

	private static readonly Dictionary<int, System.Random> _randomWithSeeds;

	private static readonly System.Random _random;

	private static readonly Dictionary<Animator, AnimatorControllerParameter[]> _animParamDict;

	private static StringBuilder _cachedSb;

	private static Dictionary<string, DamageInfo.Type?> _damageTypeEnumCache;

	private static Dictionary<string, BoltInfo.BoltType?> _boltTypeEnumCache;

	private static Dictionary<string, Ease?> _easeEnumCache;

	private static Dictionary<string, RangeInfo.RangeType?> _rangeTypeEnumCache;

	private static Dictionary<string, ResourceSkill.SkillTrigger?> _skillTriggerEnumCache;

	private static Dictionary<string, RangeInfo.Strategy?> _strategyEnumCache;

	private static Dictionary<string, DamageInfo.BaseAtkSkillType?> _baseAtkSkillTypeEnumCache;

	private static Dictionary<string, ResourceItem.EquipType?> _itemEquipTypeEnumCache;

	private static Dictionary<string, BuffManager.GimmickStacks?> _gimmickTypeEnumCache;

	public static string[] romanNumerals;

	private static ObscuredString KEY;

	private static byte[] SALT;

	private static ICryptoTransform _encryptor;

	private static ICryptoTransform _decryptor;

	private static readonly string somethingGood;

	private static byte[] keyArray;

	private static readonly Regex cjkCharRegex;

	private static readonly Regex hiraganaCharRegex;

	private static readonly Regex katakanaCharRegex;

	private static string _currentGitBranch;

	private static int _version;

	private static float _epsilon;

	private static List<(string, BuffManager.StatType, BuffManager.StatValueType)> _statTypeNameCache;

	private static Dictionary<string, (BuffManager.StatType statType, BuffManager.StatValueType statValueType)> _statTypeDictCache;

	private static Dictionary<string, BuffManager.StatType> _statDebuffPerTypeDictCache;

	public static List<TestData> ToJson(List<GameUnit> units)
	{
		return null;
	}

	public static Rect ToRect(this Bounds b)
	{
		return default(Rect);
	}

	public static void SetActive(this MonoBehaviour @this, bool value)
	{
	}

	public static void SetActive(this Transform @this, bool value)
	{
	}

	public static void SetActive(this CanvasGroup @this, bool value)
	{
	}

	public static void SetActive(this Renderer @this, bool value)
	{
	}

	public static bool IsActive(this GameObject @this)
	{
		return false;
	}

	public static bool IsActive(this MonoBehaviour @this)
	{
		return false;
	}

	public static string MD5(byte[] bytes)
	{
		return null;
	}

	public static bool IsNullOrEmpty(this string @this)
	{
		return false;
	}

	public static List<string> GetChildTextList(this XmlNode node, string key, List<string> @default = null)
	{
		return null;
	}

	public static XmlNode GetChild(this XmlNode node, string key, XmlNode inherit = null)
	{
		return null;
	}

	public static string GetChildText(this XmlNode node, string key, string @default = null, XmlNode inherit = null)
	{
		return null;
	}

	public static string[] GetChildStringArray(this XmlNode node, string key, XmlNode inherit = null)
	{
		return null;
	}

	public static List<string> GetChildStringList(this XmlNode node, string key, XmlNode inherit = null)
	{
		return null;
	}

	public static bool GetChildBoolean(this XmlNode node, string key, bool @default = false, XmlNode inherit = null)
	{
		return false;
	}

	public static int GetChildInt(this XmlNode node, string key, int @default = -1, XmlNode inherit = null)
	{
		return 0;
	}

	public static List<int> GetChildIntList(this XmlNode node, string key, XmlNode inherit = null)
	{
		return null;
	}

	public static int[] GetChildIntArray(this XmlNode node, string key, XmlNode inherit = null)
	{
		return null;
	}

	public static List<float> GetChildFloatList(this XmlNode node, string key, XmlNode inherit = null)
	{
		return null;
	}

	public static float[] GetChildFloatArray(this XmlNode node, string key, XmlNode inherit = null)
	{
		return null;
	}

	public static int[] GetAttributeIntArray(this XmlNode node, string key)
	{
		return null;
	}

	public static List<int> GetSplitInt(string text)
	{
		return null;
	}

	public static float GetChildFloat(this XmlNode node, string key, float @default = -1f, XmlNode inherit = null)
	{
		return 0f;
	}

	public static bool HasAttribute(this XmlNode node, string key)
	{
		return false;
	}

	public static int GetAttributeInt(this XmlNode node, string key, int @default = -1)
	{
		return 0;
	}

	public static long GetAttributeLong(this XmlNode node, string key, long @default = -1L)
	{
		return 0L;
	}

	public static float GetAttributeFloat(this XmlNode node, string key, float @default = -1f)
	{
		return 0f;
	}

	public static string GetAttributeText(this XmlNode node, string key, string @default = null)
	{
		return null;
	}

	public static bool GetAttributeBool(this XmlNode node, string key, bool @default = false)
	{
		return false;
	}

	public static void Swap<T>(ref T lhs, ref T rhs)
	{
	}

	public static string EncodeBase64(this string text)
	{
		return null;
	}

	public static string EncodeBase64(this byte[] bytes)
	{
		return null;
	}

	public static string DecodeBase64(this string text)
	{
		return null;
	}

	public static string RemoveQuotes(this string text)
	{
		return null;
	}

	public static string RemoveExtension(string path)
	{
		return null;
	}

	public static GameObject[] SearchAll(this GameObject target, string name)
	{
		return null;
	}

	private static void SearchAllImpl(GameObject target, string name)
	{
	}

	public static GameObject[] SearchAllStartsWith(this GameObject target, string keyword)
	{
		return null;
	}

	private static void SearchAllStartsWithImpl(GameObject target, string keyword)
	{
	}

	public static GameObject Search(this GameObject target, string name)
	{
		return null;
	}

	public static GameObject SearchWithParentName(this GameObject target, string name, string parentName)
	{
		return null;
	}

	private static T Search<T>(this GameObject target, string name) where T : Component
	{
		return null;
	}

	private static T Search<T>(this MonoBehaviour target, string name) where T : Component
	{
		return null;
	}

	private static GameObject Search(this MonoBehaviour target, string name)
	{
		return null;
	}

	public static GameObject Get(this GameObject target, string name)
	{
		return null;
	}

	public static T Get<T>(this GameObject target, string name = null) where T : Component
	{
		return null;
	}

	public static T Get<T>(this MonoBehaviour target, string name = null) where T : Component
	{
		return null;
	}

	public static T Get<T>(this Component target) where T : Component
	{
		return null;
	}

	public static bool IsChildOf(this Transform transform, Transform parent, int maxLevel = 100)
	{
		return false;
	}

	public static float GetWidth(this Sprite sprite)
	{
		return 0f;
	}

	public static float GetHeight(this Sprite sprite)
	{
		return 0f;
	}

	public static T LoadResource<T>(string path)
	{
		return default(T);
	}

	public static Sprite LoadIllust(string illustName)
	{
		return null;
	}

	public static Sprite LoadMap(string mapSpriteName)
	{
		return null;
	}

	public static GameObject LoadMapPrefab(string mapPrefabName)
	{
		return null;
	}

	public static Sprite LoadTerritoryBuildingIcon(string buildingName)
	{
		return null;
	}

	public static GameObject LoadTerritoryBuilding(string buildingName)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPerformLoadResource_003Ed__61))]
	private static IEnumerator PerformLoadResource(WWW www, Type type)
	{
		return null;
	}

	public static bool EqualIgnoreCase(this string a, string b)
	{
		return false;
	}

	public static Vector2 ToDir(this string v)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	public static Vector2Int NormalizeDir(this Vector2Int v, bool useEightDir = false)
	{
		return default(Vector2Int);
	}

	[MethodImpl(256)]
	public static Vector2 NormalizeDir(this Vector2 v)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	public static int TaxiDistance(this Vector2Int v, Vector2Int v2)
	{
		return 0;
	}

	public static int Between(int min, int val, int max)
	{
		return 0;
	}

	public static float Between(float min, float val, float max)
	{
		return 0f;
	}

	public static Vector3 SwapXY(this Vector3 v)
	{
		return default(Vector3);
	}

	public static Vector2Int ToReversePos(this Vector2Int pos)
	{
		return default(Vector2Int);
	}

	[MethodImpl(256)]
	public static Vector2 ToVector2(this Vector3 v)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	public static Vector3 ToVector3(this Vector2 v)
	{
		return default(Vector3);
	}

	[MethodImpl(256)]
	public static Vector2 SetX(this Vector2 v, float x)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	public static Vector2 SetY(this Vector2 v, float y)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	public static Vector3 SetX(this Vector3 v, float x)
	{
		return default(Vector3);
	}

	[MethodImpl(256)]
	public static Vector3 SetY(this Vector3 v, float y)
	{
		return default(Vector3);
	}

	[MethodImpl(256)]
	public static Vector3 SetZ(this Vector3 v, float z)
	{
		return default(Vector3);
	}

	[MethodImpl(256)]
	public static Vector2 AddX(this Vector2 v, float x)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	public static Vector2 AddY(this Vector2 v, float y)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	public static Vector3 AddX(this Vector3 v, float x)
	{
		return default(Vector3);
	}

	[MethodImpl(256)]
	public static Vector3 AddY(this Vector3 v, float y)
	{
		return default(Vector3);
	}

	[MethodImpl(256)]
	public static Vector3 AddZ(this Vector3 v, float z)
	{
		return default(Vector3);
	}

	[MethodImpl(256)]
	public static Vector2 MulX(this Vector2 v, float x)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	public static Vector2 MulY(this Vector2 v, float y)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	public static Vector3 MulX(this Vector3 v, float x)
	{
		return default(Vector3);
	}

	[MethodImpl(256)]
	public static Vector3 MulY(this Vector3 v, float y)
	{
		return default(Vector3);
	}

	[MethodImpl(256)]
	public static Vector3 MulZ(this Vector3 v, float z)
	{
		return default(Vector3);
	}

	public static void SetLeft(this RectTransform rt, float left)
	{
	}

	public static void SetRight(this RectTransform rt, float right)
	{
	}

	public static void SetTop(this RectTransform rt, float top)
	{
	}

	public static void SetBottom(this RectTransform rt, float bottom)
	{
	}

	[MethodImpl(256)]
	public static void Log(object message)
	{
	}

	[MethodImpl(256)]
	public static void Log(object message, UnityEngine.Object context)
	{
	}

	[MethodImpl(256)]
	public static void LogWarning(object message)
	{
	}

	[MethodImpl(256)]
	public static void LogWarning(object message, UnityEngine.Object context)
	{
	}

	[MethodImpl(256)]
	public static void LogError(object message)
	{
	}

	[MethodImpl(256)]
	public static void LogError(object message, UnityEngine.Object context)
	{
	}

	[MethodImpl(256)]
	public static void LogException(Exception message)
	{
	}

	[MethodImpl(256)]
	public static void LogException(Exception message, UnityEngine.Object context)
	{
	}

	public static int convertEndian(int n)
	{
		return 0;
	}

	public static Sequence DoAfter(float time, Action action)
	{
		return null;
	}

	[MethodImpl(256)]
	public static float Distance(this in Vector3 a, in Vector3 b)
	{
		return 0f;
	}

	[MethodImpl(256)]
	public static float Distance(this in Vector2 a, in Vector2 b)
	{
		return 0f;
	}

	[MethodImpl(256)]
	public static float Distance(this in Vector2Int a, in Vector2Int b)
	{
		return 0f;
	}

	[MethodImpl(256)]
	public static float Distance(int ax, int ay, int bx, int by)
	{
		return 0f;
	}

	[MethodImpl(256)]
	public static int DistanceSqr(this in Vector2Int a, in Vector2Int b)
	{
		return 0;
	}

	[MethodImpl(256)]
	public static int DistanceSqr(int ax, int ay, int bx, int by)
	{
		return 0;
	}

	public static string XmlSerializeToString(this object objectInstance)
	{
		return null;
	}

	public static T XmlDeserializeFromString<T>(this string objectData)
	{
		return default(T);
	}

	public static object XmlDeserializeFromString(this string objectData, Type type)
	{
		return null;
	}

	public static int GetNumber(this string numberInclude)
	{
		return 0;
	}

	public static string ToMoneyNum(this string moneyInclude)
	{
		return null;
	}

	public static string ToMoneyNum(this int money)
	{
		return null;
	}

	public static string ToMoneyNum(this long money)
	{
		return null;
	}

	public static string ToMoneyNum(this decimal money)
	{
		return null;
	}

	public static T Clone<T>(T source)
	{
		return default(T);
	}

	public static System.Random GetRandom(int? seed = null)
	{
		return null;
	}

	public static void ClearSeed()
	{
	}

	public static float GetRandomValue(int? seed = null)
	{
		return 0f;
	}

	public static int GetRandomRange(int start, int end, int? seed = null)
	{
		return 0;
	}

	public static float GetRandomRange(float start, float end, int? seed = null)
	{
		return 0f;
	}

	public static int GetWeightedRandom(this int[] weights, int sum = -1, int? seed = null)
	{
		return 0;
	}

	public static int GetWeightedRandom(this float[] weights, float sum = -1f, int? seed = null)
	{
		return 0;
	}

	public static T Pick<T>(this List<T> lst, int? seed = null)
	{
		return default(T);
	}

	public static T Pick<T>(this T[] arr, int? seed = null)
	{
		return default(T);
	}

	public static T First<T>(this T[] arr) where T : struct
	{
		return default(T);
	}

	public static T First<T>(this List<T> lst) where T : struct
	{
		return default(T);
	}

	public static T Last<T>(this T[] arr) where T : struct
	{
		return default(T);
	}

	public static T Last<T>(this List<T> lst) where T : struct
	{
		return default(T);
	}

	public static int GetIndex<T>(this List<T> lst, T val)
	{
		return 0;
	}

	public static int GetIndex<T>(this T[] arr, T val)
	{
		return 0;
	}

	public static int GetCount<T>(this List<T> lst, T val)
	{
		return 0;
	}

	public static int GetCount<T>(this T[] arr, T val)
	{
		return 0;
	}

	public static void ForEach<T>(this T[] arr, Action<T> action)
	{
	}

	public static T Find<T>(this T[] arr, Predicate<T> match)
	{
		return default(T);
	}

	public static int FindIndex<T>(this T[] arr, Predicate<T> match)
	{
		return 0;
	}

	public static bool Any<T>(this T[] arr, Predicate<T> match)
	{
		return false;
	}

	public static void Fill<T>(this T[] arr, T value)
	{
	}

	public static T FirstOrDefaultNoAlloc<T>(this List<T> list)
	{
		return default(T);
	}

	public static T FirstOrDefaultNoAlloc<T>(this List<T> list, Func<T, bool> predicate)
	{
		return default(T);
	}

	public static T LastOrDefaultNoAlloc<T>(this List<T> list, Func<T, bool> predicate)
	{
		return default(T);
	}

	public static T FirstOrDefaultNoAlloc<T>(this T[] arr)
	{
		return default(T);
	}

	public static T FirstOrDefaultNoAlloc<T>(this T[] arr, Func<T, bool> predicate)
	{
		return default(T);
	}

	public static int LowerBound<T>(this List<T> list, T item)
	{
		return 0;
	}

	public static int LowerBound<T>(this List<T> list, T item, IComparer<T> comparer)
	{
		return 0;
	}

	public static int UpperBound<T>(this List<T> list, T item)
	{
		return 0;
	}

	public static int UpperBound<T>(this List<T> list, T item, IComparer<T> comparer)
	{
		return 0;
	}

	public static void MakeOriginSize(this Image image, float scale = 1f)
	{
	}

	public static void MakeOriginSizeXOnly(this Image image, float scale = 1f)
	{
	}

	public static void MakeOriginSizeYOnly(this Image image, float scale = 1f)
	{
	}

	public static void MakeRatioSizeX(this Image image, float x)
	{
	}

	public static void MakeRatioSizeY(this Image image, float y)
	{
	}

	public static void SetAlpha(this Image image, float alpha)
	{
	}

	public static void SetAlpha(this SpriteRenderer renderer, float alpha)
	{
	}

	public static void SetAlpha(this Text text, float alpha)
	{
	}

	public static Color Multiply(this Color color, float value)
	{
		return default(Color);
	}

	public static string MultiplyColor(this string color, float value)
	{
		return null;
	}

	public static void SetLayer(this GameObject parent, int layer, bool includeChildren = false)
	{
	}

	public static float GetArrowAngle(Vector2 from, Vector2 to)
	{
		return 0f;
	}

	public static float GetAngle(Vector2 dir)
	{
		return 0f;
	}

	public static Vector2 GetArrowVector(Vector2 from, Vector2 to)
	{
		return default(Vector2);
	}

	public static void ToClean(this IDisposable disposable, List<IDisposable> lst)
	{
	}

	public static Delegate CreateDelegate(this MethodInfo methodInfo, object target)
	{
		return null;
	}

	public static Color SetAlpha(this Color color, float alpha)
	{
		return default(Color);
	}

	public static string SHA256Hash(string text)
	{
		return null;
	}

	public static Color ToColor(this string s)
	{
		return default(Color);
	}

	public static Color? ExtractColor(this string coloredText)
	{
		return null;
	}

	public static string ToHex(this Color c, bool withSharp = true)
	{
		return null;
	}

	public static string ToHexWithAlpha(this Color c, bool withSharp = true)
	{
		return null;
	}

	public static string TryColoring(this string val, Color? color)
	{
		return null;
	}

	public static string Coloring(this string val, Color color)
	{
		return null;
	}

	public static string Coloring(this string val, string color)
	{
		return null;
	}

	public static string Sizing(this string val, int size)
	{
		return null;
	}

	public static string RemoveColor(this string val)
	{
		return null;
	}

	public static bool Contains<T>(this T[] arr, T value)
	{
		return false;
	}

	public static bool Contains(this int state, int stateToFind)
	{
		return false;
	}

	public static Color Alpha(this Color color, float a)
	{
		return default(Color);
	}

	public static Color ColorFrom(uint color)
	{
		return default(Color);
	}

	public static Color ColorFrom(long color)
	{
		return default(Color);
	}

	public static uint ToColor(this Color32 c)
	{
		return 0u;
	}

	public static uint ToColor(this Color c)
	{
		return 0u;
	}

	public static string ToPrettyFormat(this TimeSpan span)
	{
		return null;
	}

	public static string ToPrettyFormat2(this TimeSpan span)
	{
		return null;
	}

	public static string ToPrettyFormat3(this TimeSpan span)
	{
		return null;
	}

	public static string ToPrettyFormat4(this TimeSpan span)
	{
		return null;
	}

	public static string ToPrettyFormat5(this TimeSpan span)
	{
		return null;
	}

	public static bool HasParameter(this Animator animator, string paramName)
	{
		return false;
	}

	public static bool HasParameter(this Animator animator, int paramNameHash)
	{
		return false;
	}

	public static void ClearAnimParamCaches()
	{
	}

	public static bool IsState(this Animator animator, string name, int layerIndex = 0)
	{
		return false;
	}

	public static float AdjustMoveAngle(float angle)
	{
		return 0f;
	}

	public static int GetMoveAngleIndex(float angle)
	{
		return 0;
	}

	public static byte[] ToByteArray(BitArray bits, int len)
	{
		return null;
	}

	public static int Pow(this int n, int p)
	{
		return 0;
	}

	public static float Pow(this float n, float p)
	{
		return 0f;
	}

	public static int ToInt(this string str, int defaultValue = 0)
	{
		return 0;
	}

	public static float ToFloat(this string str, float defaultValue = 0f)
	{
		return 0f;
	}

	public static bool ToBool(this string str, bool defaultValue = false)
	{
		return false;
	}

	public static string ToSignedString(this int val)
	{
		return null;
	}

	public static string ToSignedString(this long val)
	{
		return null;
	}

	public static string ToSignedString(this float val)
	{
		return null;
	}

	public static string ToSignedString(this string val)
	{
		return null;
	}

	public static string GetTimeStamp()
	{
		return null;
	}

	public static string TryToMagnify(this string str, float mag = 1f, float baseValue = 0f, float max = -1f)
	{
		return null;
	}

	public static string Magnify(this float value, float mag = 1f, float baseValue = 0f, float max = -1f, int digit = -1, bool inverse = false)
	{
		return null;
	}

	public static bool IsPointerOverUIObject()
	{
		return false;
	}

	public static bool IsPointerOver(Transform target)
	{
		return false;
	}

	public static bool IsPointerOver_New(Transform target)
	{
		return false;
	}

	public static bool IsPointerOverChildOf(Transform target)
	{
		return false;
	}

	private static List<T> GetRaycastResults<T>(List<Vector2> positions)
	{
		return null;
	}

	public static T GetCurrentSelectedObject<T>()
	{
		return default(T);
	}

	public static DateTime ConvertLongToDate(long input)
	{
		return default(DateTime);
	}

	public static void SetLocalScale(this GameObject go, Vector3 scale)
	{
	}

	public static void SetLocalScaleOne(this GameObject go)
	{
	}

	public static void SetColor(this Image image, Color color)
	{
	}

	public static void SetColorWithoutAlpha(this Image image, Color color)
	{
	}

	public static string MakeDateString(long time)
	{
		return null;
	}

	public static Vector2 Size(this RectTransform rectTransform)
	{
		return default(Vector2);
	}

	public static string ToSimpleTime(this float time)
	{
		return null;
	}

	public static bool IsNull(this UnityEngine.Object obj)
	{
		return false;
	}

	public static bool IsFakeNull(this UnityEngine.Object obj)
	{
		return false;
	}

	public static bool IsAssigned(this UnityEngine.Object obj)
	{
		return false;
	}

	public static LayerMask Layers(params string[] args)
	{
		return default(LayerMask);
	}

	public static void Shuffle<T>(this IList<T> list, int? seed = null)
	{
	}

	public static void Distinct<T>(this IList<T> list)
	{
	}

	private static void DistinctImplClass<T>(IList<T> list, int start)
	{
	}

	private static void DistinctImplStruct<T>(IList<T> list, int start)
	{
	}

	public static DamageInfo.Type ToEnum(this string text, DamageInfo.Type @default = DamageInfo.Type.NormalPhysical)
	{
		return default(DamageInfo.Type);
	}

	public static BoltInfo.BoltType ToEnum(this string text, BoltInfo.BoltType @default = BoltInfo.BoltType.None)
	{
		return default(BoltInfo.BoltType);
	}

	public static Ease ToEnum(this string text, Ease @default = Ease.Unset)
	{
		return default(Ease);
	}

	public static RangeInfo.RangeType ToEnum(this string text, RangeInfo.RangeType @default = RangeInfo.RangeType.None)
	{
		return default(RangeInfo.RangeType);
	}

	public static ResourceSkill.SkillTrigger ToEnum(this string text, ResourceSkill.SkillTrigger @default = ResourceSkill.SkillTrigger.TargetIsNotInBuffRange)
	{
		return default(ResourceSkill.SkillTrigger);
	}

	public static RangeInfo.Strategy ToEnum(this string text, RangeInfo.Strategy @default = RangeInfo.Strategy.Near)
	{
		return default(RangeInfo.Strategy);
	}

	public static DamageInfo.BaseAtkSkillType ToEnum(this string text, DamageInfo.BaseAtkSkillType @default = DamageInfo.BaseAtkSkillType.None)
	{
		return default(DamageInfo.BaseAtkSkillType);
	}

	public static ResourceItem.EquipType ToEnum(this string text, ResourceItem.EquipType @default = ResourceItem.EquipType.None)
	{
		return default(ResourceItem.EquipType);
	}

	public static BuffManager.GimmickStacks ToEnum(this string text, BuffManager.GimmickStacks @default = BuffManager.GimmickStacks.None)
	{
		return default(BuffManager.GimmickStacks);
	}

	public static T ToEnum<T>(this string text, T @default = default(T)) where T : struct, Enum
	{
		return default(T);
	}

	public static T ToEnumIgnoreCase<T>(this string text, T @default = default(T)) where T : struct, Enum
	{
		return default(T);
	}

	public static void SetSprite(this Image image, Sprite sprite, bool disableWhenSpriteNull = true)
	{
	}

	public static string ToRoman(int i)
	{
		return null;
	}

	public static string ToRomanFull(int num)
	{
		return null;
	}

	public static int RomanToInt(string text)
	{
		return 0;
	}

	public static float Round(float value, int digits)
	{
		return 0f;
	}

	public static int RoundToInt(float value, int digits)
	{
		return 0;
	}

	public static void SetPivotAndAnchors(this RectTransform rt, Vector2 v)
	{
	}

	public static bool CheckColor(this Color c, Color c2)
	{
		return false;
	}

	public static float GetScale(int width, int height, CanvasScaler canvasScaler)
	{
		return 0f;
	}

	public static float GetScale()
	{
		return 0f;
	}

	public static Vector2 ScaleResolution(Vector2 target)
	{
		return default(Vector2);
	}

	public static Vector2 UnscaleResolution(Vector2 target)
	{
		return default(Vector2);
	}

	public static Vector2 ClampResolution(Vector2 target, Vector2 panelSize)
	{
		return default(Vector2);
	}

	public static Vector2 ClampResolution_New(Vector2 target, Vector2 panelSize)
	{
		return default(Vector2);
	}

	public static void TextFit(this Text text, bool fitX, bool fitY)
	{
	}

	public static DateTime ParseDate(this string text, DateTime @default = default(DateTime), bool fromServerTime = true)
	{
		return default(DateTime);
	}

	public static DateTime ParseDateWithoutTimeZone(this string text, DateTime @default = default(DateTime))
	{
		return default(DateTime);
	}

	public static TimeSpan RoundToNearestInterval(this TimeSpan timeSpan, TimeSpan roundingInterval)
	{
		return default(TimeSpan);
	}

	public static DateTime ParseDateWithDefaultZero(this string text, bool fromServerTime = true)
	{
		return default(DateTime);
	}

	public static int GetCurrentDateInt()
	{
		return 0;
	}

	public static bool IsDateBetween(DateTime date, DateTime a, DateTime b)
	{
		return false;
	}

	public static Dropdown.OptionData GetValue(this Dropdown dropdown)
	{
		return null;
	}

	private static int Size(this KeySize keySize)
	{
		return 0;
	}

	private static SymmetricAlgorithm GetCipherInstance(KeySize keySize)
	{
		return null;
	}

	public static byte[] AESEncryptCBC(this byte[] inputBytes, KeySize keySize = KeySize.Short)
	{
		return null;
	}

	public static byte[] AESDecryptCBC(this byte[] inputBytes, KeySize keySize = KeySize.Short)
	{
		return null;
	}

	public static string AESEncrypt256(this string inputText)
	{
		return null;
	}

	public static string AESDecrypt256(this string inputText)
	{
		return null;
	}

	public static byte[] AESEncryptWithServerBase(this byte[] buf, byte[] key)
	{
		return null;
	}

	public static string AESEncryptWithServer(this string input, string key)
	{
		return null;
	}

	public static string AESEncryptWithServer(this byte[] buf, byte[] key)
	{
		return null;
	}

	public static string AESEncryptWithServer(this string input)
	{
		return null;
	}

	public static string AESDecryptWithServer(this byte[] input)
	{
		return null;
	}

	private static string AESDecryptWithServer(this byte[] input, string key)
	{
		return null;
	}

	public static string AESDecryptWithServer(this string input)
	{
		return null;
	}

	private static string AESDecryptWithServer(this string input, string key)
	{
		return null;
	}

	private static byte[] HexToByte(string msg)
	{
		return null;
	}

	public static bool CheckName(string name)
	{
		return false;
	}

	public static bool IsChinese(this char c)
	{
		return false;
	}

	public static bool IsJapanese(this char c)
	{
		return false;
	}

	public static string GetKingName(string kingName, int kingPostfix)
	{
		return null;
	}

	public static string GetCastleName(string castleName, int castlePostfix)
	{
		return null;
	}

	public static string GetCurrentGitBranch()
	{
		return null;
	}

	public static string GetBranchSpecificPatchSetFolderName(string currentBranchName)
	{
		return null;
	}

	public static string GetServerTimestamp()
	{
		return null;
	}

	public static void LogAdjust(string token, params (string key, string value)[] keyVals)
	{
	}

	public static void LogAdjustRevenue(string token, float value, string currency, string transactionId = null, params (string key, string value)[] keyVals)
	{
	}

	public static void LogAdjustBuyShopItem(int id, bool isAd = false)
	{
	}

	public static void LogFirebase(string name, params Parameter[] parameters)
	{
	}

	public static void SetScreenFirebase(string screenName, string screenClass)
	{
	}

	public static int GetVersion()
	{
		return 0;
	}

	public static void SetTypeSprite(this Image image, string type, int id = -1, bool scale = false)
	{
	}

	public static string GetProductPrice(string productId, string defaultValue = null)
	{
		return null;
	}

	public static string ReplaceIgnoreCase(this string text, string from, string to)
	{
		return null;
	}

	public static float GetTextWidth(Font font, int fontSize, string text)
	{
		return 0f;
	}

	public static float GetTextHeight(Font font, int fontSize, string text, float areaWidth)
	{
		return 0f;
	}

	public static Canvas GetTopmostCanvas(Component component)
	{
		return null;
	}

	public static Canvas GetTopmostCanvas(this MonoBehaviour obj)
	{
		return null;
	}

	public static string RemoveNewline(this string text, bool replaceWithSpace = false)
	{
		return null;
	}

	public static int AwesomeFloor(float f)
	{
		return 0;
	}

	public static int AwesomeCeil(float f)
	{
		return 0;
	}

	public static int CompareBool(bool a, bool b)
	{
		return 0;
	}

	[CanBeNull]
	public static XmlNode GetChild<T>(this IRecursiveInheritable<T> resource, string key, string path = "") where T : ResourceBase<T>
	{
		return null;
	}

	public static string GetChildText<T>(this IRecursiveInheritable<T> resource, string key, string @default = null, string path = "") where T : ResourceBase<T>
	{
		return null;
	}

	public static bool GetChildBoolean<T>(this IRecursiveInheritable<T> resource, string key, bool @default = false, string path = "") where T : ResourceBase<T>
	{
		return false;
	}

	public static int GetChildInt<T>(this IRecursiveInheritable<T> resource, string key, int @default = -1, string path = "") where T : ResourceBase<T>
	{
		return 0;
	}

	public static float GetChildFloat<T>(this IRecursiveInheritable<T> resource, string key, float @default = -1f, string path = "") where T : ResourceBase<T>
	{
		return 0f;
	}

	public static object[] GetAllFields(this object obj, [CanBeNull] Func<FieldInfo, bool> checkFunc = null)
	{
		return null;
	}

	public static FieldInfo[] GetAllFieldInfos(this Type type, [CanBeNull] Func<FieldInfo, bool> checkFunc = null)
	{
		return null;
	}

	public static bool EqualAsGenericBase(Type t1, Type t2)
	{
		return false;
	}

	public static T GetFieldByName<T>(this object obj, string key)
	{
		return default(T);
	}

	public static void SetFieldByName(this object obj, string key, object value)
	{
	}

	public static T InvokeMethodByName<T>(this object obj, string key, object[] @params = null)
	{
		return default(T);
	}

	public static T GetStaticFieldByName<T>(this Type @class, string name)
	{
		return default(T);
	}

	public static string UpperFirstLetter(this string str)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CShowLoading_003Ed__342<>))]
	public static UniTask<T> ShowLoading<T>(this UniTask<T> task)
	{
		return default(UniTask<T>);
	}

	public static void ShowLoading(this CanvasGroup loadingPopup, bool v)
	{
	}

	public static int GetMaxChildCount(this GridLayoutGroup grid)
	{
		return 0;
	}

	public static float NormalDistributionRandom(float average, float stdDev)
	{
		return 0f;
	}

	public static bool UnderLine(float gradient, float yIntercept, (float, float) coords)
	{
		return false;
	}

	public static string Ellipsis(this string text, int length, int asciiLength, string addIfClamped = "...")
	{
		return null;
	}

	public static IEnumerable<(int, int)> Indexes<T>(this T[,] array)
	{
		return null;
	}

	public static IEnumerable<(int, int, int)> Indexes<T>(this T[,,] array)
	{
		return null;
	}

	public static List<int> Partition(this int x, int count)
	{
		return null;
	}

	public static void AwesomeFade(this CanvasGroup target, float endValue, float duration, Action onComplete = null)
	{
	}

	public static void AwesomeFade(this Image target, float endValue, float duration, Action onComplete = null)
	{
	}

	public static void AwesomeFade(this SpriteRenderer target, float endValue, float duration, Action onComplete = null)
	{
	}

	[IteratorStateMachine(typeof(_003CFadeCoroutine_003Ed__354))]
	private static IEnumerator FadeCoroutine(CanvasGroup target, float endValue, float duration, Action onComplete)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadeCoroutine_003Ed__355))]
	private static IEnumerator FadeCoroutine(Image target, float endValue, float duration, Action onComplete)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadeCoroutine_003Ed__356))]
	private static IEnumerator FadeCoroutine(SpriteRenderer target, float endValue, float duration, Action onComplete)
	{
		return null;
	}

	public static T Find<T>(this IReadOnlyList<T> lst, Predicate<T> match)
	{
		return default(T);
	}

	public static void ReverseByte<T>(this ref Span<byte> span) where T : struct
	{
	}

	public static T GetExtension<T>(this Packet packet) where T : IBufferMessage, new()
	{
		return default(T);
	}

	public static string GetSuperShieldPrefabName(DamageInfo.BlockedBy type)
	{
		return null;
	}

	public static bool IsSpecialDamage(this DamageInfo.Type type)
	{
		return false;
	}

	public static bool IsPhysicalDamage(this DamageInfo.Type type)
	{
		return false;
	}

	public static bool IsMagicDamage(this DamageInfo.Type type)
	{
		return false;
	}

	public static bool IsNormalDamage(this DamageInfo.Type type)
	{
		return false;
	}

	public static bool IsSkillDamage(this DamageInfo.Type type)
	{
		return false;
	}

	public static List<(string, BuffManager.StatType, BuffManager.StatValueType)> GetAllStatTypeNameWithValueType()
	{
		return null;
	}

	public static Dictionary<string, (BuffManager.StatType, BuffManager.StatValueType)> GetAllStatTypeDict()
	{
		return null;
	}

	public static Dictionary<string, BuffManager.StatType> GetAllStatDebuffPerTypeDict()
	{
		return null;
	}

	public static bool IsDefaultItemStat(string key)
	{
		return false;
	}

	public static void DereferenceUIObjects(this MonoBehaviour mono)
	{
	}

	public static int GetDecimalDigit(this float num, int max = 10)
	{
		return 0;
	}

	public static void AddAllKVPFrom<T1, T2>(this IDictionary<T1, T2> dest, IDictionary<T1, T2> source)
	{
	}

	public static Sequence DoFlash(this Image image)
	{
		return null;
	}

	public static void ScrollToIndex(this LayoutGroup layout, int index)
	{
	}

	public static string LocalizePvPBotCastleName(string name, string postfix)
	{
		return null;
	}

	public static string LocalizePvPBotKingName(string name, string postfix)
	{
		return null;
	}

	public static string RemoveJapaneseLineBreakingTexts(this string text)
	{
		return null;
	}

	public static Dictionary<string, float> GetRentedNumericKeyValue(string key, float value)
	{
		return null;
	}

	public static Dictionary<string, float> GetRentedNumericKeyValue(string key1, float value1, string key2, float value2)
	{
		return null;
	}

	public static int GetRandomRelativePrime(int num, int? seed = null)
	{
		return 0;
	}

	public static bool IsRelativePrime(int a, int b)
	{
		return false;
	}

	public static double Lerp(double a, double b, float t)
	{
		return 0.0;
	}

	public static long BitShiftSetValue(this ref long originalValue, int index, bool value)
	{
		return 0L;
	}

	public static bool BitShiftGetValue(this long value, int index)
	{
		return false;
	}

	public static List<Transform> GetAllChildrenRecursively(this Transform transform)
	{
		return null;
	}

	public static string RemoveWrapperXMLTag(this string str)
	{
		return null;
	}

	public static string SerializeXML<T>(this T obj, bool removeWrapper = true)
	{
		return null;
	}

	public static T DeserializeXML<T>(this string str)
	{
		return default(T);
	}

	public static T[] DeserializeXMLArray<T>(this string str)
	{
		return null;
	}

	public static string GetWrapperTagName(this string str)
	{
		return null;
	}

	public static string[] SplitXmlArrayString(this string str)
	{
		return null;
	}

	public static void SetupUI(GameObject gameObject, IEnumerable<SpriteRenderer> spriteRenderers, bool maskable, Action<SpriteRenderer, Image> action = null, bool withFrameAnimation = true)
	{
	}

	public static void Fit(this UIFitter[] fitters)
	{
	}

	public static void Fit(this List<UIFitter> fitters)
	{
	}

	[MethodImpl(256)]
	public static bool Approximately(float a, float b)
	{
		return false;
	}
}
