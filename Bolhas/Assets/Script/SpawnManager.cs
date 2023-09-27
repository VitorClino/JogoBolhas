using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject bolhas;
    public float raio = 10f;
    public float time = 1f, force = 5f, distanciaY = 0f;

    void OnEnable()
    {
        InvokeRepeating("Spawnbolhas", 0.1f, time);
    }
    void Spawnbolhas()
    {
        if(Time.timeScale == 1)
        {
            Vector3 randomPosition = Random.insideUnitSphere * raio;
            randomPosition.y = distanciaY;
            GameObject newBolha = Instantiate(bolhas, randomPosition, Quaternion.identity);

            Rigidbody rb = newBolha.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
