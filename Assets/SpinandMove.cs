using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinandMove : MonoBehaviour
{
    float spinSpeed = 100;
    float Speed = 1;

    // Update is called once per frame
    void Update()
    {
        // Rotation
        var angle = this.spinSpeed * Time.deltaTime;
        var axis = new Vector3(1.0f, 0.0f, 0.0f);
        transform.localRotation *= Quaternion.AngleAxis(angle, axis);

        // Linear Transformation
        this.transform.localPosition += new Vector3(0.0f, 0.0f, Speed/100);
        if(transform.position.z >= 3.0f || transform.position.z <= -3.0f) {
            Speed = Speed * -1;
        }
    }
}
