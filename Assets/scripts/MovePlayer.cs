using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public KeyCode KeyToPresForward;
    public KeyCode KeyToPresDownward;
    public KeyCode KeyToPresLeft;
    public KeyCode KeyToPresRight;
    public float MovementSpeed;
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        if (Input.GetKey(KeyToPresForward))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            transform.Rotate(Vector3.forward * (RotationSpeed * Time.deltaTime));
        } // Move the object forward along its z axis 1 unit/second.
        if (Input.GetKey(KeyToPresDownward))
        {
          transform.Translate(Vector3.back * Time.deltaTime);
        } if (Input.GetKey(KeyToPresLeft))
        {
            // Move the object forward along its z axis 1 unit/second.
            transform.Translate(Vector3.left * Time.deltaTime);
        } if (Input.GetKey(KeyToPresRight))
        {
            // Move the object forward along its z axis 1 unit/second.
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}





