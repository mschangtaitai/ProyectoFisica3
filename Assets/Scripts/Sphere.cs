using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sphere : MonoBehaviour
{

    public Slider gravity;
    public Slider height;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        //Physics.gravity = new Vector3(0, -10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown("space")))
        {
            this.transform.position = new Vector3(-2, (float)(height.value * 8 + 0.5), -20);
            this.rb.velocity = new Vector3(0, 0, 0);
            print(gravity.value);
            Physics.gravity = new Vector3(0, -gravity.value * 10, 0);
            rb.AddForce(0, 0, 3, ForceMode.Impulse);
            print("space was pressed");
        }
        
    }
}
