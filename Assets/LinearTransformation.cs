using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearTransformation : MonoBehaviour
{
    float Speed = 1;
    

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition += new Vector3(0.0f, 0.0f, Speed/100);
        if(transform.position.z >= 3.0f || transform.position.z <= -3.0f) {
            Speed = Speed * -1;
        }
    }
}
