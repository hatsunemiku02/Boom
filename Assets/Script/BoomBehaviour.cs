using UnityEngine;
using System.Collections;

public class BoomBehiever : MonoBehaviour {

    bool m_HaveStarted = false;
	// Use this for initialization
	void Start () {
        m_HaveStarted = true;
        OnShow();
    }
    void OnEnable()
    {
        if (m_HaveStarted == true)
        {
            OnShow();
        }
    }

    void OnDisable()
    {
        OnHide();

    }

    void OnDestory()
    {
        OnHide();

    }
	// Update is called once per frame
	void Update () {
	
	}

   public virtual void OnShow()
    {


    }

    public virtual void OnHide()
    {

    }
}
