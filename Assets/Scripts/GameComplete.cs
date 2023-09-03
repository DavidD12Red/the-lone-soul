using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// The inspiration and solution for this script in terms of the code can be found here: https://answers.unity.com/questions/593570/how-do-i-check-if-all-the-objects-are-destroyed-th.html
// Another link that also contributed for the solution at hand: https://answers.unity.com/questions/192195/win-game-based-on-destroying-enemys.html
// Some of the code lines come from the guide via this source link: https://www.codegrepper.com/code-examples/csharp/Unity+c%23loading+a+scene+after+a+few+seconds

public class GameComplete : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Enemy") == null)
        {
            StartCoroutine(ChangeAfterXSecondsCoroutine());
        }
    }

    IEnumerator ChangeAfterXSecondsCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("WinScene");
    }
}
