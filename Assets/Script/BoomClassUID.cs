using UnityEngine;
using System.Collections;

public class BoomClassUID
{

    public string Content
    {
        set
        {
            m_Content = value;
        }
        get
        {
            return m_Content;
        }
    }

    private string m_Content;

    public static bool operator ==(BoomClassUID rec1, BoomClassUID rec2)
    {
         return Object.Equals(rec1, rec2);
    }
    public static bool operator !=(BoomClassUID rec1, BoomClassUID rec2)
    {
        return !Object.Equals(rec1, rec2);
    }

    public static bool Equals(BoomClassUID objA, BoomClassUID objB)
    {
        string ca = "";
        string cb = "";
        if(objA!=null)
        {
            ca = objA.m_Content;
        }
        if (objB != null)
        {
            cb = objB.m_Content;
        }

        if(ca==cb)
        {
            return true;
        }

        return false;

    }

    public override bool Equals(object obj)
    {
        //判断与之比较的类型是否为null。这样不会造成递归的情况  
        if (obj == null)
            return false;
        if (GetType() != obj.GetType())
            return false;
        BoomClassUID uid = obj as BoomClassUID;
        if (this.m_Content == uid.m_Content)
        {
            return true;
        }
        return false;
    }
 
}
