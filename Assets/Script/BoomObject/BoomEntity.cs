using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class BoomEntity : BoomObject
{
    protected Dictionary<BoomClassUID, BoomData> m_DataList;

    public GameObject UnityGO
    {
        get;
        set;
    }

    // Only used for boom function
    public void AddData(BoomData data)
    {
        m_DataList.Add(data.ClassRTTI, data);
    }
    // Only used for boom function
    public void RemoveData(BoomData data)
    {
        m_DataList.Remove(data.ClassRTTI);
    }
    
    // Only used for boom function
    public bool HaveData(BoomClassUID uid)
    {
        if (m_DataList.ContainsKey(uid))
        {
            return true;
        }
        return false;
    }
}
