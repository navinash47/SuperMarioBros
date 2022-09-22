using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrolling : MonoBehaviour
{
    private Transform player;
    private float minValue=18f;
    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }
    private void LateUpdate()
    {
        Vector3 cameraPosition = transform.position;
        /*Debug.Log("CameraPosition.x : " + cameraPosition.x);*/
        if (player.position.x >= minValue)
        {
            cameraPosition.x = player.position.x;
            transform.position = cameraPosition;
            minValue = cameraPosition.x;
        }
    }
}
