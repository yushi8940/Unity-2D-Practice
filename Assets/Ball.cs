using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    public float speedX = 10;
    public float speedY = 10;

    // Start is called before the first frame update
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
