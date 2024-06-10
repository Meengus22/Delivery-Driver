using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject objToFollow;
    //Camera Position should equal car position
    
    void LateUpdate()
    {
       transform.position = objToFollow.transform.position + new Vector3 (0,0,-10);    
    }
}
