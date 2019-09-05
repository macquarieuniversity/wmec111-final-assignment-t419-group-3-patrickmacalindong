using UnityEngine;
using UnityEngine.UI;


public class Coin : MonoBehaviour
{
    public string hitTag = "Player";

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag(hitTag))
        {
            UIManager.Instance.scoreCounter++;
            UIManager.Instance.scoreText.text = "Score: " + UIManager.Instance.scoreCounter;
            gameObject.SetActive(false);
        }
    }
}


