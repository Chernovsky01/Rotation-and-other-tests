using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotationX = Quaternion.AngleAxis(1, new Vector3(1, 0, 0));
        transform.rotation *= rotationX;

        Quaternion rotationY = Quaternion.AngleAxis(2, new Vector3(0, 1, 0));
        transform.rotation *= rotationY;

        Quaternion rotationZ = Quaternion.AngleAxis(3, new Vector3(0, 0, 1));
        transform.rotation *= rotationZ;
    }
}
