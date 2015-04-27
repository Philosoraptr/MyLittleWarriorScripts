﻿using UnityEngine;
using System;

public class ReSkinAnimation : MonoBehaviour {

	public string spriteSheetName;

	void LateUpdate()
	{
		if(PlayerPrefs.HasKey("Armour"))
		{
			spriteSheetName = PlayerPrefs.GetString("Armour");
        }	

		var subSprites = Resources.LoadAll<Sprite> ("Male/Body/" + spriteSheetName);

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
