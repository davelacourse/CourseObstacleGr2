using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] private float _vitesse = 20f;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        MouvementsJoueur();
    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        transform.Translate(direction * Time.deltaTime * _vitesse);
    }
}
