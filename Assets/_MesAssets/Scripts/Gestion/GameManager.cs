using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager Instance;

    private float _tempsDepart = 0f;
    public float TempsDepart => _tempsDepart;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private int _collisions;
    public int Collisions => _collisions; // Accesseur

    private void Update()
    {
        //Vérifie si je suis sur une scène qui n'est pas un niveau de jeu
        //Si c'est le cas détruire le GameManager
        if(SceneManager.GetActiveScene().buildIndex == 0 || 
            SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        _collisions = 0;
        _tempsDepart = Time.time;
        Time.timeScale = 1;
        
    }

    public void AugmenterCollision()
    {
        _collisions++;
        UIManagerGame.Instance.ChangerCollisions(_collisions);
    }
}
