using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveau : MonoBehaviour
{
    [SerializeField] private GameObject _player = default;



    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            int noScene = SceneManager.GetActiveScene().buildIndex;
            if(noScene != SceneManager.sceneCountInBuildSettings - 1)
            {
                SceneManager.LoadScene(noScene + 1);
            }
        }

    }
}
