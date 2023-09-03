using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The inspiration and solution for this script in terms of the code can be found here: https://stackoverflow.com/questions/36833982/mouse-cursor-is-invisible-in-unity#:~:text=visible%20field%20is%20not%20scene,on%20the%20level%20you%20load.&text=Place%20this%20on%20an%20empty,have%20cursor%20visibility%20handled%20automatically.

public class CursorInvisible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
