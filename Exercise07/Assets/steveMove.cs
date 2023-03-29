using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steveMove : MonoBehaviour
{
    public Rigidbody rb;
    float moveSpeed = 3f;
    public GameObject bullet;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Time.deltaTime * moveSpeed, 0, 0, Space.Self);
        GameObject bullet = GameObject.Find("bulletObj");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("wall"))
        {
            gameObject.transform.Rotate(0, 180, 0, Space.World);
        }

        if (other.CompareTag("bullet"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
