using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("ClockStone/Audio/AudioController")]
public class AudioController : SingletonMonoBehaviour<AudioController>, ISerializationCallbackReceiver
{
	public const string AUDIO_TOOLKIT_VERSION = "8.2";

	public GameObject AudioObjectPrefab;

	public bool Persistent;

	public bool UnloadAudioClipsOnDestroy;

	public bool UsePooledAudioObjects;

	public bool PlayWithZeroVolume;

	public bool EqualPowerCrossfade;

	public float musicCrossFadeTime;

	public float ambienceSoundCrossFadeTime;

	public bool specifyCrossFadeInAndOutSeperately;

	[SerializeField]
	private float _musicCrossFadeTime_In;

	[SerializeField]
	private float _musicCrossFadeTime_Out;

	[SerializeField]
	private float _ambienceSoundCrossFadeTime_In;

	[SerializeField]
	private float _ambienceSoundCrossFadeTime_Out;

	public AudioCategory[] AudioCategories;

	public Playlist[] musicPlaylists;

	[Obsolete]
	public string[] musicPlaylist;

	public bool loopPlaylist;

	public bool shufflePlaylist;

	public bool crossfadePlaylist;

	public float delayBetweenPlaylistTracks;

	protected static PoolableReference<AudioObject> _currentMusicReference;

	protected static PoolableReference<AudioObject> _currentAmbienceReference;

	private string _currentPlaylistName;

	protected AudioListener _currentAudioListener;

	private bool _musicEnabled;

	private bool _ambienceSoundEnabled;

	private bool _soundMuted;

	private bool _categoriesValidated;

	[SerializeField]
	private bool _isAdditionalAudioController;

	[SerializeField]
	private bool _audioDisabled;

	private Dictionary<string, AudioItem> _audioItems;

	private static List<int> _playlistPlayed;

	private static bool _isPlaylistPlaying;

	[SerializeField]
	private float _volume;

	private static double _systemTime;

	private static double _lastSystemTime;

	private static double _systemDeltaTime;

	private List<AudioController> _additionalAudioControllers;

	public AudioController_CurrentInspectorSelection _currentInspectorSelection;

	public bool DisableAudio
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isAdditionalAudioController
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float Volume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool musicEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ambienceSoundEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool soundMuted
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float musicCrossFadeTime_In
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float musicCrossFadeTime_Out
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float ambienceSoundCrossFadeTime_In
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float ambienceSoundCrossFadeTime_Out
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static double systemTime => 0.0;

	public static double systemDeltaTime => 0.0;

	private static AudioObject _currentMusic
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static AudioObject _currentAmbienceSound
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override bool isSingletonObject => false;

	public static AudioObject PlayMusic(string audioID, float volume = 1f, float delay = 0f, float startTime = 0f)
	{
		return null;
	}

	public static AudioObject PlayMusic(string audioID, Vector3 worldPosition, Transform parentObj = null, float volume = 1f, float delay = 0f, float startTime = 0f)
	{
		return null;
	}

	public static AudioObject PlayMusic(string audioID, Transform parentObj, float volume = 1f, float delay = 0f, float startTime = 0f)
	{
		return null;
	}

	public static bool StopMusic()
	{
		return false;
	}

	public static bool StopMusic(float fadeOut)
	{
		return false;
	}

	public static bool PauseMusic(float fadeOut = 0f)
	{
		return false;
	}

	public static bool IsMusicPaused()
	{
		return false;
	}

	public static bool UnpauseMusic(float fadeIn = 0f)
	{
		return false;
	}

	public static AudioObject PlayAmbienceSound(string audioID, float volume = 1f, float delay = 0f, float startTime = 0f)
	{
		return null;
	}

	public static AudioObject PlayAmbienceSound(string audioID, Vector3 worldPosition, Transform parentObj = null, float volume = 1f, float delay = 0f, float startTime = 0f)
	{
		return null;
	}

	public static AudioObject PlayAmbienceSound(string audioID, Transform parentObj, float volume = 1f, float delay = 0f, float startTime = 0f)
	{
		return null;
	}

	public static bool StopAmbienceSound()
	{
		return false;
	}

	public static bool StopAmbienceSound(float fadeOut)
	{
		return false;
	}

	public static bool PauseAmbienceSound(float fadeOut = 0f)
	{
		return false;
	}

	public static bool IsAmbienceSoundPaused()
	{
		return false;
	}

	public static bool UnpauseAmbienceSound(float fadeIn = 0f)
	{
		return false;
	}

	public static int EnqueueMusic(string audioID)
	{
		return 0;
	}

	private Playlist _GetCurrentPlaylist()
	{
		return null;
	}

	public Playlist GetPlaylistByName(string playlistName)
	{
		return null;
	}

	public static string[] GetMusicPlaylist(string playlistName = null)
	{
		return null;
	}

	public static bool SetCurrentMusicPlaylist(string playlistName)
	{
		return false;
	}

	public static AudioObject PlayMusicPlaylist(string playlistName = null)
	{
		return null;
	}

	public static AudioObject PlayNextMusicOnPlaylist()
	{
		return null;
	}

	public static AudioObject PlayPreviousMusicOnPlaylist()
	{
		return null;
	}

	public static bool IsPlaylistPlaying()
	{
		return false;
	}

	public static void ClearPlaylists()
	{
	}

	public static void AddPlaylist(string playlistName, string[] audioItemIDs)
	{
	}

	public static AudioObject Play(string audioID, BattleManager battleManager)
	{
		return null;
	}

	public static AudioObject Play(string audioID, BattleManager battleManager, float volume, float delay = 0f, float startTime = 0f)
	{
		return null;
	}

	public static AudioObject Play(string audioID, BattleManager battleManager, Transform parentObj)
	{
		return null;
	}

	public static AudioObject Play(string audioID, BattleManager battleManager, Transform parentObj, float volume, float delay = 0f, float startTime = 0f)
	{
		return null;
	}

	public static AudioObject Play(string audioID, BattleManager battleManager, Vector3 worldPosition, Transform parentObj = null)
	{
		return null;
	}

	public static AudioObject Play(string audioID, BattleManager battleManager, Vector3 worldPosition, Transform parentObj, float volume, float delay = 0f, float startTime = 0f)
	{
		return null;
	}

	public static AudioObject PlayScheduled(string audioID, double dspTime, Vector3 worldPosition, Transform parentObj = null, float volume = 1f, float startTime = 0f)
	{
		return null;
	}

	public static AudioObject PlayAfter(string audioID, AudioObject playingAudio, double deltaDspTime = 0.0, float volume = 1f, float startTime = 0f)
	{
		return null;
	}

	public static bool Stop(string audioID, float fadeOutLength)
	{
		return false;
	}

	public static bool Stop(string audioID)
	{
		return false;
	}

	public static void StopAll(float fadeOutLength)
	{
	}

	public static void StopAll()
	{
	}

	public static void PauseAll(float fadeOutLength = 0f)
	{
	}

	public static void UnpauseAll(float fadeInLength = 0f)
	{
	}

	public static void PauseCategory(string categoryName, float fadeOutLength = 0f)
	{
	}

	public static void UnpauseCategory(string categoryName, float fadeInLength = 0f)
	{
	}

	public static void StopCategory(string categoryName, float fadeOutLength = 0f)
	{
	}

	public static bool IsPlaying(string audioID)
	{
		return false;
	}

	public static List<AudioObject> GetPlayingAudioObjects(string audioID, bool includePausedAudio = false)
	{
		return null;
	}

	public static List<AudioObject> GetPlayingAudioObjectsInCategory(string categoryName, bool includePausedAudio = false)
	{
		return null;
	}

	public static List<AudioObject> GetPlayingAudioObjects(bool includePausedAudio = false)
	{
		return null;
	}

	public static int GetPlayingAudioObjectsCount(string audioID, bool includePausedAudio = false)
	{
		return 0;
	}

	public static void EnableMusic(bool b)
	{
	}

	public static void EnableAmbienceSound(bool b)
	{
	}

	public static void MuteSound(bool b)
	{
	}

	public static bool IsMusicEnabled()
	{
		return false;
	}

	public static bool IsAmbienceSoundEnabled()
	{
		return false;
	}

	public static bool IsSoundMuted()
	{
		return false;
	}

	public static AudioListener GetCurrentAudioListener()
	{
		return null;
	}

	public static AudioObject GetCurrentMusic()
	{
		return null;
	}

	public static AudioObject GetCurrentAmbienceSound()
	{
		return null;
	}

	public static AudioCategory GetCategory(string name)
	{
		return null;
	}

	public static void SetCategoryVolume(string name, float volume)
	{
	}

	public static float GetCategoryVolume(string name)
	{
		return 0f;
	}

	public static void FadeOutCategory(string name, float fadeOutLength, float startToFadeTime = 0f)
	{
	}

	public static void FadeInCategory(string name, float fadeInTime, bool stopCurrentFadeOut = true)
	{
	}

	public static void SetGlobalVolume(float volume)
	{
	}

	public static float GetGlobalVolume()
	{
		return 0f;
	}

	public static AudioCategory NewCategory(string categoryName)
	{
		return null;
	}

	public static void RemoveCategory(string categoryName)
	{
	}

	public static void AddToCategory(AudioCategory category, AudioItem audioItem)
	{
	}

	public static AudioItem AddToCategory(AudioCategory category, AudioClip audioClip, string audioID)
	{
		return null;
	}

	public static bool RemoveAudioItem(string audioID)
	{
		return false;
	}

	public static bool IsValidAudioID(string audioID)
	{
		return false;
	}

	public static AudioItem GetAudioItem(string audioID)
	{
		return null;
	}

	public static void DetachAllAudios(GameObject gameObjectWithAudios)
	{
	}

	public static float GetAudioItemMaxDistance(string audioID)
	{
		return 0f;
	}

	public void UnloadAllAudioClips()
	{
	}

	private void _ApplyVolumeChange()
	{
	}

	internal AudioItem _GetAudioItem(string audioID)
	{
		return null;
	}

	protected AudioObject _PlayMusic(string audioID, float volume, float delay, float startTime)
	{
		return null;
	}

	protected AudioObject _PlayAmbienceSound(string audioID, float volume, float delay, float startTime)
	{
		return null;
	}

	protected bool _StopMusic(float fadeOutLength)
	{
		return false;
	}

	protected bool _PauseMusic(float fadeOut)
	{
		return false;
	}

	protected bool _StopAmbienceSound(float fadeOutLength)
	{
		return false;
	}

	protected bool _PauseAmbienceSound(float fadeOut)
	{
		return false;
	}

	protected AudioObject _PlayMusic(string audioID, Vector3 position, Transform parentObj, float volume, float delay, float startTime)
	{
		return null;
	}

	protected AudioObject _PlayAmbienceSound(string audioID, Vector3 position, Transform parentObj, float volume, float delay, float startTime)
	{
		return null;
	}

	protected int _EnqueueMusic(string audioID)
	{
		return 0;
	}

	protected AudioObject _PlayMusicPlaylist()
	{
		return null;
	}

	private AudioObject _PlayMusicTrackWithID(int nextTrack, float delay, bool addToPlayedList)
	{
		return null;
	}

	internal AudioObject _PlayNextMusicOnPlaylist(float delay)
	{
		return null;
	}

	internal AudioObject _PlayPreviousMusicOnPlaylist(float delay)
	{
		return null;
	}

	private void _ResetLastPlayedList()
	{
	}

	protected int _GetNextMusicTrack()
	{
		return 0;
	}

	protected int _GetPreviousMusicTrack()
	{
		return 0;
	}

	private int _GetPreviousMusicTrackShuffled()
	{
		return 0;
	}

	private void _RemoveLastPlayedOnList()
	{
	}

	private int _GetNextMusicTrackShuffled()
	{
		return 0;
	}

	private int _GetNextMusicTrackInOrder()
	{
		return 0;
	}

	private int _GetPreviousMusicTrackInOrder()
	{
		return 0;
	}

	protected AudioObject _PlayAsSound(string audioID, float volume, Vector3 worldPosition, Transform parentObj, float delay, float startTime, bool playWithoutAudioObject, double dspTime = 0.0, AudioObject useExistingAudioObject = null)
	{
		return null;
	}

	protected AudioObject _PlayAsMusicOrAmbienceSound(string audioID, float volume, Vector3 worldPosition, Transform parentObj, float delay, float startTime, bool playWithoutAudioObject, double dspTime = 0.0, AudioObject useExistingAudioObject = null, float startVolumeMultiplier = 1f)
	{
		return null;
	}

	protected AudioObject _PlayEx(string audioID, float volume, Vector3 worldPosition, Transform parentObj, float delay, float startTime, bool playWithoutAudioObject, double dspTime = 0.0, AudioObject useExistingAudioObject = null, bool playAsMusicOrAmbienceSound = false, float startVolumeMultiplier = 1f)
	{
		return null;
	}

	public AudioObject PlayAudioItem(AudioItem sndItem, float volume, Vector3 worldPosition, Transform parentObj = null, float delay = 0f, float startTime = 0f, bool playWithoutAudioObject = false, AudioObject useExistingAudioObj = null, double dspTime = 0.0, bool playAsMusicOrAmbienceSound = false, float startVolumeMultiplier = 1f)
	{
		return null;
	}

	internal AudioCategory _GetCategory(string name)
	{
		return null;
	}

	private void Update()
	{
	}

	private static void _UpdateSystemTime()
	{
	}

	protected override void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void AwakeSingleton()
	{
	}

	protected void _ValidateCategories()
	{
	}

	protected void _InvalidateCategories()
	{
	}

	public void InitializeAudioItems()
	{
	}

	private void _InitializeAudioItems(AudioController audioController)
	{
	}

	private void _RegisterAdditionalAudioController(AudioController ac)
	{
	}

	private void _SyncCategoryVolumes(AudioController toSync, AudioController syncWith)
	{
	}

	private void _UnregisterAdditionalAudioController(AudioController ac)
	{
	}

	private static List<AudioCategory> _GetAllCategories(string name)
	{
		return null;
	}

	public AudioObject PlayAudioSubItem(AudioSubItem subItem, float volume, Vector3 worldPosition, Transform parentObj, float delay, float startTime, bool playWithoutAudioObject, AudioObject useExistingAudioObj, double dspTime = 0.0, bool playAsMusicOrAmbienceSound = false, float startVolumeMultiplier = 1f)
	{
		return null;
	}

	private AudioController _GetAudioController(AudioSubItem subItem)
	{
		return null;
	}

	internal void _NotifyPlaylistTrackCompleteleyPlayed(AudioObject audioObject)
	{
	}

	private void _ValidateAudioObjectPrefab(GameObject audioPrefab)
	{
	}

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	private void _SetDefaultCurrentPlaylist()
	{
	}
}
