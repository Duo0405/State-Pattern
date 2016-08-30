using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneStateContoller {

    private ISceneState m_State;
    private bool m_bRunBegin = false;
    private AsyncOperation m_nowAsycOperation;

    public SceneStateContoller(){}

    public void SetState(ISceneState State , string LoadSceneName)
    {
        Debug.Log("SetState:" + State.ToString());
        m_bRunBegin = false;

        LoadScene(LoadSceneName);


        //close the front(facade) scene
        if(m_State != null)
        {
            m_State.StateEnd();
        }

        m_State = State;
    }

    public void StateUpdate()
    {
        //Is loading...
        if (m_nowAsycOperation != null && !m_nowAsycOperation.isDone)
        {
            return;
        }

        //let new scene start
        if (m_State != null && m_bRunBegin == false)
        {
            m_State.StateBegin();
            m_bRunBegin = true;
        }

        if (m_State != null)
            m_State.StateUpdate();

    }
    private void LoadScene(string LoadSceneName)
    {
        //loading Scene;
        if (LoadSceneName == null || LoadSceneName.Length == 0)
        {
            return;
        }
        if (m_State != null)
        {
            SceneManager.UnloadScene(m_State.StateName);
        }
        m_nowAsycOperation = SceneManager.LoadSceneAsync(LoadSceneName);
    }
}
