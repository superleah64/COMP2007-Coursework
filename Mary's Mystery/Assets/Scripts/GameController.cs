using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int collectable = 0;
    public bool collectedAll = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (collectable <= 0)
        {
            collectedAll = true;
        }

        else
        {
            collectedAll = false;
        }

        if (collectedAll == true)
        {
            YouWin();
        }
        void YouWin()
        {
            StartCoroutine(WinScreen());
        }

        // prevents win screen from being displayed until pickup is complete
        IEnumerator WinScreen()
        {
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}