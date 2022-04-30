using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NightmareUI : MonoBehaviour
{
    public void NightmareOneStart()
    {
        SceneManager.LoadScene("Nightmare1");
    }
    public void NightmareTwoStart()
    {
        SceneManager.LoadScene("Nightmare2");
    }
    public void NightmareThreeStart()
    {
        SceneManager.LoadScene("Nightmare3");
    }
}
