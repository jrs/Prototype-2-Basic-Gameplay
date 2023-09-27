using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float TopBounds = 30f;
    public float LowerBounds = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > TopBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < LowerBounds)
        {
            Destroy(gameObject);
        }
    }
}
