using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public string[] sceneNameArray;
	public int currentScene;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartCurrentLevel()
    {
	    SceneManager.LoadScene(sceneNameArray[currentScene]);
    }

    public void Progress()
    {
	    currentScene += 1;
	    SceneManager.LoadScene(sceneNameArray[currentScene]);
    }
}
