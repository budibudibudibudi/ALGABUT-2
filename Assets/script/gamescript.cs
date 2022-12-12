using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gamescript : MonoBehaviour
{
    public static int score;
    public Text scoreteks;
    public GameObject[] kumpulansoal;
    int currentsoal = 0;
    public float timer = 30f;
    public Slider timerslide;
    // Start is called before the first frame update
    private void Start()
    {
        refreshscore();
    }
    void refreshscore()
    {
        scoreteks.text = "Score : " + score;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 30)
            timer = 30;
        timer -= Time.deltaTime;
        timerslide.value = timer;
    }

    public void soal(bool isbenar)
    {
        if (isbenar)
        {
            if (currentsoal == kumpulansoal.Length)
                gameover();
            else
                nextsoal();
        }
        else
            gameover();
    }

    void gameover()
    {
        PlayerPrefs.SetInt("score", score);
        SceneManager.LoadScene("gameover");
    }
    void nextsoal()
    {
        kumpulansoal[currentsoal].SetActive(false);
        currentsoal++;
        kumpulansoal[currentsoal].SetActive(true);
        score += 1000;
        timer += 10;
        refreshscore();
    }
}
