using TMPro;
using UnityEngine;

public class UIManagerGame : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtTemps = default;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        float temps = Time.time - GameManager.Instance.TempsDepart;
        _txtTemps.text = "Temps : " + temps.ToString("f2");
    }
}
