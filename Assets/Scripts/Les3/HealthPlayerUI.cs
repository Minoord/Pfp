using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayerUI : MonoBehaviour
{
    [SerializeField] private Text _text;
    private PlayerHealthComponent _playerHealthComponent;

    private void Start()
    {
        _playerHealthComponent = FindObjectOfType<PlayerHealthComponent>();
        if(_playerHealthComponent == null)
        {
            Debug.Log("No PlayerHealthComponent");
        }
        //UpdateUI();
    }

    public void UpdateUI(float NrOfLives)
    {
         NrOfLives = _playerHealthComponent.CurrentHealth;
        _text.text = "Player Lives: " + NrOfLives;
    }

}
