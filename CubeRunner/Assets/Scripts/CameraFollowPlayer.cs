using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        /*offset.x = player.position.x;
        offset.y = player.position.y + 2.5f;
        offset.z = player.position.z - 5;
        transform.position = offset;*/
        transform.position = player.position + offset;
    }
}
