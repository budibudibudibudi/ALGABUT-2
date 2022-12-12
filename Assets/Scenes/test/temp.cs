using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp : MonoBehaviour
{
    public Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(FindObjectOfType<scalefrommicrophone>().loudness*Time.deltaTime, 0, 0, 0);
        if (this.transform.position.x >= 5)
            this.transform.position = Vector2.zero;
    }
}
