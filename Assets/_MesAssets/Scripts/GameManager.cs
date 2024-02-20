using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
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
    }

    public void AugmenterCollision()
    {
        _collisions++;
        Debug.Log("Nombre de collisions : " + _collisions.ToString());
    }
}
