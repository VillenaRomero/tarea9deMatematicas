using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUVMovementPersecucion : MonoBehaviour
{
    public Transform target;
    public float initialSpeed = 2f;
    public float acceleration = 0.5f;

    private float currentSpeed;

    void Start()
    {
        currentSpeed = initialSpeed;
    }

    void Update()
    {
        MoveTowardsTarget();
    }

    void MoveTowardsTarget()
    {
        currentSpeed += acceleration * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target.position, currentSpeed * Time.deltaTime);
    }
}
