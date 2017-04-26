using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] string sceneToLoad;
    [SerializeField] string thisScene;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void LoadTheScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(thisScene);
    }
}
