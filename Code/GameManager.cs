using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

{

    public GameObject carPrefab;
    public Transform[] carSpawnPoints;


    // Start is called before the first frame update
    void Start()
    {
        SpawnCar();


    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnCar()
    {

        int index = Random.Range(0, carSpawnPoints.Length);

        Vector3 spawnPos = carSpawnPoints[index].position;

        GameObject car = Instantiate(carPrefab, spawnPos, Quaternion.identity);

        int dirModifier = (index > 2) ? -1 : 1;
    }


        }

car.GetComponent<CarMovement>().speed = Random.Range(3.0f, 6.0f) * dirModifier;



        
    }

}

}