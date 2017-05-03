using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	[SerializeField] GameObject canvas;

	public List<GameObject> balloonList = new List<GameObject>();

	private GameObject lastBalloon;
	private Text winText;

	// Use this for initialization
	void Start () 
	{
		winText = canvas.GetComponentInChildren<Text> ();

		foreach (GameObject balloon in GameObject.FindGameObjectsWithTag("Balloon")) 
		{
			balloonList.Add (balloon);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		WinScreen ();
	}

	void WinScreen()
	{
		if (balloonList.Count <= 1) 
		{
			lastBalloon = GameObject.FindGameObjectWithTag ("Balloon");
			canvas.SetActive (true);

			if (lastBalloon.gameObject.name == "Balloon_BlackRoomba") 
			{
				winText.text = "Player 1 Wins!";
			}
			else if(lastBalloon.gameObject.name == "Balloon_SilverRoomba")
			{
				winText.text = "Player 2 Wins!";
			}
		}
	}

	public void ResetLevel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
