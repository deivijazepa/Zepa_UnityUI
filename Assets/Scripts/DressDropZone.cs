using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DressDropZone : MonoBehaviour, IDropHandler
{
    public Image bodyImage;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop triggered");

        DraggableDressItem item = eventData.pointerDrag.GetComponent<DraggableDressItem>();

        if (item != null && item.dressSprite != null)
        {
            bodyImage.sprite = item.dressSprite;
            Debug.Log("Body sprite changed to: " + item.dressSprite.name);
            item.ReturnToStart();
        }
        else
        {
            Debug.Log("Drop failed: item or sprite missing");
        }
    }
}