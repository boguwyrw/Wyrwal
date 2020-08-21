using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabKeySystemScript : MonoBehaviour
{
    private Vector3 mousePosition;
    private RaycastHit2D hit;

    private void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        hit = Physics2D.Raycast(new Vector2(mousePosition.x, mousePosition.y), Vector2.zero, 0.0f);

        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Key"))
            {
                if (Input.GetMouseButton(0))
                {
                    hit.collider.transform.position = new Vector2(mousePosition.x, mousePosition.y);
                }
            }

            if (hit.collider.CompareTag("Backpack") && (hit.collider.transform.childCount > 0))
            {
                if (Input.GetMouseButton(0))
                {
                    hit.collider.transform.GetChild(0).position = new Vector2(mousePosition.x, mousePosition.y);
                }
            }
        }
    }
}
