using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyUs : MonoBehaviour{
    public int attackDamage = 1;
    GameObject PlayerObject;
    PlayerHealth playerHealth;

    void Awake()
    {
        PlayerObject = GameObject.FindGameObjectWithTag ("Player");
        playerHealth = PlayerObject.GetComponent <PlayerHealth> ();

        if (PlayerObject != null)
        {
            playerHealth = PlayerObject.GetComponent<PlayerHealth>();
        }
    PlayerObject = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == PlayerObject)
        {
            playerHealth.TakeDamage (attackDamage);
            Destroy (gameObject);
        }
    }

    

}
