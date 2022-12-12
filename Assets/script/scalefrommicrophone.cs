using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scalefrommicrophone : MonoBehaviour
{
    public Slider volumedetec;
    public voicerecognize detector;
    [HideInInspector] public float loudnessSensibility = 10;
    [HideInInspector] public float threshold = 0.1f;
    public float loudness;
    string alert;
    public Image fill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        loudness = detector.Getloudnessfrommic()*loudnessSensibility;


    }
}
