using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Player_Model m_Model;
    private Player_View m_View;

    private void Awake()
    {
        m_Model = transform.GetComponent<Player_Model>();
        m_View = transform.GetComponent<Player_View>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Model.m_HP -= 0.01f;
        
        if (m_Model.m_HP < 0.1f)
        {
            m_View.SetRedColor();
        }
    }
}
