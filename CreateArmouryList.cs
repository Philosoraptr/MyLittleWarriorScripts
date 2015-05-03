using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateArmouryList : MonoBehaviour 
{
	public GameObject armouryButton;
	public List<Item> itemList = new List<Item>();

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
			button.nameLabel.text = item.itemName;
			button.icon.sprite = item.itemIcon;
			button.activeIcon.SetActive (item.itemIsActive); // this needs to be driven by playerprefs/somewhere else
			newButton.transform.SetParent (contentPanel);

			//			button.typeLabel.text = item.type;
			//			button.rarityLabel.text = item.rarity;
			//		    button.button.onClick = item.thingToDo;
		}
	}
}

