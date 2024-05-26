using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    // Velocidade de rotação em graus por segundo
    public float rotationSpeed = 100f;
    // Eixo de rotação (Vector3.right, Vector3.up, Vector3.forward, ou qualquer vetor personalizado)
    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        // Rotaciona o objeto ao redor do eixo especificado
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
