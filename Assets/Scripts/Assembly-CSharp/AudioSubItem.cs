using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AudioSubItem
{
	public AudioSubItemType SubItemType;

	public float Probability;

	public bool DisableOtherSubitems;

	public string ItemModeAudioID;

	public AudioClip Clip;

	public float Volume;

	public float PitchShift;

	public float Pan2D;

	public float Delay;

	public float RandomPitch;

	public float RandomVolume;

	public float RandomDelay;

	public float ClipStopTime;

	public float ClipStartTime;

	public float FadeIn;

	public float FadeOut;

	public bool RandomStartPosition;

	public List<string> individualSettings;

	private float _summedProbability;

	internal int _subItemID;

	[NonSerialized]
	private AudioItem _item;

	internal float _SummedProbability
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public AudioItem item
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public AudioSubItem()
	{
	}

	public AudioSubItem(AudioSubItem orig, AudioItem item)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
