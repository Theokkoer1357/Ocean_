using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMaster : MonoBehaviour
{
    public void TransitionScene(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
    
}
