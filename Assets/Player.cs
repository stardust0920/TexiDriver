using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float speed = 0;
    public Vector2 startPosition;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            audio.Play();
            Vector2 endPosition = Input.mousePosition;
            float length = endPosition.x - startPosition.x;
            speed = length / 500f;
            
        } 
        transform.Translate(speed, 0, 0);
        speed *= 0.98f;
    }
}
