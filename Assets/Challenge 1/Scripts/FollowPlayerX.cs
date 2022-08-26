using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //initiating variables
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // camera = player's position
        offset = new Vector3 ( 16, 2, 4);
        transform.position = plane.transform.position + offset;
    }
}
