using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject player;
    public GameObject deathScreen;
    public GameObject controls;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            deathScreen.SetActive(true);
            controls.SetActive(false);
            Destroy(player);
        }
    }
}
