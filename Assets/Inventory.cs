using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.UIElements;
using Unity.VisualScripting;

public class Inventory : MonoBehaviour
{
	[SerializeField]
	private Transform slotsParent;
	public List<SlotScript> slots = new List<SlotScript>();
	public void Start()
	{
		foreach (Transform child in slotsParent)
		{
			SlotScript slot = child.GetComponent<SlotScript>();
			if (slot != null)
			{
				slots.Add(slot);
			}
		}
	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Item"))
		{
			IItemInterface item = GetComponent<IItemInterface>();
			if (item != null)
			{
				AddItem(item);
				Destroy(other.gameObject);
			}
		}
	}
	public void AddItem(IItemInterface newItem)
	{
		foreach (SlotScript slot in slots)
		{
			if (slot.itemInterface == null) 
			{
				slot.itemInterface = newItem;
				slot.Image.sprite = newItem.Sprite; 
				slot.Image.enabled = true;
				return;
			}
		}
	}
}
