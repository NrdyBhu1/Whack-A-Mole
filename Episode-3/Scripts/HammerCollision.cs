using System;
using UnityEngine;

public class HammerCollision : MonoBehaviour
{
    #region Variables

    private GameManager _gameManager;
    #endregion

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Mole"))
        {
            Destroy(other.gameObject);
            _gameManager.AddScore();
        }
    }
}
