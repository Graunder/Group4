using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{

    //public TextMeshProUGUI scoreText;
    //public int score = 0;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            Destroy(gameObject);
            //score++;
            //scoreText.text = score.ToString();
            ScoreCounter.score++;
        }
    }

}
