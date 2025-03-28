using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FoolSpriteOutline : MonoBehaviour
{
	public int width;

	public bool betterOutline;

	private SpriteRenderer _spriteRenderer;

	private List<SpriteRenderer> _outlines;

	private static Material _plainWhiteMaterial;

	private static int[][] _directions;

	private void MakeOutline()
	{
	}

	public void ShowOutline(bool show)
	{
	}

	public void ReloadOutline()
	{
	}

	private void RemoveOutline()
	{
	}

	public void ChangeWidth(int width)
	{
	}
}
