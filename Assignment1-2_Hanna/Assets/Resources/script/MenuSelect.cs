using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitApp()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

#elif UNITY_ANDROID

        Application.Quit();

#endif

    }
}
