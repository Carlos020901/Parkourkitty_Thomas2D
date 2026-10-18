using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOnTouch : MonoBehaviour
{
    public string playerTag = "Player";
    public string gameOverScene = "GameOver";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            SceneManager.LoadScene(gameOverScene);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            SceneManager.LoadScene(gameOverScene);
        }
    }
}