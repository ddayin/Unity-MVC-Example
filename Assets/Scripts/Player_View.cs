using UnityEngine;

public class Player_View : MonoBehaviour
{
    private Material m_Material;

    private void Awake()
    {
        m_Material = transform.GetComponent<MeshRenderer>().material;

        m_Material.color = Color.white;
    }

    public void SetRedColor()
    {
        m_Material.color = Color.red;
    }
}