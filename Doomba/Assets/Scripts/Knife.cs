using UnityEngine;
using System.Collections;

public class Knife : MonoBehaviour 
{
	[SerializeField] GameObject sparksParticle;
	[SerializeField] GameObject sparkPoint;
	[SerializeField] AudioSource audioSource;

	private GameObject[] previousSparks;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		previousSparks = GameObject.FindGameObjectsWithTag ("Sparks Particle");

		if (other.gameObject.tag == "Knife")
		{
			Instantiate (sparksParticle, sparkPoint.transform.position, transform.rotation);
			if (this.gameObject.name == "Black Knife") 
			{
				audioSource.Play ();
			}
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Knife") 
		{
			for (int i = 0; i < previousSparks.Length; i++) 
			{
				Destroy (previousSparks[i]);
			}
		}
	}
}
