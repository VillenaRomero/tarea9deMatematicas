using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceController : MonoBehaviour
{
    public Transform target;
    public GameObject mruObject; 
    public GameObject mruvObject; 

    public float mruSpeed = 5f; 
    public float mruvInitialSpeed = 2f;
    public float mruvAcceleration = 0.5f;

    private float mruvCurrentSpeed;

    void Start()
    {
        mruvCurrentSpeed = mruvInitialSpeed;
    }

    void Update()
    {
        mruObject.transform.position = Vector3.MoveTowards(mruObject.transform.position, target.position, mruSpeed * Time.deltaTime);

        mruvCurrentSpeed += mruvAcceleration * Time.deltaTime;
        mruvObject.transform.position = Vector3.MoveTowards(mruvObject.transform.position, target.position, mruvCurrentSpeed * Time.deltaTime);
    }
}
