using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private PlayerInventoryDisplay _playerInventoryDisplay;
    private int _totalStars;

    private void Awake()
    {
        _playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Star"))
        {
            _totalStars++;
            _playerInventoryDisplay.OnChangeCarryingStar(_totalStars);
            Destroy(collision.gameObject);
        }
    }

}
