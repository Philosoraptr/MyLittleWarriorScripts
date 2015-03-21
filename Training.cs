using UnityEngine;
using System.Collections;

public class Training : MonoBehaviour {

	public GameObject character;
//	private GameObject weapon;
//	private GameObject enemy;

	// Move the player and monster to
	public void MoveToTrainingArea()
	{
		character.GetComponent<WarriorController>().MoveToTrainingArea ();
	}
}
