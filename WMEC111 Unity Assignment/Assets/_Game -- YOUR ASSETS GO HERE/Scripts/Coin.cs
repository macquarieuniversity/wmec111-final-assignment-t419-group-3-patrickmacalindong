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
            UIManager.Instance.scoreText.text = "Flares: " + UIManager.Instance.scoreCounter + "/5";
            gameObject.SetActive(false);
        }
    }
}


