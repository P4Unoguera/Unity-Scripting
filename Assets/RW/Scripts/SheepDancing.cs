using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepDancing : MonoBehaviour
{
    public Vector3 maxRotation;
    public Vector3 rotationSpeed;

    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        float rotationX = Mathf.Sin(Time.time * rotationSpeed.x) * maxRotation.x;
        float rotationY = Mathf.Sin(Time.time * rotationSpeed.y) * maxRotation.y;
        float rotationZ = Mathf.Sin(Time.time * rotationSpeed.z) * maxRotation.z;

        transform.eulerAngles = initialPosition + new Vector3(rotationX, rotationY, rotationZ);
    }
}
