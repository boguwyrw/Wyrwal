using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoorScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            if (collision.gameObject.GetComponent<Renderer>().material.color.Equals(transform.GetChild(0).GetComponent<Renderer>().material.color))
            {
                transform.Rotate(0.0f, 0.0f, 90.0f);
                Destroy(collision.gameObject);
            }
            Debug.Log(collision.gameObject.GetComponent<Renderer>().material.color);
        }
    }
}
