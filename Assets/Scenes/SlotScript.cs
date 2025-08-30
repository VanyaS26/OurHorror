using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotScript : MonoBehaviour, IDropHandler
{
    public Image Image;

    private void Start()
    {
        if(itemInterface != null)
        {
            Image.gameObject.SetActive(true);
            Image.sprite = itemInterface.Sprite;
        }
    }

	public IItemInterface itemInterface;

	public void OnDrop(PointerEventData eventData)
    {
        GameObject gameObject = eventData.pointerDrag.gameObject.transform.parent.gameObject;
        SlotScript item = gameObject.GetComponent<SlotScript>();
        if(item != null)
        {
			Image.gameObject.SetActive(true);
			Image.sprite = item.itemInterface.Sprite;
            itemInterface = item.itemInterface;
			item.Image.gameObject.SetActive(false);
		}
    }
}
