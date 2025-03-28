using System;
using UnityEngine;
using UnityEngine.UI;

public class EventPackageArea : MonoBehaviour
{
	[ComponentConnect]
	public Text leftTime;

	[ComponentConnect]
	public GameObject onePanel;

	[ComponentConnect]
	public GameObject twoPanel;

	[ComponentConnect]
	public GameObject threePanel;

	public PackageItem onePackageItem;

	public PackageItem[] twoPackageItem;

	public PackageItem[] threePackageItem;

	private DateTime untilAt;

	public void Init()
	{
	}

	public void Update()
	{
	}
}
