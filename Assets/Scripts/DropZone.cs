using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public CustomizationOptions customization;

    public void OnDrop(PointerEventData eventData)
    {
        DraggableItem item = eventData.pointerDrag.GetComponent<DraggableItem>();

        if (item != null)
        {
            switch (item.itemIndex)
            {
                case 1:
                    customization.SelectAccessory1();
                    break;
                case 2:
                    customization.SelectAccessory2();
                    break;
                case 3:
                    customization.SelectAccessory3();
                    break;
            }

            item.ReturnToStart();
        }
    }
}