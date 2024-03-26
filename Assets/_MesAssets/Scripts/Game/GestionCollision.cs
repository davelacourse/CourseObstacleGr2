using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    [SerializeField] private Material _materielTouche = default;
    private bool _touche;
    
    private void Start()
    {
        _touche = false;
    }

    /*
     * Rôle : saisir la collisation avec un autre objet
     * Entrée : Pramètre qui représente l'objet (collider) qui a causé le contact
     * Sortie : rien
     */
    private void OnCollisionEnter(Collision collision)
    {
        if (!_touche && collision.gameObject.tag == "Player")
        {
            // Change la couleur du matériel lors de la la collision
            // GetComponent<MeshRenderer>().material.color = Color.red;

            // Change le matétiel lors de la collision
            GetComponent<MeshRenderer>().material = _materielTouche;
            _touche = true;
            GameManager.Instance.AugmenterCollision();
        }
 
    }
}
