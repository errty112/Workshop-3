using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinOrbit : MonoBehaviour
{
    float spinSpeed = 500;

    // Update is called once per frame
    void Update()
    {
        var angle = this.spinSpeed * Time.deltaTime;
        var axis = new Vector3(1.0f, 0.0f, 0.0f);
        transform.localRotation *= Quaternion.AngleAxis(angle, axis);
    }
}