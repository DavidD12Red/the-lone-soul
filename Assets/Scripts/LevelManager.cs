using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel(string levelLoading)
    {
        Debug.Log("The new level loaded is " + levelLoading);
        SceneManager.LoadScene(levelLoading);
    }

    public void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("The Player exits the game");
#endif
    }

}
