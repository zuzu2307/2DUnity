using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            print("Destroy!");
            Destroy(other.gameObject);
            Destroy(other.transform.parent.gameObject);
        }
    }
}
