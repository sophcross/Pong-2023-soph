using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public static BallSpawner Instance;

    public Transform spawnPosition;
    public GameObject ballPrefab;

    GameObject currentBall;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void SpawnBall()
    {
        currentBall = Instantiate(ballPrefab, spawnPosition.position, transform.rotation, null);

        float randX = Random.Range(0, 2) * 2 - 1;
        float randY = Random.Range(-1.5f, 1.5f);
        Vector3 newDirection = new Vector3(randX, randY, 0);

        currentBall.GetComponent<Ball>().direction = newDirection;

    }
}
