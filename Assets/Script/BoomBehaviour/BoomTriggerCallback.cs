using UnityEngine;
using System.Collections;

public class BoomTriggerCallback : BoomBehaviour
{
    public delegate void OnTriggerEnterDelegate(Collider sender, Collider c);
    public event OnTriggerEnterDelegate BoomOnTriggerEnter;

    Collider m_Collider;

    // Use this for initialization
    void Start()
    {
        if (m_Collider == null)
        {
            m_Collider = GetComponent<Collider>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider c)
    {
        if(m_Collider==null)
        {
            m_Collider = GetComponent<Collider>();
        }
        if (BoomOnTriggerEnter!=null)
        {
            BoomOnTriggerEnter(m_Collider,c);
        }

    }
}
