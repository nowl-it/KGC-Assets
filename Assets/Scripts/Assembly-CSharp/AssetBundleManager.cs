using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class AssetBundleManager
{
	public class LoadAssetInfo
	{
		public MonoBehaviour sender;

		public ProgressCallback onProgress;

		public Callback onFinish;

		public Action onAlreadyLoaded;

		public bool loadAll;

		public List<string> assetTargets;
	}

	public delegate void Callback(bool success);

	public delegate void ProgressCallback(float v);

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public AssetBundleManager _003C_003E4__this;

		public LoadAssetInfo loadAssetInfo;

		public string msg;

		internal void _003CLoadAssets_003Eb__3(bool o)
		{
		}

		internal void _003CLoadAssets_003Eb__4(bool o)
		{
		}

		internal void _003CLoadAssets_003Eb__2(bool o)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoad_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleManager _003C_003E4__this;

		public string name;

		private AssetBundle _003Cab_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

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
		public _003CLoad_003Ed__32(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoadAssets_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleManager _003C_003E4__this;

		public LoadAssetInfo loadAssetInfo;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

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
		public _003CLoadAssets_003Ed__27(int _003C_003E1__state)
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
	private struct _003CLoadSingleAsset_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public AssetBundleManager _003C_003E4__this;

		public string assetName;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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
	private struct _003CLoadTargetAsset_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public string name;

		public AssetBundleManager _003C_003E4__this;

		private AssetBundle _003Cab_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

		private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

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

	[CompilerGenerated]
	private sealed class _003CUpdatePatchsetList_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleManager _003C_003E4__this;

		private string _003CpatchsetVersionPath_003E5__2;

		private string _003CpatchsetHashsetPath_003E5__3;

		private UnityWebRequest _003CwwwPatchsetManifest_003E5__4;

		private UnityWebRequest _003CwwwPatchsetVersion_003E5__5;

		private UnityWebRequest _003CwwwHashsetVersion_003E5__6;

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
		public _003CUpdatePatchsetList_003Ed__37(int _003C_003E1__state)
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

	public const string ASSET_HASH_FILE_NAME = "AssetHash.txt";

	public const string PATCH_VERSION_NAME = "PatchVersion.txt";

	private Dictionary<string, AssetBundle> assetBundlesMap;

	private AssetBundle patchsetAssetBundle;

	private AssetBundleManifest patchsetManifest;

	private int _assetsCount;

	private int _succeedCount;

	private ProgressCallback _assetProgress;

	private Callback _assetFinish;

	private bool failure;

	private bool _isFailedUpdatePatchsetList;

	private Dictionary<string, string> _remoteHashes;

	private Dictionary<string, int> _remoteSizes;

	private int totalSize;

	private List<string> _loadedAssets;

	public static AssetBundleManager Instance { get; }

	private List<AssetBundle> assetBundles => null;

	public string persistentDataPath => null;

	public void DownloadAll()
	{
	}

	private void AddAssetBundle(string name, AssetBundle assetBundle)
	{
	}

	private void Clear()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAssets_003Ed__27))]
	public IEnumerator LoadAssets(LoadAssetInfo loadAssetInfo)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoadSingleAsset_003Ed__28))]
	public UniTask<bool> LoadSingleAsset(string assetName)
	{
		return default(UniTask<bool>);
	}

	[AsyncStateMachine(typeof(_003CLoadTargetAsset_003Ed__29))]
	private UniTask<bool> LoadTargetAsset(string name)
	{
		return default(UniTask<bool>);
	}

	public void LoadAssetsAfterOk(LoadAssetInfo loadAssetInfo)
	{
	}

	[IteratorStateMachine(typeof(_003CLoad_003Ed__32))]
	private IEnumerator Load(string name)
	{
		return null;
	}

	public T LoadAsset<T>(string path, string assetBundle = null) where T : UnityEngine.Object
	{
		return null;
	}

	public static void ParseAssetHashFile(string file, out List<string> assets, out List<string> hashes, out List<int> sizes)
	{
		assets = null;
		hashes = null;
		sizes = null;
	}

	private void InitAssetProgress(int count, ProgressCallback progress, Callback finish)
	{
	}

	private void AssetProgress(bool success)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdatePatchsetList_003Ed__37))]
	private IEnumerator UpdatePatchsetList()
	{
		return null;
	}

	private static string CurrentPlatformString()
	{
		return null;
	}

	private static string GetPatchFolder()
	{
		return null;
	}
}
