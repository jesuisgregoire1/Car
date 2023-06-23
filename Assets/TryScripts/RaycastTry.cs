using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTry : MonoBehaviour
{
    private void FixedUpdate()
    {
        if(Physics.Raycast(gameObject.transform.position, Vector3.down, out RaycastHit hit, 10))
        {
            Debug.DrawRay(gameObject.transform.position, hit.point-gameObject.transform.position, Color.black);
            print(hit.transform.name);
        }
    }
}
