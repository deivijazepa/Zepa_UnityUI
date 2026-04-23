using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CanvasGroup))]
public class DraggableDressItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Sprite dressSprite;

    private RectTransform rectTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;

    private Transform originalParent;
    private Vector2 originalPosition;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        originalPosition = rectTransform.anchoredPosition;

        canvasGroup.blocksRaycasts = false;
        transform.SetParent(canvas.transform, true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    public void ReturnToStart()
    {
        transform.SetParent(originalParent, true);
        rectTransform.anchoredPosition = originalPosition;
    }
}