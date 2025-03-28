using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AudioCategory
{
	public string Name;

	private AudioCategory _parentCategory;

	private AudioFader _audioFader;

	[SerializeField]
	private string _parentCategoryName;

	public GameObject AudioObjectPrefab;

	public AudioItem[] AudioItems;

	[SerializeField]
	private float _volume;

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

	public float VolumeTotal => 0f;

	public AudioCategory parentCategory
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private AudioFader audioFader => null;

	public AudioController audioController { get; set; }

	public bool isFadingIn => false;

	public bool isFadingOut => false;

	public bool isFadeOutComplete => false;

	public AudioCategory(AudioController audioController)
	{
	}

	public GameObject GetAudioObjectPrefab()
	{
		return null;
	}

	internal void _AnalyseAudioItems(Dictionary<string, AudioItem> audioItemsDict)
	{
	}

	internal int _GetIndexOf(AudioItem audioItem)
	{
		return 0;
	}

	private void _ApplyVolumeChange()
	{
	}

	private bool _IsCategoryParentOf(AudioCategory toTest, AudioCategory parent)
	{
		return false;
	}

	public void UnloadAllAudioClips()
	{
	}

	public void FadeIn(float fadeInTime, bool stopCurrentFadeOut = true)
	{
	}

	public void FadeOut(float fadeOutLength, float startToFadeTime = 0f)
	{
	}

	private void _UpdateFadeTime()
	{
	}
}
