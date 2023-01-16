using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{
    [SerializeField] GameObject enemyVehicle;
    [SerializeField] GameObject playerVehicle;
    [SerializeField] float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        enemyVehicle.transform.LookAt(playerVehicle.transform);
        StartCoroutine(chasePlayer(enemyVehicle));
    }

    public IEnumerator chasePlayer(GameObject enemyVehicle)
    {
        {
            enemyVehicle.transform.position += (playerVehicle.transform.position - enemyVehicle.transform.position).normalized * speed * Time.deltaTime;
            enemyVehicle.transform.LookAt(playerVehicle.transform);
            yield return null;
        }
    }
}
