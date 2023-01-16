using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBoundsTrigger : MonoBehaviour
{
    private bool Player1InTrigger = false;
    private bool Player2InTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player1" && Player1InTrigger == false && Player2InTrigger == false)
        {
            Debug.Log("Player 2 Wins!");
            Player1InTrigger = true;

        } else if (other.tag == "Player2" && Player2InTrigger == false && Player1InTrigger == false)
        {
            Debug.Log("Player 1 Wins!");
            Player2InTrigger = true;

        }
    }
}
