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
            if(noScene == SceneManager.sceneCountInBuildSettings - 1)
            {
                Debug.Log("Fin de partie");
                Debug.Log("Temps total :" + Time.time + " secondes");
                Debug.Log("Nombre total de collisions : " + GameManager.Instance.Collisions);
                Debug.Log("Temps final : " + (Time.time + GameManager.Instance.Collisions) + " secondes.");
                Destroy(_player);
            }
            else
            {
                SceneManager.LoadScene(noScene + 1);
            }
        }

    }
}
