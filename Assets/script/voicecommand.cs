using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.Windows.Speech;
public class voicecommand : MonoBehaviour
{
    public KeywordRecognizer kr;
    public Dictionary<string, Action> actions = new Dictionary<string, Action>();
    // Start is called before the first frame update
    void Start()
    {
        actions.Add("jump", test);

        kr = new KeywordRecognizer(actions.Keys.ToArray());
        kr.OnPhraseRecognized += OnPhraseRecognized;
        kr.Start();
    }
    void OnPhraseRecognized(PhraseRecognizedEventArgs msg)
    {
        Debug.Log(msg.text);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void test()
    {
        FindObjectOfType<temp>().rb.AddForce(new Vector2(0,1500));
    }
}
