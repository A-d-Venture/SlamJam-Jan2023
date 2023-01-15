using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearBetweenBounds : MonoBehaviour
{
    [SerializeField] GameObject upperBound;
    [SerializeField] GameObject lowerBound;
    [SerializeField] GameObject movingObject;

    [SerializeField] private float upMoveSpeed = 5f;
    [SerializeField] private float downMoveSpeed = 10f;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Jump") && (Vector3.Distance(movingObject.transform.position, upperBound.transform.position) > 0))
        {
            movingObject.transform.position = Vector3.MoveTowards(movingObject.transform.position, upperBound.transform.position, upMoveSpeed * Time.deltaTime);
        }
        else
        {
            movingObject.transform.position = Vector3.MoveTowards(movingObject.transform.position, lowerBound.transform.position, downMoveSpeed * Time.deltaTime);
        }
    }
}
