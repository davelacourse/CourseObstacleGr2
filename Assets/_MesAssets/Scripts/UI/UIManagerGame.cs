using TMPro;
using UnityEngine;

public class UIManagerGame : MonoBehaviour
{
    public static UIManagerGame Instance;

    [SerializeField] private TMP_Text _txtTemps = default;
    [SerializeField] private TMP_Text _txtCollisions = default;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        _txtCollisions.text  = "Collisions : " + GameManager.Instance.Collisions;
    }

    void Update()
    {
        float temps = Time.time - GameManager.Instance.TempsDepart;
        _txtTemps.text = "Temps : " + temps.ToString("f2");
    }

    public void ChangerCollisions(int p_pointage)
    {
        _txtCollisions.text = "Collisions : " + p_pointage.ToString();
    }
}
