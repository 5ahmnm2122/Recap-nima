using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Target : MonoBehaviour
{

    public float score = 0;
    public float newScore;
    public GameObject scoreText;
    public GameObject winningText;

    public GameObject target;

    public AudioSource hitSound;
    public AudioSource winSound;

    private void OnMouseDown()
    {
        SpawnTargets();
        Destroy(gameObject);
        newScore = score + 1;
        score = newScore;
        scoreText.GetComponent<Text>().text = "" + score;
        Debug.Log("target got hit");

       //hitSound.GetComponent<AudioSource>();
        //hitSound.Play(1);

        if (newScore >= 10)
        {
            Debug.Log("show winning text");
            winningText.SetActive(true);

            winSound.GetComponent<AudioSource>();
            winSound.Play(1);

        }

    }

    void SpawnTargets()
    {
        Debug.Log("Spawn");
        Vector2 position = new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 2f));

        Instantiate(target, position, Quaternion.identity);

    }
}
