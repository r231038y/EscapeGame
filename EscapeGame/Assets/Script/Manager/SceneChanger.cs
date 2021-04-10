using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public enum SceneName
    {
        ManagerScene,
        TitleScene,
        RoomScene,
        GameScene,
        PuzzleScene,
    }

    SceneName currentScene = SceneName.ManagerScene;
    [SerializeField] SceneName defaultLoadScene = SceneName.TitleScene;

    public void Initialize()
    {
        ChangeScene(defaultLoadScene);
    }

    public void ChangeScene(SceneName sceneName)
    {
        if (currentScene == SceneName.ManagerScene)
        {
            SceneManager.LoadScene(sceneName.ToString(), LoadSceneMode.Additive);
        }
        else
        {
            SceneManager.UnloadSceneAsync(currentScene.ToString());
            SceneManager.LoadScene(sceneName.ToString(), LoadSceneMode.Additive);
        }
        currentScene = sceneName;
    }
}
