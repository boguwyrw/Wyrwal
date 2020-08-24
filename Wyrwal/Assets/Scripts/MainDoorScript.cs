using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoorScript : MonoBehaviour
{
    public string destroyKeyName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            if (collision.gameObject.GetComponent<Renderer>().material.color.Equals(transform.GetChild(0).GetComponent<Renderer>().material.color))
            {
                transform.Rotate(0.0f, 0.0f, 90.0f);
                destroyKeyName = collision.gameObject.name;
                Debug.Log("Trigger: " + destroyKeyName);
                Destroy(collision.gameObject);
            }
        }
    }
    /*
    public string GetDestroyKeyName()
    {
        return destroyKeyName;
    }
    */
}
