using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour 
{
	[SerializeField] GameManager gameManager;

	private bool isPopped = false;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		PopBalloon ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Knife") 
		{
			if (this.gameObject.name == "Balloon_BlackRoomba") 
			{
				gameManager.balloonList.RemoveAt(1);
				isPopped = true;
			} 
			else if (this.gameObject.name == "Balloon_SilverRoomba") 
			{
				gameManager.balloonList.RemoveAt(0);
				isPopped = true;
			}
		}
	}

	void PopBalloon()
	{
		if (isPopped == true) 
		{
			Destroy (gameObject);
		}
	}
}
