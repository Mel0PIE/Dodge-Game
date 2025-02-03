using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    Transform target;

    public float distance = 8f;
    public float height = 10f;

    Vector3 setPos;

    
    void Start()
    {
        target = FindObjectOfType<PlayerController>().transform;

        SetCameraPos();

        transform.LookAt(target.position);
    }

   
    void LateUpdate()
    {
        SetCameraPos();
    }

    void SetCameraPos()
    {
        setPos.x = target.position.x;
        setPos.y = target.position.y + height;
        setPos.z = target.position.z - distance;

        transform.position = setPos;
    }
}