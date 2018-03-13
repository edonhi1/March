using UnityEngine;

public class UIDirectionControl : MonoBehaviour
{
    public bool m_UseRelativeRotation = true;  


    private Quaternion m_RelativeRotation;     


    private void Start()
    {
        //���� ���۽ÿ� �θ��� �����̼� ���� �����ɴϴ�.
        m_RelativeRotation = transform.parent.localRotation;
        
    }


    private void Update()
    {
        if (m_UseRelativeRotation)
            //���� ���۽ÿ� ������ �����̼� ���� ��� �����մϴ�.
            transform.rotation = m_RelativeRotation;
    }
}
