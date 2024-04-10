using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class druganddrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    private Image image;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.color = new Color(0f, 255f, 200f, 0.7f);
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.color = new Color(255f, 255f, 255f, 1f);
        image.raycastTarget = true;
    }
}
