using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] float minForce, maxForce;
    [SerializeField] float dirMin, dirMax;

    [SerializeField] Rigidbody2D rid;
    private void Start()
    {
        // Create force
        AddForce();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AddForce();
    }

    public void Stop()
    {
        rid.velocity = Vector2.zero;
    }

    public void AddForce()
    {
        var dir = new Vector2(Random.Range(dirMin, dirMax) * Random.Range(minForce, maxForce), Random.Range(dirMin, dirMax) * Random.Range(minForce, maxForce));
        rid.AddForce(dir);
    }
}
