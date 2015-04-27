using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Item 
{
	public string name;
	public Sprite icon;
	public bool isActive;
	public Sprite activeIcon;
//	public string type;
//	public string rarity;
//	public bool isChampion;
//	public Button.ButtonClickedEvent thingToDo;
}

public class CreateArmouryList : MonoBehaviour 
{
	public GameObject armouryButton;
	public List<Item> itemList;

	public Transform contentPanel;

	void Start () 
	{
		PopulateList ();
	}

	void PopulateList ()
	{
		foreach (var item in itemList) 
		{
			GameObject newButton = Instantiate (armouryButton) as GameObject;
			ArmouryButtonScript button = newButton.GetComponent <ArmouryButtonScript> ();
			button.nameLabel.text = item.name;
			button.icon.sprite = item.icon;
//			button.championIcon.SetActive (item.isChampion);
//			button.typeLabel.text = item.type;
//			button.rarityLabel.text = item.rarity;
//		    button.button.onClick = item.thingToDo;
			newButton.transform.SetParent (contentPanel);
		}
	}
}

