using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Sphere;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
                {

            Sphere.transform.position += new Vector3(-speed, 0, 0);
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            Sphere.transform.position += new Vector3(speed, 0, 0);
        }


        if (Input.GetKey(KeyCode.A))
        {
            Sphere.transform.position += new Vector3(0, 0, -speed);
        }


        if (Input.GetKey(KeyCode.D))
        {
            Sphere.transform.position += new Vector3(0, 0, speed);
        }









    }
}
