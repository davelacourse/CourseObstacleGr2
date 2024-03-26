using UnityEngine;

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

    private void Start()
    {
        _collisions = 0;
        _tempsDepart = Time.time;
        
    }

    public void AugmenterCollision()
    {
        _collisions++;
        UIManagerGame.Instance.ChangerCollisions(_collisions);
    }
}
