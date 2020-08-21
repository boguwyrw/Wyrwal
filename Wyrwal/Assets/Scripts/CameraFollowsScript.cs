using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsScript : MonoBehaviour
{
    [SerializeField]
    private GameObject playerRobotObject;
    private float distanceZ;

    private void Start()
    {
        distanceZ = playerRobotObject.transform.position.z - transform.position.z;
    }

    private void Update()
    {
        transform.position = new Vector3(playerRobotObject.transform.position.x, playerRobotObject.transform.position.y, playerRobotObject.transform.position.z - distanceZ);
    }
}
