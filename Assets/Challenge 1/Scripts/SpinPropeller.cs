using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    //declaring variable
    public float spin = 1500f;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //spin the propeller
      transform.Rotate(Vector3.forward * spin * Time.deltaTime, Space.Self);

    }
}
