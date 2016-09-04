using UnityEngine;
using System.Collections;
using System;

public class GameLoop : MonoBehaviour {

    SceneStateContoller m_SceneStateController = new SceneStateContoller();


    void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);

        UnityEngine.Random.seed = (int)DateTime.Now.Ticks;
    }

	// Use this for initialization
	void Start () {
        m_SceneStateController.SetState(new StartState(m_SceneStateController),"");

	}
	
	// Update is called once per frame
	void Update () {
        m_SceneStateController.StateUpdate();
	
	}
}
