using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class TriggerEvent : MonoBehaviour
{
    public string hitTag = "Player";

    // 2D
    /*
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag(hitTag))
        {
            int activeScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(activeScene);
        }
    }
    */

    // 3D
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag(hitTag))
        {
            int activeScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(activeScene);
        }
    }
}


