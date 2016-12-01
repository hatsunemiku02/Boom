using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class BoomEntity : BoomObject
{

    public static new BoomClassUID RTTI = new BoomClassUID("BoomEntity",new BoomEntity());

    public override BoomClassUID GetRTTI()
    {
        return BoomEntity.RTTI;
    }

    public BoomEntity()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomEntity();
    }

    public virtual void Init(string name)
    {
        m_UnityGO = new GameObject(name);
        m_Bridge = m_UnityGO.AddComponent<BoomUnityObjectBridge>();
        m_Bridge.EntityForBoom = this;
    }

    private GameObject m_UnityGO;
    public GameObject UnityGO
    {
        get
        {
            return m_UnityGO;
        }

    }
    private BoomUnityObjectBridge m_Bridge;
    public BoomUnityObjectBridge Bridge
    {
        get
        {
            return m_Bridge;
        }

    }

    protected Dictionary<BoomClassUID, BoomData> m_DataList = new Dictionary<BoomClassUID, BoomData>();
   
    // Only used for boom function
    public BoomData AddData(BoomClassUID type)
    {
        if (!m_DataList.ContainsKey(type))
        {
            m_DataList.Add(type, type.CreateInstance() as BoomData);
            m_DataList[type].Init(this);
        }
        m_DataList[type].AddRef();
        return m_DataList[type];
    }
    // Only used for boom function
    public void RemoveData(BoomClassUID type)
    {
        if(!m_DataList.ContainsKey(type))
        {
            return;
        }
        m_DataList[type].Release();
        if (m_DataList[type].RefCount==0)
        {
            m_DataList.Remove(type);
        }
    }
    
    // Only used for boom function
    public bool HaveData(BoomClassUID type)
    {
        if (m_DataList.ContainsKey(type))
        {
            return true;
        }
        return false;
    }
}
