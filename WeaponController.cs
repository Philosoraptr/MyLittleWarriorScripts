using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	private Vector2 movement;
	public GameObject character;

	// Update is called once per frame
	void Update () 
	{
		movement = character.GetComponent<WarriorController>().movement;
		Animator anim = GetComponent<Animator> ();
		anim.SetFloat ("speed", movement.x);
	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = movement;
	}
}
