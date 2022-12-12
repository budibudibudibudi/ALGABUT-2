using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameoverscirpt : MonoBehaviour
{
    public Text scoreteks;

    private void Start()
    {
        scoreteks.text = "Score : " + PlayerPrefs.GetInt("score");
    }
    public void gameover()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
