using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<Material> color; //index0:isPushed index1:isNotPushed
    [SerializeField] bool isPushed;
    Renderer buttonRenderer;
    public int Init()
    {
        buttonRenderer = GetComponent<Renderer>();
        return ChangeColor();
    }

    public int ChangeColor()
    {
        if (isPushed)
        {
            buttonRenderer.material = color[0];
            return 1;
        }
        else
        {
            buttonRenderer.material = color[1];
            return -1;
        }
    }

    public int ToggleStatus()
    {
        isPushed = !isPushed;
        return ChangeColor();
    }
}
