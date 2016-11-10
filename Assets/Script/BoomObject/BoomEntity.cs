using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class BoomEntity : BoomObject
{

    public static new BoomClassUID RTTI = new BoomClassUID("BoomEntity");

    public override BoomClassUID GetRTTI()
    {
        return BoomEntity.RTTI;
    }

    protected Dictionary<BoomClassUID, BoomData> m_DataList;

    public GameObject UnityGO
    {
        get;
        set;
    }

    // Only used for boom function
    public void AddData(BoomData data)
    {
        m_DataList.Add(data.GetRTTI(), data);
    }
    // Only used for boom function
    public void RemoveData(BoomData data)
    {
        m_DataList.Remove(data.GetRTTI());
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
