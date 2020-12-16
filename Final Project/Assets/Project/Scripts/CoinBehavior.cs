using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    GameManagerScript GMS;
    private float rotateSpeed = 10f;

    // Start is called before the first frame update

    void Awake()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        GMS.current_coins++;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * rotateSpeed);
    }

    // Removes the coin from maze when player hits it
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            Destroy(gameObject);
            GMS.current_coins--;
            GMS.UpdateUI();
        }
    }
}
