using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvMovement : MonoBehaviour
{
    public float speed = 200.0f; 
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 20f);
    }

    // Update is called once per frame
    

    void Update()
    {
   
        transform.position += Vector3.back * speed * Time.deltaTime;

        
    }


}
