using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateArmouryList : MonoBehaviour 
{
	public GameObject armouryButton;

	private ItemDatabase itemDatabase;

	public Transform contentPanel;

	void Start () 
	{
		itemDatabase = GameObject.FindGameObjectWithTag ("Item Database").GetComponent<ItemDatabase>();
		PopulateList ();
	}

	void PopulateList ()
	{
		for (int i = 0; i < itemDatabase.items.Count; i++) 
		{
			if(itemDatabase.items[i].itemIsEquipment)
			{
				GameObject newButton = Instantiate (armouryButton) as GameObject;
				ArmouryButtonScript button = newButton.GetComponent <ArmouryButtonScript> ();
				button.nameLabel.text = itemDatabase.items[i].itemName;
				button.icon.sprite = itemDatabase.items[i].itemIcon;
	//			button.activeIcon.SetActive (item.itemIsActive); // this needs to be driven by playerprefs/somewhere else
				newButton.transform.SetParent (contentPanel);
			}
		}
	}

//	void PopulateList ()
//	{
//		foreach (var item in itemList) 
//		{
//			GameObject newButton = Instantiate (armouryButton) as GameObject;
//			ArmouryButtonScript button = newButton.GetComponent <ArmouryButtonScript> ();
//			button.nameLabel.text = item.itemName;
//			button.icon.sprite = item.itemIcon;
//			//			button.activeIcon.SetActive (item.itemIsActive); // this needs to be driven by playerprefs/somewhere else
//            newButton.transform.SetParent (contentPanel);
//        }
//    }
}

