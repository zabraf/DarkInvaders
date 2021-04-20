using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenLight : MonoBehaviour
{
    public MonoBehaviour lightLeft;
    public MonoBehaviour lightRight;
    public MonoBehaviour lightShoot;
    // Start is called before the first frame update
    void Start()
    {
        lightLeft.enabled = false;
        lightRight.enabled = false;
        lightShoot.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //light on
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            lightLeft.enabled = true;
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            lightRight.enabled = true;
        if (Input.GetKeyDown(KeyCode.Space))
            lightShoot.enabled = true;
        //light off
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
            lightLeft.enabled = false;
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
            lightRight.enabled = false;
        if (Input.GetKeyUp(KeyCode.Space))
            lightShoot.enabled = false;
    }
}
