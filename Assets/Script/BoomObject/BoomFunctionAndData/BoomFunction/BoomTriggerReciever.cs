using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoomTriggerReviever : BoomFunction {

    public static new BoomClassUID RTTI = new BoomClassUID("BoomTriggerReviever", new BoomTriggerReviever());

    public override BoomClassUID GetRTTI()
    {
        return BoomTriggerReviever.RTTI;
    }

    public BoomTriggerReviever()
    {

    }
 
    public override BoomObject CreateInstance()
    {
        return new BoomTriggerReviever();
    }

    private BoomTriggerData m_Data;

    protected Dictionary<BoomClassUID, BoomTriggerFunction> m_TriggerList = new Dictionary<BoomClassUID, BoomTriggerFunction>();

    public override void Init(BoomFunctionEntity owner)
    {
        base.Init(owner);
        m_Data = Owner.AddData(BoomTriggerData.RTTI) as BoomTriggerData;
        m_Data.TriggerCallBack.BoomOnTriggerEnter += BoomOnTriggerEnter;
    }

    public BoomTriggerFunction AddTriggerFunction(BoomClassUID type)
    {
        if (!m_TriggerList.ContainsKey(type))
        {
            m_TriggerList.Add(type, type.CreateInstance() as BoomTriggerFunction);
            m_TriggerList[type].Init(Owner);
        }
        m_TriggerList[type].AddRef();
        return m_TriggerList[type];
    }
    // Only used for boom function
    public void RemoveTriggerFunction(BoomClassUID type)
    {
        if (!m_TriggerList.ContainsKey(type))
        {
            return;
        }
        m_TriggerList[type].Release();
        if (m_TriggerList[type].RefCount == 0)
        {
            m_TriggerList.Remove(type);
        }
    }

    // Only used for boom function
    public bool HaveTriggerFunction(BoomClassUID type)
    {
        if (m_TriggerList.ContainsKey(type))
        {
            return true;
        }
        return false;
    }
    public void BoomOnTriggerEnter(Collider self,Collider c)
    {
        foreach (KeyValuePair<BoomClassUID, BoomTriggerFunction> kvp in m_TriggerList)
        {
            if (kvp.Value!=null)
            {
                kvp.Value.ExecuteTriggerFunction(self, c);
            }
        }

    }

    public override void ExecuteFunction()
    {
        // Owner.
    }

    public override void Discard()
    {
        Owner.RemoveData(BoomTransFormData.RTTI);
        m_Data = null;
    }
}
