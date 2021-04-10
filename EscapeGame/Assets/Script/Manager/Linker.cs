using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linker : MonoBehaviour
{
    [SerializeField] UIController uIController = null;
    [SerializeField] AudioManager audioManager = null;

    void Start()
    {
        Manager.UIContriller = uIController;
        Manager.UIContriller.Initialize();

        Manager.SceneChanger = GetComponent<SceneChanger>();
        Manager.SceneChanger.Initialize();

        Manager.AudioManager = audioManager;
        Manager.AudioManager.Initialize();
    }

    public static class Manager
    {
        static public UIController UIContriller;
        static public SceneChanger SceneChanger;
        static public AudioManager AudioManager;
    }
}

