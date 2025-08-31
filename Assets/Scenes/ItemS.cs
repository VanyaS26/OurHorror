using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemS : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
	[SerializeField]
	private Canvas Canvas;
	public void OnDrag(PointerEventData eventData)
	{
		rectTransform.anchoredPosition += eventData.delta / Canvas.scaleFactor;
	}

	private RectTransform rectTransform;
	private CanvasGroup canvasGroup;
	private Canvas canvas;

	private void Awake()
	{
		canvas = GetComponentInParent<Canvas>();
		rectTransform = GetComponent<RectTransform>();
		canvasGroup = GetComponent<CanvasGroup>();
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		canvasGroup.blocksRaycasts = false;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		canvasGroup.blocksRaycasts = true;
		gameObject.transform.localPosition = Vector3.zero;
	}
}
