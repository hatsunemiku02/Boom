using UnityEngine;
using System.Collections;

public class BoomTriggerData : BoomData {

    public static new BoomClassUID RTTI = new BoomClassUID("BoomTriggerData", new BoomTriggerData());

    public override BoomClassUID GetRTTI()
    {
        return BoomTriggerData.RTTI;
    }

    public BoomTriggerData()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomTriggerData();
    }
    private Rigidbody m_RigidBody;
    private Collider m_Trigger;
    private BoomTriggerCallback m_TriggerCallBack;

    public BoomTriggerCallback TriggerCallBack
    {
        get
        {
            return m_TriggerCallBack;
        }
    }

    public override void Init(BoomEntity owner)
    {
        base.Init(owner);
        m_Trigger = Owner.UnityGO.GetComponent<Collider>();
        if(m_Trigger == null)
        {
            m_Trigger = Owner.UnityGO.AddComponent<SphereCollider>();
        }
        m_Trigger.isTrigger = true;


        m_RigidBody = Owner.UnityGO.GetComponent<Rigidbody>();
        if (m_RigidBody == null)
        {
            m_RigidBody = Owner.UnityGO.AddComponent<Rigidbody>();
            m_RigidBody.useGravity = false;
            m_RigidBody.isKinematic = true;
        }

        m_TriggerCallBack = Owner.UnityGO.GetComponent<BoomTriggerCallback>();
        if (m_TriggerCallBack == null)
        {
            m_TriggerCallBack = Owner.UnityGO.AddComponent<BoomTriggerCallback>();
        }
       
    }

}
