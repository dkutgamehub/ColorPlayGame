using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayGame()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        
    }

    IEnumerator LoadLevel (int levelIndex)
    {
        // play animation
        transition.SetTrigger("start");

        //wait for the animation to end
        yield return new WaitForSeconds(transitionTime);

        //Load next scene of the game

        SceneManager.LoadScene(levelIndex);
    }
}
