//// Sources
//// http://stackoverflow.com/questions/4804990/c-sharp-getting-file-names-without-extensions
//// http://stackoverflow.com/questions/26187800/unity-4-6-button-instances-added-at-runtime-are-not-scaled-by-reference-resolut
//// http://stackoverflow.com/questions/27503262/instantiate-method-doesnt-draw-the-prefab-button-inside-the-canvas-and-doesnt
//// http://docs.unity3d.com/Manual/InstantiatingPrefabs.html
//
//using UnityEngine;
//using System.Collections;
//using System.IO;
//using UnityEngine.UI;
//
//public class ArmouryMenuDRAFT : MonoBehaviour {
//
//	public GameObject armouryButton;
//	public float spacing = 150f;
//
//	// Use this for initialization
//	void Start () 
//	{
//		DirectoryInfo dir = new DirectoryInfo("Assets/Resources/Characters");
//		FileInfo[] info = dir.GetFiles("*.*");
//		int i = 0;
//		foreach (FileInfo file in info) 
//		{
//			if(file.Extension == ".png")
//			{
//				Debug.Log(Path.GetFileNameWithoutExtension(file.Name));
//				GameObject armBtnPrefab = (GameObject)GameObject.Instantiate(armouryButton, transform.position, Quaternion.identity);
//				armBtnPrefab.transform.SetParent(gameObject.transform, false);
////				RectTransform rectTransform = (RectTransform)armBtnPrefab.transform;
////				rectTransform.anchoredPosition = new Vector2(0f, -70f - (100f * i));
////				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 80f);
////				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 700f);
//				i++;
//			}
//		}
//	}
//}
