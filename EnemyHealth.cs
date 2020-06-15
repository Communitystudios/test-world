using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Vector3 teleportPosition;
    public GameObject delete;
    void OnTriggerEnter(Collider other)
    {          
        if (other.tag == "Untagged")
        {
            transform.position = teleportPosition;
        }
    }
}