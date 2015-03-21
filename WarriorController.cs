using UnityEngine;
using System.Collections;

public class WarriorController : MonoBehaviour 
{
	public Vector2 speed = new Vector2(5, 5);
	public Vector2 direction = new Vector2(-1, 0);
	public Vector2 movement;

	// Use this for initialization
	void Start ()
	{

    }
	
	// Update is called once per frame
	void Update ()
	{
		movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
		Animator anim = GetComponent<Animator> ();
		anim.SetFloat ("speed", movement.x);
    }
    
    void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
    }

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		direction.x *= -1;
	}

	public void MoveToTrainingArea()
	{
		transform.position = new Vector2(Camera.main.transform.position.x + (Camera.main.orthographicSize / 2), 0);
	}
}
