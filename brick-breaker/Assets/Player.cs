using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    public float playerSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 force = Vector2.zero;

        // 左矢印が押されたときに移動方向を左にする
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force = new Vector2(playerSpeed * -1, 0);
        }

        // 右矢印が押されたときに移動方向を右にする
        if (Input.GetKey(KeyCode.RightArrow))
        {
            force = new Vector2(playerSpeed * 1, 0);
        }

        myRigidbody.MovePosition(myRigidbody.position + force * Time.fixedDeltaTime); // Time.fixedDeltaTime：端末の性能差を吸収してくれる

    }

}
