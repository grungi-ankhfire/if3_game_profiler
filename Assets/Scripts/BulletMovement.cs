using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject spawner = GameObject.Find("Spawner");
        float distance = Vector3.Distance(GetComponent<Transform>().position, spawner.GetComponent<Transform>().position);
        speed += distance * Time.deltaTime;

        GetComponent<Transform>().position = GetComponent<Transform>().position + GetComponent<Transform>().forward * speed * Time.deltaTime;

        RaycastHit hit;
        if (Physics.Raycast(GetComponent<Transform>().position, GetComponent<Transform>().forward, out hit, 0.5f)) {
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
            foreach(GameObject bullet in bullets) {
                if (hit.collider.gameObject == bullet) {
                    speed *= -1f;
                }
            }
            
            if (hit.collider.tag == "Obstacle") {
                Destroy(gameObject);
            }
        }
        
    }
}
