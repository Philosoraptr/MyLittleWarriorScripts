using UnityEngine;
using System.Collections;

public class WarriorController : MonoBehaviour 
{
	public Vector2 speed = new Vector2(5, 0);
	public Vector2 direction = new Vector2(-1, 0);
	public Vector2 movement;

	public GameObject body;
//	public GameObject hat;

	private Animator bodyAnim;
//	private Animator hatAnim;

	// Use this for initialization
	void Start ()
	{
		bodyAnim = body.GetComponent<Animator> ();
//		hatAnim = hat.GetComponent<Animator> ();
    }
	
	// Update is called once per frame
	void Update ()
	{
		movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
		bodyAnim.SetFloat ("speed", movement.x);
//		hatAnim.SetFloat ("speed", movement.x);
    }
    
    void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = movement;
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
