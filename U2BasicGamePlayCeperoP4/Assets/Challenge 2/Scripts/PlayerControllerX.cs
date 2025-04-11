using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 0;

    // Update is called once per frame
    void Update()
    {
        cooldown = cooldown - Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& cooldown <= 0)
        {
            cooldown = 0.75f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
