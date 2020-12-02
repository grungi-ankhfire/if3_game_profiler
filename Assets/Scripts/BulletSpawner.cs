using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float movementAmplitude;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = new Vector3(0, movementAmplitude * Mathf.Sin(Time.time), 0);
        GetComponent<Transform>().Rotate(new Vector3(0,0, rotationSpeed * Time.deltaTime));


        Instantiate(bulletPrefab, GetComponent<Transform>().position + 0.5f * GetComponent<Transform>().right,  GetComponent<Transform>().rotation);

    }
}
