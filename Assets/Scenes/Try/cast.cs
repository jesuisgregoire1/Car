using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cast : Shape
{
    [SerializeField] private int force;
    private void FixedUpdate()
    {
        if (Physics.Raycast(gameObject.transform.position, Vector3.up, out RaycastHit hit, 10))
        {
            hit.rigidbody.AddForce(Vector3.down * force * Time.fixedDeltaTime, ForceMode.Force);
            
        }
    }

    public override void DoMovement()
    {
        transform.Translate(Vector3.up*10*Time.deltaTime);
    }
}
