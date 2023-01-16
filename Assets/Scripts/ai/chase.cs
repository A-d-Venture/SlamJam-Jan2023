using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{
    [SerializeField] GameObject enemyVehicle;
    [SerializeField] GameObject chaseVehicle;
    [SerializeField] float speed = 0.01f;
    [SerializeField] float attackDistance = 10f;

    // Update is called once per frame
    void Update()
    {
        enemyVehicle.transform.LookAt(chaseVehicle.transform);
        StartCoroutine(chasePlayer(enemyVehicle));
    }

    public IEnumerator chasePlayer(GameObject enemyVehicle)
    {
        //while (Vector3.Distance(chaseVehicle.transform.position, enemyVehicle.transform.position) > attackDistance)
        {
            enemyVehicle.transform.position += (chaseVehicle.transform.position - enemyVehicle.transform.position).normalized * speed * Time.deltaTime;
            enemyVehicle.transform.LookAt(chaseVehicle.transform);
            yield return null;
        }
    }
}
