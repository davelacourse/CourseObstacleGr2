using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _panneauInstructions = default;
    [SerializeField] private GameObject _panneauBoutons = default;

    public void Quitter()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void ChangerScene()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(noScene + 1);
    }

    public void AfficherInstructions()
    {
        _panneauBoutons.SetActive(false);
        _panneauInstructions.SetActive(true);
    }

    public void AfficherBoutons()
    {
        _panneauBoutons.SetActive(true);
        _panneauInstructions.SetActive(false);
    }

    public void RetourDebut()
    {
        SceneManager.LoadScene(0);
    }
}
