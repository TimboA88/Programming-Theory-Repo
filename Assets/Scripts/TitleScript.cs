using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;
using UnityEditor;

public class TitleScript : MonoBehaviour
{

    public void startButton()
    {
        SceneManager.LoadScene(0);
    }
    public void exitButton()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
