using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DressOnCharacterDropZone : MonoBehaviour, IDropHandler
{
    public Image dressOverlayImage;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
            return;

        DraggableDressItem item = eventData.pointerDrag.GetComponent<DraggableDressItem>();

        if (item == null || item.dressSprite == null || dressOverlayImage == null)
            return;

        dressOverlayImage.sprite = item.dressSprite;

        Color c = dressOverlayImage.color;
        c.a = 1f;
        dressOverlayImage.color = c;

        item.ReturnToStart();
    }
}