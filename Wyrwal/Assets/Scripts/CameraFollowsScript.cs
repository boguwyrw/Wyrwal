using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsScript : MonoBehaviour
{
    [SerializeField]
    private GameObject faceObject;
    private float distanceZ;

    private void Start()
    {
        distanceZ = faceObject.transform.position.z - transform.position.z;
    }

    private void Update()
    {
        transform.position = new Vector3(faceObject.transform.position.x, faceObject.transform.position.y, faceObject.transform.position.z - distanceZ);
    }
}
