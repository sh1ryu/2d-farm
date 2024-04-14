using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Цель, за которой будет следовать камера
    public float followSpeed = 5f;

    void Update()
    {
        //transform.position = target.position + new Vector3(0, 0, -10); // не плавное, будет дергание.
        transform.position = Vector3.Lerp(transform.position, target.position + new Vector3(0, 0, -10), followSpeed * Time.deltaTime);
    }
}
