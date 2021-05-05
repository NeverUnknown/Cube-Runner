using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipInfo : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {
            FindObjectOfType<GameManager>().SkipInfo();
        }
    }
}
