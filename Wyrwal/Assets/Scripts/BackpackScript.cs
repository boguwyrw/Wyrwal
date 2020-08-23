using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackScript : MonoBehaviour
{
    [SerializeField]
    private GameObject playerRobotObject;
    private Vector3 distance;
    public string backpackItemName;

    private void Start()
    {
        distance = playerRobotObject.transform.position - transform.position;
    }

    private void Update()
    {
        transform.position = playerRobotObject.transform.position - distance;
    }

    public string GetBackpackItemName()
    {
        return backpackItemName;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            if (transform.childCount == 0)
            {
                collision.transform.parent = transform;
            }
            
            if (transform.childCount > 0)
            {
                transform.GetChild(0).position = new Vector2(transform.position.x, transform.position.y);
                backpackItemName = transform.GetChild(0).name;
            }
        }
    }
    /*
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            collision.transform.parent = null;
        }
    }
    */
}
