using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.U2D;

public class SimpleAssetDB : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SimpleAssetDB _003C_003E4__this;

		private AddressableAsyncExtensions.AsyncOperationHandleAwaiter<IResourceLocator> _003C_003Eu__1;

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
	private struct _003COnSpriteAtlasRequested_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SimpleAssetDB _003C_003E4__this;

		public string name;

		public Action<SpriteAtlas> bindAction;

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

	private static SimpleAssetDB _instance;

	public Material spriteMaterial;

	public Material[] materials;

	private Dictionary<string, int> _materialDict;

	public Font[] fonts;

	private Dictionary<string, int> _fontDict;

	private Dictionary<string, AsyncOperationHandle<GameObject>> _gameObjectHandlers;

	private Dictionary<string, AsyncOperationHandle<Sprite>> _spriteHandlers_destroy;

	private Dictionary<string, AsyncOperationHandle<Material>> _materialHandlers_destroy;

	private Dictionary<string, AsyncOperationHandle<Shader>> _shaderHandlers_destroy;

	private Dictionary<string, AsyncOperationHandle<GameObject>> _gameObjectHandlers_destroy;

	private Dictionary<string, AsyncOperationHandle<SpriteAtlas>> _spriteAtlases_destroy;

	[NonSerialized]
	public bool canLoadSpriteAtlases;

	public static SimpleAssetDB Instance => null;

	public bool isInitialized { get; private set; }

	public void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__20))]
	public void Initialize()
	{
	}

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(_003COnSpriteAtlasRequested_003Ed__22))]
	private void OnSpriteAtlasRequested(string name, Action<SpriteAtlas> bindAction)
	{
	}

	public GameObject GetCharacter(string name, bool dontDestroyOnLoad = false)
	{
		return null;
	}

	public GameObject InstantiateCharacter(ResourceSkin resSkin, string defaultPrefab, Transform transform = null, bool dontDestroyOnLoad = false)
	{
		return null;
	}

	public bool HasCharacter(string name)
	{
		return false;
	}

	public Sprite GetSprite(string name)
	{
		return null;
	}

	public Sprite GetSprite(string name, bool toAddressableSprite)
	{
		return null;
	}

	public Sprite GetSpriteFromAtlas(string atlasName, string name)
	{
		return null;
	}

	public bool HasSprite(string name)
	{
		return false;
	}

	public bool Has<T>(string name)
	{
		return false;
	}

	public bool HasPrefab(string name)
	{
		return false;
	}

	public GameObject GetPrefab(string name, bool dontDestroyOnLoad = false)
	{
		return null;
	}

	public GameObject InstantiatePrefab(string name, Transform transform = null, bool dontDestroyOnLoad = false)
	{
		return null;
	}

	public GameObject InstantiatePrefabWithDefaultName(string name, Transform transform = null, bool dontDestroyOnLoad = false)
	{
		return null;
	}

	public Material GetMaterial(string name)
	{
		return null;
	}

	public Material GetMaterialFromAddressable(string name)
	{
		return null;
	}

	public Shader GetShader(string name)
	{
		return null;
	}

	public SpriteAtlas GetSpriteAtlas(string name)
	{
		return null;
	}

	public Font GetFont(string name)
	{
		return null;
	}

	private T GetAddressable<T>(string name, Dictionary<string, AsyncOperationHandle<T>> dictHandle = null) where T : UnityEngine.Object
	{
		return null;
	}

	public void Release()
	{
	}
}
