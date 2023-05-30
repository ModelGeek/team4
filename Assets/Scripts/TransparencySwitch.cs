using UnityEngine;

public class TransparencySwitch : MonoBehaviour
{
    public Material transparentMaterial; // ������ Material
    public Material opaqueMaterial; // �������� Material

    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material = opaqueMaterial; // �ʱ⿡�� �������� Material�� ����
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mop"))
        {
            renderer.material = transparentMaterial; // Ư�� ��ü�� �浹 �� ������ Material�� ����
        }
    }

}
