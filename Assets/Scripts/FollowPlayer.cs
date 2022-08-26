using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //leave Gameobject public, varible 'vehicle' assigned in unity
    public GameObject Player;
    private Vector3 offset = new Vector3( 0, 4.183801f, -6.986106f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //camera's position = player's(vehicle's) position + offset(to lift camera off the ground.)
        transform.position = Player.transform.position + offset;
    }
}
