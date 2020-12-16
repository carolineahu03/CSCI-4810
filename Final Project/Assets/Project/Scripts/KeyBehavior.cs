using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : MonoBehaviour
{
    GameManagerScript GMS;

    void Awake()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        GMS.current_keys++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Removes key when player hits it
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            Destroy(gameObject);
            GMS.current_keys--;
            GMS.UpdateUI2();
        }
    }
}
