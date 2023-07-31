using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    private Transform cameraTransform;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.x >= 0)
        {
            cameraTransform.position = new Vector3(playerTransform.position.x, 0f, cameraTransform.position.z);
        }
    }
}
