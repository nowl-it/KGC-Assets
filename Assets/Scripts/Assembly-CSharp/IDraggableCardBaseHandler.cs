using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public interface IDraggableCardBaseHandler<T>
{
	DraggableCardBase<T> currentDraggingCard { get; set; }

	void ReloadAll();

	void SetCardStatus([NotNull] DraggableCardBase<T> card);

	void OnDragIntoSlot([NotNull] DraggableCardBase<T> fromCard, [NotNull] DraggableCardBase<T> toCard, int fromIndex, int toIndex);

	void OnSwapCard([NotNull] DraggableCardBase<T> fromCard, [NotNull] DraggableCardBase<T> toCard, int fromIndex, int toIndex);

	bool IsCardInUse([NotNull] DraggableCardBase<T> card);

	bool CanEquip([NotNull] DraggableCardBase<T> card);

	void OnDragFailed([NotNull] DraggableCardBase<T> card);

	void OnUnEquip([NotNull] DraggableCardBase<T> card, int fromIndex);

	List<DraggableCardBase<T>> GetAllSlots();

	RectTransform GetUnEquipArea();
}
