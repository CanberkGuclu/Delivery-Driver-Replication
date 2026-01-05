using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFolllow;
    void LateUpdate()
    {
       transform.position = thingToFolllow.transform.position + new Vector3 (0, 0, -10);
    }
}
