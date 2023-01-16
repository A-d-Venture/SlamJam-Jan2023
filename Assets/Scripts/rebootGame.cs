using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rebootGame : MonoBehaviour
{
    [SerializeField] private string resetKey = "Jump";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(resetKey)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
