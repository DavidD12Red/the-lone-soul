using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The inspiration and solution for this script in terms of the code can be found here: https://stackoverflow.com/questions/36167413/cursor-cant-move-on-scene-switch-unity-5
// Another link for this script in terms of the code: https://answers.unity.com/questions/1408749/how-i-get-mouse-pointer-loading-the-2nd-scene.html

public class VisibleMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
