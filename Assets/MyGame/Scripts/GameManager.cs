using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject target;
    public float waitingForSpawn = 2;
    public float countdown = 2;

    public AudioSource shootSound;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Target")
        {
            Debug.Log("hello");
            SpawnTargets();

        }
    }

    private void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            Debug.Log("help");
            countdown = waitingForSpawn;
            SpawnTargets();
        }
    }
    
    void OnMouseDown()
    {
        shootSound = GetComponent<AudioSource>();
        shootSound.Play(1);
    }


    void SpawnTargets()
    {
 
    Vector2 position = new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 2f));

    Instantiate(target, position, Quaternion.identity);

    }

}



