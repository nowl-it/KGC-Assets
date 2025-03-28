using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[RequireComponent(typeof(Image))]
public class AngleCircle : MonoBehaviour
{
	public Image image;

	public float angle;

	public bool flipped;

	public bool update;

	public void Set(float angle, bool flipped)
	{
	}

	public void Reload()
	{
	}
}
