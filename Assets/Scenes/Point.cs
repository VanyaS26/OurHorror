using UnityEngine;
using System;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Point_Item")] 

public class Point : ScriptableObject, IItemInterface
{
	public GameObject Prefab;
	[SerializeField]
	private Sprite sprite;

	public Sprite Sprite { get { return sprite; } set { sprite = value; } }

	public string Name;
	[TextArea]
	public String Description;

	public void GetCharacter()
	{
		throw new System.NotImplementedException();
	}
}