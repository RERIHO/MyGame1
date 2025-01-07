using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    public float speedX = 10;
    public float speedY = 10; 

    void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody2D>();

        Vector2 force = new Vector2(speedX, speedY);
        myRigidbody.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
