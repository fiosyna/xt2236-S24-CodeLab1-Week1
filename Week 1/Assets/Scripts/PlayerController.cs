using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedAngle = 0.1f;
    public float maxAngle; 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float zRotation = transform.rotation.eulerAngles.z;
        float xRotation = transform.rotation.eulerAngles.x;
        Debug.Log(zRotation);

        // Control the rotation of the plane
        if (zRotation > 10f && zRotation < 40f)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Rotate(Vector3.forward, speedAngle);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Rotate(Vector3.back, speedAngle);
            }
        }

            if (xRotation > 0 &&  xRotation < 50f)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.left, speedAngle);
            }

            if ((Input.GetKey(KeyCode.RightArrow)))
            {
                transform.Rotate(Vector3.right, speedAngle);
            }
        }
    }
}
