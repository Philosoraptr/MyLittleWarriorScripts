using UnityEngine;
using System.Collections;

public class WarriorController : MonoBehaviour 
{
	public Vector2 speed = new Vector2(5, 0);
	public Vector2 direction = new Vector2(-1, 0);
	public Vector2 movement;

	public GameObject body;
	public GameObject weapon;
	public GameObject leftButton;
	public GameObject rightButton;
	
	private Animator bodyAnim;
	private Animator weaponAnim;

	private Collider2D enemyCollider;

	private bool touchingEnemy;

	public float coolDown;
	private float attackTimer;

	public string attackType;

	void Start ()
	{
		bodyAnim = body.GetComponent<Animator> ();
		weaponAnim = weapon.GetComponent<Animator> ();
		touchingEnemy = false;
		attackTimer = 0;
    }

	void Update ()
	{
		movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
		bodyAnim.SetFloat ("speed", movement.x);

		if(attackTimer > 0)
			attackTimer -= Time.deltaTime;
		
		if(attackTimer < 0)
			attackTimer = 0;

        if(touchingEnemy)
		{
			if(attackTimer == 0)
			{
				attackTimer = coolDown;
				Attack ();
			}
		}
    }
    
    void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = movement;
    }

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		touchingEnemy = true;
		if(otherCollider.gameObject.tag == "Enemy")
		{
			enemyCollider = otherCollider;
		}
	}

	void OnTriggerExit2D(Collider2D otherCollider)
	{
		touchingEnemy = false;
		enemyCollider = null;
	}

	void Attack()
	{
		bodyAnim.SetBool (attackType, true);
		weaponAnim.SetBool(attackType, true);
		leftButton.GetComponent<PointerListener> ().animPlaying = true;
		rightButton.GetComponent<PointerListener> ().animPlaying = true;

//		enemyCollider.GetComponent<EnemyController>().TakeDamage(

		StartCoroutine(WaitThenStopAnimation(0.02f));
	}

	IEnumerator WaitThenStopAnimation(float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		bodyAnim.SetBool (attackType, false);
		weaponAnim.SetBool (attackType, false);
		leftButton.GetComponent<PointerListener> ().animPlaying = false;
		rightButton.GetComponent<PointerListener> ().animPlaying = false;
	}
}
