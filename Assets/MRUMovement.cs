using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUMovement : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float[] timeToNextPoint;

    private int currentPointIndex = 0;
    public float speed;

    void Start()
    {
        SetNextPoint();
    }

    void Update()
    {
        MoveTowardsNextPoint();
    }

    void MoveTowardsNextPoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, patrolPoints[currentPointIndex].position) < 0.01f)
        {
            currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
            SetNextPoint();
        }
    }

    void SetNextPoint() {
        float distance = Vector3.Distance(transform.position, patrolPoints[currentPointIndex].position);
        speed = distance / timeToNextPoint[currentPointIndex];
    }
}
