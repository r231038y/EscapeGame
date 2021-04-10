using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linker : MonoBehaviour
{
    [SerializeField] UIController uIController = null;
    static public UIController UIController = null;

    static public SceneChanger SceneChanger = null;

    void Start()
    {
        UIController = uIController;
        UIController.Initialize();

        SceneChanger = GetComponent<SceneChanger>();
        SceneChanger.Initialize();
    }
}
