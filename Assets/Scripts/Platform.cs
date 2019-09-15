using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Platform : MonoBehaviour
{
    public Slider height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(-2, (float)(height.value * 8 + 0.5), -21);
    }
}
