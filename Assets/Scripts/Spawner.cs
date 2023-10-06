using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Plane;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnObject()
    {

        while (true)
        {
            Instantiate(Plane, new Vector3(0, 0, 80), Quaternion.identity);

            yield return new WaitForSeconds(5f);

            
        }
    }
}
