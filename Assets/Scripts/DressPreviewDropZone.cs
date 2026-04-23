using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DressPreviewDropZone : MonoBehaviour, IDropHandler
{
    public Image previewImage;

    public void OnDrop(PointerEventData eventData)
    {
        DraggableDressItem item = eventData.pointerDrag.GetComponent<DraggableDressItem>();

        if (item != null && item.dressSprite != null)
        {
            previewImage.sprite = item.dressSprite;
            item.ReturnToStart();
        }
    }
}