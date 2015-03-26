// Sources
// http://stackoverflow.com/questions/4804990/c-sharp-getting-file-names-without-extensions
// http://stackoverflow.com/questions/26187800/unity-4-6-button-instances-added-at-runtime-are-not-scaled-by-reference-resolut
// http://stackoverflow.com/questions/27503262/instantiate-method-doesnt-draw-the-prefab-button-inside-the-canvas-and-doesnt
// http://docs.unity3d.com/Manual/InstantiatingPrefabs.html

using UnityEngine;
using System.Collections;
using System.IO;

public class ArmouryMenu : MonoBehaviour {

	public GameObject armouryButton;
	public float spacing = 150f;

	// Use this for initialization
	void Start () 
	{
		DirectoryInfo dir = new DirectoryInfo("Assets/Resources/Characters");
		FileInfo[] info = dir.GetFiles("*.*");
		foreach (FileInfo file in info) 
		{
			if(file.Extension == ".png")
			{
				Debug.Log(Path.GetFileNameWithoutExtension(file.Name));
				armouryButton = (GameObject)GameObject.Instantiate(armouryButton, transform.position, Quaternion.identity);
				armouryButton.transform.SetParent(gameObject.transform, true);
//				i += 1;
			}
		}

//		int i = 0;
//		Sprite[] subSprites = Resources.LoadAll<Sprite>("Characters");
//		Debug.Log (subSprites.Length);


//		foreach(Sprite sprite in subSprites)
//		{
//			//string spriteName = sprite.name;
////			Instantiate(armouryButton, new Vector3(220f, (800f + (spacing * i)), 0f), Quaternion.identity);
//			armouryButton = (GameObject)GameObject.Instantiate(armouryButton, transform.position, Quaternion.identity);
//			armouryButton.transform.SetParent(gameObject.transform, false);
//			i += 1;
//		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

//sort of pseudo code at this stage
//		for int i = 1 to numberOfSpriteSheets
//		{
//			buttonLabel = SpriteSheet.Name;
//			Sprite Sprites = Resources.Load <Sprite> ("Characters/" + spriteSheetName + "/Sprite_07");
//			buttonImage = Sprite;
//		}