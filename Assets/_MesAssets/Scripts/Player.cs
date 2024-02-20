using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] private float _vitesse = 20f;
    private Rigidbody _rb;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MouvementsJoueur();
    }
    
    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        direction.Normalize();

        // Déplacde le joueur(téléportation) sur la scène
        //transform.Translate(direction * Time.deltaTime * _vitesse);

        // Déplace le rigidbody du joueur en applicant une force
        //_rb.AddForce(direction * Time.fixedDeltaTime * _vitesse);

        //Déplace le rigidbody du joueur en utilisatant la vitesse
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
    }

}
