using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzleController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<ButtonScript> buttons = new List<ButtonScript>();
    Dictionary<float, ButtonScript> buttonPosition = new Dictionary<float, ButtonScript>();
    float[] dx = { 1.5f, -1.5f, 0, 0, 0 };
    float[] dz = { 0, 0, 1.5f, -1.5f, 0 };
    int goal = 9;

    int counter;
    
    void Start()
    {
        counter = 0;
        foreach(var button in buttons)
        {
            buttonPosition[CalcurateHash(button.transform.position)] = button;
            if (button.Init() > 0) counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                Vector3 hitPos = hit.collider.gameObject.transform.position;
                for (int i=0; i < dx.Length; i++)
                {
                    var dVector = new Vector3(hitPos.x + dx[i], hitPos.y, hitPos.z + dz[i]);
                    ButtonScript targetButton;
                    if(buttonPosition.TryGetValue(CalcurateHash(dVector), out targetButton))
                    {
                        counter += targetButton.ToggleStatus();
                    }
                }
            }
            if (counter == goal)
            {
                // Write programs after goal
                Debug.Log("Clear");
            }
        }
    }

    float CalcurateHash(Vector3 position)
    {
        return position.x * 100f + position.z;
    }
}
