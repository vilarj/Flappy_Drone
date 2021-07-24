using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float PipesHeight;
    public GameObject buildings;
    public float BuildingsHeight;
    public float MaxTime = 1.0f;
    public float timer = 0.0f;

    void start() {
        GameObject newPipe = Instantiate(pipe);
        GameObject newBuilding = Instantiate(buildings);

        newPipe.transform.position = transform.position + new Vector3(0, PipesHeight, 0);
        newBuilding.transform.position = transform.position + new Vector3(0, BuildingsHeight, 0);
    }

    void Update()
    {
        IncreaseDifficulty();
        
        if (timer > MaxTime) {
            GameObject newPipe = Instantiate(pipe);
            GameObject newBuilding = Instantiate(buildings);

            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(0, PipesHeight), 0);
            newBuilding.transform.position = transform.position + new Vector3(0, BuildingsHeight, 0);

            Destroy(newPipe, 8);
            Destroy(newBuilding, 4);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void IncreaseDifficulty () 
    {
        if (PlayerController.score >= 10 || PlayerController.score < 20) {Pipe.speed = 18.0f;}
        if (PlayerController.score >= 20 || PlayerController.score < 40) {Pipe.speed = 20.0f;}
        if (PlayerController.score >= 40 || PlayerController.score < 60) {Pipe.speed = 27.0f;}
        if (PlayerController.score >= 60 || PlayerController.score < 80) {Pipe.speed = 29.0f;}
        if (PlayerController.score >= 80) {Pipe.speed = 40.0f;}
    }
}
