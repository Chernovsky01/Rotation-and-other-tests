using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour
{
    public float speedX;
    public float speedY;
    public float speedZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3 (1, 0, 0) * speedX * Time.deltaTime);
        transform.Translate(new Vector3(0, 1, 0) * speedY * Time.deltaTime);
        transform.Translate(new Vector3(0, 0, 1) * speedZ * Time.deltaTime);
    }
}
