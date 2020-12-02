using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float movementAmplitude;
    public float rotationSpeed;

    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = initialPosition + new Vector3(0, movementAmplitude * Mathf.Sin(Time.time), 0);
        GetComponent<Transform>().Rotate(new Vector3(rotationSpeed * Time.deltaTime,0, 0));


        Instantiate(bulletPrefab, GetComponent<Transform>().position + 0.5f * GetComponent<Transform>().forward,  GetComponent<Transform>().rotation);

    }
}
