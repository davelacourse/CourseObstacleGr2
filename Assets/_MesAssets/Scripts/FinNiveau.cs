using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinNiveau : MonoBehaviour
{
    [SerializeField] private GameObject _player = default;
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Fin de partie");
        Debug.Log("Temps total :" + Time.time + " secondes");
        Debug.Log("Nombre total de collisions : " + GameManager.Instance.Collisions);
        Debug.Log("Temps final : " + (Time.time + GameManager.Instance.Collisions) + " secondes.");
        Destroy(_player);
    }
}
