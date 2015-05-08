using UnityEngine;
using System.Collections;

public class OurMovementScript : MonoBehaviour {

    private float speed = 12f;

	void Update () {
        MovePlayer();
        RotatePlayer();
	}

    void MovePlayer() {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * speed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down, Time.deltaTime * speed * 5   );
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, Time.deltaTime * speed * 5);
        }
    }
}
