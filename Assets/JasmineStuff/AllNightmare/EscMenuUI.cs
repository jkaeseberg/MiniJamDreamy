using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EscMenuUI : MonoBehaviour
{
    [SerializeField] GameObject EscMenu;
    [SerializeField] GameObject CreditsUI;
    
    
    void Start()
    {
        EscMenu.SetActive(false);
        CreditsUI.SetActive(false);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
    public void PlayCredits()
    {
        CreditsUI.SetActive(true);
    }
    public void ResumeGame()
    {
        EscMenu.SetActive(false);
    }
}
