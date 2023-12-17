using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Coin":
                GameManager.Instance.AddScore();
                Destroy(other.gameObject, 0.02f);
                break;
            case "Wall":
                GameManager.Instance.GameOver();
                Destroy(gameObject, 0.02f);
                break;
        }
    }
}
