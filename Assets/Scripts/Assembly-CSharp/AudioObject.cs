using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("ClockStone/Audio/AudioObject")]
[RequireComponent(typeof(AudioSource))]
public class AudioObject : RegisteredComponent
{
	public delegate void AudioEventDelegate(AudioObject audioObject);

	[CompilerGenerated]
	private sealed class _003C_WaitForSecondsThenStop_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float startToFadeTime;

		public AudioObject _003C_003E4__this;

		public float fadeOutLength;

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
		public _003C_WaitForSecondsThenStop_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003C_WaitThenPause_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public AudioObject _003C_003E4__this;

		public int counter;

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
		public _003C_WaitThenPause_003Ed__86(int _003C_003E1__state)
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

	[NonSerialized]
	private AudioCategory _category;

	private AudioSubItem _subItemPrimary;

	private AudioSubItem _subItemSecondary;

	private AudioEventDelegate _completelyPlayedDelegate;

	private int _pauseCoroutineCounter;

	private bool areSources1and2Swapped;

	internal float _volumeExcludingCategory;

	private float _volumeFromPrimaryFade;

	private float _volumeFromSecondaryFade;

	internal float _volumeFromScriptCall;

	private bool _paused;

	private bool _applicationPaused;

	private AudioFader _primaryFader;

	private AudioFader _secondaryFader;

	private double _playTime;

	private double _playStartTimeLocal;

	private double _playStartTimeSystem;

	private double _playScheduledTimeDsp;

	private double _audioObjectTime;

	private bool _IsInactive;

	private bool _stopRequested;

	private bool _finishSequence;

	private int _loopSequenceCount;

	private bool _stopAfterFadeoutUserSetting;

	private bool _pauseWithFadeOutRequested;

	private double _dspTimeRemainingAtPause;

	private AudioController _audioController;

	internal bool _isCurrentPlaylistTrack;

	internal float _audioSource_MinDistance_Saved;

	internal float _audioSource_MaxDistance_Saved;

	internal float _audioSource_SpatialBlend_Saved;

	internal int _lastChosenSubItemIndex;

	private AudioSource _audioSource1;

	private AudioSource _audioSource2;

	private bool _primaryAudioSourcePaused;

	private bool _secondaryAudioSourcePaused;

	private const float VOLUME_TRANSFORM_POWER = 1.6f;

	public string audioID { get; internal set; }

	public AudioCategory category
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public AudioSubItem subItem
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public bool isPlayedAsMusicOrAmbienceSound { get; internal set; }

	public AudioItem audioItem => null;

	public AudioEventDelegate completelyPlayedDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float volume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float volumeItem
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float volumeTotal => 0f;

	public float volumeTotalWithoutFade => 0f;

	public double playCalledAtTime => 0.0;

	public double startedPlayingAtTime => 0.0;

	public float timeUntilEnd => 0f;

	public double scheduledPlayingAtDspTime
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public float clipLength => 0f;

	public float audioTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool isFadingOut => false;

	public bool isFadeOutComplete => false;

	public bool isFadingOutOrScheduled => false;

	public bool isFadingIn => false;

	public float pitch
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float pan
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public double audioObjectTime => 0.0;

	public bool stopAfterFadeOut
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public AudioSource primaryAudioSource => null;

	public AudioSource secondaryAudioSource => null;

	internal float _volumeFromCategory => 0f;

	internal float _volumeWithCategory => 0f;

	private float _stopClipAtTime => 0f;

	private float _startClipAtTime => 0f;

	private bool _shouldStopIfPrimaryFadedOut => false;

	public void FadeIn(float fadeInTime)
	{
	}

	public void PlayScheduled(double dspTime)
	{
	}

	public void PlayAfter(string audioID, double deltaDspTime = 0.0, float volume = 1f, float startTime = 0f)
	{
	}

	public void PlayNow(string audioID, float delay = 0f, float volume = 1f, float startTime = 0f)
	{
	}

	public void Play(float delay = 0f)
	{
	}

	public void Stop()
	{
	}

	public void Stop(float fadeOutLength)
	{
	}

	public void Stop(float fadeOutLength, float startToFadeTime)
	{
	}

	public void FinishSequence()
	{
	}

	[IteratorStateMachine(typeof(_003C_WaitForSecondsThenStop_003Ed__76))]
	private IEnumerator _WaitForSecondsThenStop(float startToFadeTime, float fadeOutLength)
	{
		return null;
	}

	public void FadeOut(float fadeOutLength)
	{
	}

	public void FadeOut(float fadeOutLength, float startToFadeTime)
	{
	}

	public void Pause()
	{
	}

	public void Pause(float fadeOutTime)
	{
	}

	private void _PauseNow()
	{
	}

	public void Unpause()
	{
	}

	public void Unpause(float fadeInTime)
	{
	}

	private void _UnpauseNow()
	{
	}

	[IteratorStateMachine(typeof(_003C_WaitThenPause_003Ed__86))]
	private IEnumerator _WaitThenPause(float waitTime, int counter)
	{
		return null;
	}

	private void _PauseAudioSources()
	{
	}

	public bool IsPaused(bool returnTrueIfStillFadingOut = true)
	{
		return false;
	}

	public bool IsPlaying()
	{
		return false;
	}

	public bool IsPrimaryPlaying()
	{
		return false;
	}

	public bool IsSecondaryPlaying()
	{
		return false;
	}

	public void SwitchAudioSources()
	{
	}

	private void _SwitchValues<T>(ref T v1, ref T v2)
	{
	}

	protected override void Awake()
	{
	}

	private void _CreateSecondAudioSource()
	{
	}

	private void _Set0()
	{
	}

	private void _SetReferences0()
	{
	}

	private void _PlayScheduled(double dspTime)
	{
	}

	private void _PlayDelayed(float delay)
	{
	}

	private void _OnPlay()
	{
	}

	private void _Stop()
	{
	}

	private void Update()
	{
	}

	private void _StartFadeOutIfNecessary()
	{
	}

	private bool _IsAudioLoopSequenceMode()
	{
		return false;
	}

	private bool _ScheduleNextInLoopSequence()
	{
		return false;
	}

	private void _UpdateFadeVolume()
	{
	}

	private float _EqualizePowerForCrossfading(float v)
	{
		return 0f;
	}

	private void OnApplicationPause(bool b)
	{
	}

	private void SetApplicationPaused(bool isPaused)
	{
	}

	public void DestroyAudioObject()
	{
	}

	public static float TransformVolume(float volume)
	{
		return 0f;
	}

	public static float InverseTransformVolume(float volume)
	{
		return 0f;
	}

	public static float TransformPitch(float pitchSemiTones)
	{
		return 0f;
	}

	public static float InverseTransformPitch(float pitch)
	{
		return 0f;
	}

	internal void _ApplyVolumeBoth()
	{
	}

	internal void _ApplyVolumePrimary(float volumeMultiplier = 1f)
	{
	}

	internal void _ApplyVolumeSecondary(float volumeMultiplier = 1f)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void _RestoreOverrideAudioSourceSettings()
	{
	}

	public bool DoesBelongToCategory(string categoryName)
	{
		return false;
	}

	private float _GetRandomLoopSequenceDelay(AudioItem audioItem)
	{
		return 0f;
	}
}
