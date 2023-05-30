using UnityEngine;

public class DebrisManager : MonoBehaviour
{
    public GameObject debrisPrefab;
    public float minDelay = 2f; // �ּ� ������ �ð�
    public float maxDelay = 5f; // �ִ� ������ �ð�

    private void Start()
    {
        // �溸�� ���� Ÿ�ֿ̹� �︰ �� ���� �ð�(4��)�� ���� �Ŀ� Debris ������Ʈ�� �����ϴ� �޼��带 ȣ��
        float randomDelay = Random.Range(minDelay, maxDelay);
        Invoke("DropDebris", randomDelay + 4f);
    }

    private void DropDebris()
    {
        // Debris ������Ʈ ���� �� �ʿ��� ����
        Instantiate(debrisPrefab, transform.position, Quaternion.identity);
    }
}
