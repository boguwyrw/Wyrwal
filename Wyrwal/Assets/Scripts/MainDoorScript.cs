using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoorScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            transform.Rotate(0.0f, 0.0f, 90.0f);
            Destroy(collision.gameObject);
        }
    }
}
