using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShootScript : MonoBehaviour
{
    public GameObject bulletObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = (GameObject)Instantiate(bulletObj, gameObject.transform.position, gameObject.transform.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(bullet.transform.forward * 2000);
            Destroy(bullet, 2f);
        }
    }
}
