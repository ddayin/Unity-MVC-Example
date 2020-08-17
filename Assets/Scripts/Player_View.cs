using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_View : MonoBehaviour
{
    private Material m_Material;

    private void Awake()
    {
        m_Material = transform.GetComponent<MeshRenderer>().material;

        m_Material.color = Color.white;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRedColor()
    {
        m_Material.color = Color.red;
    }
}
