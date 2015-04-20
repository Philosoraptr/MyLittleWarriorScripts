using UnityEngine;
using System.Collections;

public class BackToMainScene : MonoBehaviour {

	public void Back ()
	{
		Application.LoadLevel ("First Scene");
	}
}
