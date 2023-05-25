using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatTrap : MonoBehaviour
{
    public GameObject text;

    void Start()
    {
        text.SetActive(false);  
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player" && GameVariable.keyCount == 4)
        {
            Destroy(gameObject);
            text.SetActive(true);
        }
    }
}
