using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class avatarscript : MonoBehaviour
{
    public itemclass mainavatar;
    public itemclass[] avatar;
    public GameObject[] avatarbtn;
    int temp;
    public InputField inputnama;
    // Start is called before the first frame update
    void Start()
    {
        avatar = new itemclass[3];
        for(int i = 0;i<avatar.Length;i++)
            avatar[i] = Resources.Load<itemclass>("icon" + i);

        refreshavatar();
    }


    // Update is called once per frame
    void refreshavatar()
    {
        for (int i = 0; i < avatarbtn.Length; i++)
        {
            try
            {
                avatarbtn[i].transform.GetChild(0).GetComponent<Image>().sprite = avatar[i].avatar;
                //isclicked[i] = false;
            }
            catch
            {
                avatarbtn[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                //avatarbtn[i].GetComponent<Image>().color = Color.yellow;
            }
        }
    }
    public void choseavatar(int index)
    {
        if(mainavatar == null)
        {
            temp = index;
            avatarbtn[temp].GetComponent<Image>().color = Color.yellow;
        }
        else
        {
            avatarbtn[temp].GetComponent<Image>().color = Color.white;
            temp = index;
            avatarbtn[temp].GetComponent<Image>().color = Color.yellow;
        }
        mainavatar = avatar[index];
    }

    public void chosed()
    {
        if (mainavatar == null || inputnama.text == null)
        {
            Debug.Log("avatar kosong");
        }
        else
        {
            PlayerPrefs.SetString("MainAvatar", mainavatar.index.ToString());
            PlayerPrefs.SetString("Nama", inputnama.text);
            SceneManager.LoadScene("mainmenu");
        }
    }
}
