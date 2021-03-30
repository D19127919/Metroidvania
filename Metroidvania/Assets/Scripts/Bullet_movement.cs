using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_movement : MonoBehaviour
{

    void Update()
    {
        transform.position += Vector3.right * (Time.deltaTime*2);
        
    }
}


