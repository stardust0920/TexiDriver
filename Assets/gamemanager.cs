using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public GameObject player;
    public GameObject flag;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - player.transform.position.x;
        if(length < 0 )
        {
            text.text = "게임오버";
        }
        else
        {
            text.text = "목표 지점까지" + length.ToString("F2") + "m";
        }
        if (player.GetComponent<Player>().speed < 0)
        {
            player.GetComponent<Player>().speed = 0;
        }     
    }
}
