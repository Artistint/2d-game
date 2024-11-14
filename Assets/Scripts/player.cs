using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SocialPlatforms;

public class player : MonoBehaviour
{
    public FixedJoystick joystick;
    public float moveSpeed;

    float hInput, vInput;

    int score = 0;

    public GameObject winText;

    public int winScore;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {
        hInput = joystick.Horizontal * moveSpeed;
        vInput = joystick.Vertical * moveSpeed;
        transform.Translate(hInput, vInput, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "carrot")
        {
            score++;
            Destroy(collision.gameObject);
            if (score >= winScore)
            {
                winText.SetActive(true);
            }
        }
    }
}