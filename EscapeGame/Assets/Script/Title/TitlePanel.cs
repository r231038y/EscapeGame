using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitlePanel : MonoBehaviour
{
    [SerializeField] Button startButton = null;

    public void Initialize()
    {
        startButton?.onClick.AddListener(StartEscapeGame);
    }

    void StartEscapeGame()
    {
        Linker.SceneChanger.ChangeScene(SceneChanger.SceneName.RoomScene);
    }
}
