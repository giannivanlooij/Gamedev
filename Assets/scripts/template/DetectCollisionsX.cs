using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Dog"))
        {
            Destroy(gameObject);
        }
    }
}
