using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbMovementB : MonoBehaviour
{

    private float rotateSpeed = 5f;
    private float radius = 2f;
    private Vector3 myCentre;
    private float myAngle;

    // Use this for initialization
    void Start()
    {

        myCentre = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        myAngle += rotateSpeed * Time.deltaTime;

        Vector3 offset = new Vector3(Mathf.Sin(-myAngle), Mathf.Cos(myAngle)) * radius;
        transform.position = myCentre + offset;
    }
}
