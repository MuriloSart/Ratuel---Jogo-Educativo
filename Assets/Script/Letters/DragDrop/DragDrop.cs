using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public GraphicRaycaster raycaster;
    public EventSystem eventSystem;

    public AudioSource selectedSound;

    [ReadOnly] public Transform currentParent;

    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        transform.SetAsLastSibling();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        List<RaycastResult> results = new List<RaycastResult>();

        raycaster.Raycast(eventData, results);

        foreach (RaycastResult result in results)
        {
            GridLayoutGroup grid = result.gameObject.GetComponent<GridLayoutGroup>();
            if (grid != null)
            {
                transform.SetParent(result.gameObject.transform);
                selectedSound.Play();
                return;
            }
        }

        transform.SetParent(transform.root);
    }
}
