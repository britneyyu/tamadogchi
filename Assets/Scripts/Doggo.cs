using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doggo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began)) {
            GetComponent<AudioSource>().Play();
        }

        /* foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                GetComponent<AudioSource>().Play();
            }
        } */
    }
}
