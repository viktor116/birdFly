using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public int BIRD_LAYER = 3;
    public LoginScript loginScript;
    // Start is called before the first frame update
    void Start()
    {
        loginScript = GameObject.FindGameObjectWithTag("logic").GetComponent<LoginScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == BIRD_LAYER)
        {
            loginScript.addScore(1);
        }
        // throw new NotImplementedException();
    }

  
}
