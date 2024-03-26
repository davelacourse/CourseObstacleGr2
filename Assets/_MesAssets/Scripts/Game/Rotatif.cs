using UnityEngine;

public class Rotatif : MonoBehaviour
{
    [SerializeField] private float _rotationY = 20f;

    private void Update()
    {
        transform.Rotate(0f, _rotationY * Time.deltaTime, 0f);
    }
}
