using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 60.2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            while (rb.position.x <= 5.4f)
            {
                rb.AddForce(new Vector3(60.2f,0,0));
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (rb.position.x >= -5.2f)
            {
                rb.AddForce(new Vector3(-60.2f, 0, 0));
            }
        }
    }
}
