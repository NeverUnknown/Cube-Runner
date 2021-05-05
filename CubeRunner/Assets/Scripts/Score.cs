using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if (player.position.y > -1f)
        {
            scoreText.text = ((int)player.position.z).ToString();
        }
    }
}
