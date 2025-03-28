using UnityEngine;

public interface TouchListener
{
	void OnTouch(TouchPhase phase, Vector2 pt, int touchId = 0);
}
