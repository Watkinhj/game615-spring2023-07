using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenuScript : MonoBehaviour
{
    int steves;
    public Animator winMenu;

    // Start is called before the first frame update
    void Start()
    {
        steves = GameObject.FindGameObjectsWithTag("steve").Length;
        Debug.Log("Steves on the field: " + steves);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("steve").Length <= 0)
        {
            Debug.Log("Win!");
            winMenu.SetBool("winCondition", true);
        }
    }
}
