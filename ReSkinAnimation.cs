using UnityEngine;
using System;

public class ReSkinAnimation : MonoBehaviour {

	public string bodySheetName;
	public string armourSheetName;
	public string clothesSheetName;
	public string greavesSheetName;
	public string hatSheetName;

	void LateUpdate()
	{
		bodySheetName = PlayerPrefs.GetString("Body");

		if(PlayerPrefs.HasKey("Armour"))
		{
			armourSheetName = PlayerPrefs.GetString("Armour");
        }
	
		if(PlayerPrefs.HasKey("Clothes"))
		{
			armourSheetName = PlayerPrefs.GetString("Clothes");
		}

		var subSprites = Resources.LoadAll<Sprite> ("Male/Body/" + bodySheetName);

		foreach(var renderer in GetComponentsInChildren<SpriteRenderer>())
		{
			string spriteName = renderer.sprite.name;
			var newSprite = Array.Find(subSprites, item => item.name == spriteName);

			if(newSprite)
			{
				renderer.sprite = newSprite;
			}
		}
	}
}
