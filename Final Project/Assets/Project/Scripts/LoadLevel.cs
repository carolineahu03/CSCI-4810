﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public int levelToLoad;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            //SceneManager.LoadScene(levelToLoad);
            Application.LoadLevel(levelToLoad);
        }
    }
}
