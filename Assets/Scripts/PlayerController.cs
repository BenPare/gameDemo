using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7.5f;
    public float dash = 25f;
    public float LRInput;
    public float FBInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed > 7.5f)
        {
            speed = speed - .1f;
        }
        if (dash < 25f)
        {
            dash = dash + .05f;
        }
        LRInput = Input.GetAxis("Horizontal");
        FBInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * FBInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * LRInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = speed + dash;
            dash = 0;
        }
    }
}
