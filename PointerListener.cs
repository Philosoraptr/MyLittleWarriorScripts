using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class PointerListener : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public GameObject player;
	public int directionX;
	public int speedX;

	bool pressed = false;

	public void OnPointerDown(PointerEventData eventData)
	{
		pressed = true;
	}
	
	public void OnPointerUp(PointerEventData eventData)
	{
		pressed = false;
	}
	// Needs to stop moving on release. Perhaps the variables in WarriorController shouldn't stay set.
	void Update()
	{
		if (!pressed)
		{
			MoveX(0, 0);
			return;
		}
		
		MoveX (directionX, speedX);
	}

	public void MoveX(int direction, int speed)
	{
		player.GetComponent<WarriorController> ().direction.x = direction;
		player.GetComponent<WarriorController> ().speed.x = speed;
	}
}
