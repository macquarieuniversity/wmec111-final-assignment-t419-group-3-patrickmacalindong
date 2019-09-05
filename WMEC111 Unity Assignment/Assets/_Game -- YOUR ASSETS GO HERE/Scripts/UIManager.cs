using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;

    private void Awake()
    {
        Instance = this;
    }

    public int scoreCounter;
    public Text scoreText;
    public AudioSource winSound;
    private bool _playerHasWon = false;

    private void Update()
    {
        if (scoreCounter == 5 && !_playerHasWon)
        {
            scoreText.text = "You win. Number 1 victory royale.";
            winSound.Play();
            _playerHasWon = true;
        }
    }
}
