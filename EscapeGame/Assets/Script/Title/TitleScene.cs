using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : MonoBehaviour
{
    [SerializeField] TitlePanel titlePanel = null;

    private void Start()
    {
        titlePanel.Initialize();
    }
}
