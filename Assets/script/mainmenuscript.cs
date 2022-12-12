using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class mainmenuscript : MonoBehaviour
{
    public Text nama;
    itemclass avatar;
    public Image avatarimg;
    public GameObject mainmenu;
    public GameObject[] kumpulanpanel;
    // Start is called before the first frame update
    void Start()
    {
        nama.text = PlayerPrefs.GetString("Nama");
        this.avatar = Resources.Load<itemclass>("icon"+PlayerPrefs.GetString("MainAvatar"));
        if (avatar == null)
            return;
        avatarimg.sprite = this.avatar.avatar;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("game");
    }

    public void panel(int index)
    {
        mainmenu.SetActive(false);
        kumpulanpanel[index].SetActive(true);
    }
    public void closepanel()
    {
        foreach (GameObject g in kumpulanpanel)
            g.SetActive(false);
        mainmenu.SetActive(true);
    }

}
