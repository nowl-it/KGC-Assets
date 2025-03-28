using UnityEngine;

public abstract class ArtifactCraftTabBase : MonoBehaviour
{
	public abstract void Init();

	public abstract void OnClickArtifact(DraggableArtifactCard artifactCard);

	public abstract void ReloadCost();

	public abstract void ReloadActionButtonInteractable();

	public abstract void OnClickSlot(ArtifactCraftSlot slot);

	public abstract void Clear();
}
