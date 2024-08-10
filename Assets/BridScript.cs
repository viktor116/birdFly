using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BridScript : MonoBehaviour
{
    public Rigidbody2D myRegidbody;
    public float flyStrength;
    public LoginScript loginScript;
    public float deadLowest = -13;
    public float deadHeight = 14;

    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        loginScript = GameObject.FindGameObjectWithTag("logic").GetComponent<LoginScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRegidbody.velocity = Vector2.up * flyStrength;
        }

        if (gameObject.transform.position.y < deadLowest || gameObject.transform.position.y > deadHeight)
        {
            deadScreen(); 
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        deadScreen();
    }

    void deadScreen()
    {
        loginScript.gameOver();
        birdIsAlive = false;
    }
}