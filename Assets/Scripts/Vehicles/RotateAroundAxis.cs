using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundAxis : MonoBehaviour
{
    [SerializeField] GameObject pivotPoint;

    [SerializeField] private float upMoveSpeed = 20f;
    [SerializeField] private float downMoveSpeed = 30f;
    [SerializeField] private float angleHighBound = -60;
    [SerializeField] private float angleLowBound = 0;

    [SerializeField] private string movementKey = "Jump";

    private Vector3 angleOfTheDangle = new Vector3(0,0,0);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(movementKey) && angleOfTheDangle.x > angleHighBound)// && angle is below high bound)
        {
            angleOfTheDangle += new Vector3(-1, 0, 0) * Time.deltaTime * upMoveSpeed;
            transform.localEulerAngles = angleOfTheDangle;
            //Debug.Log("current angle: " + angleOfTheDangle);
        }
        else if (angleOfTheDangle.x < angleLowBound)//Angle is above lowerbound
        {
            angleOfTheDangle += new Vector3(1, 0, 0) * Time.deltaTime * downMoveSpeed;
            transform.localEulerAngles = angleOfTheDangle;
            //Debug.Log("current angle: " + angleOfTheDangle);
        }
    }
}
