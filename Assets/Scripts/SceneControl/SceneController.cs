using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    [SerializeField] TMP_Text countdown;

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public IEnumerator LoadGameScene()
    {
        yield return new WaitForSeconds(1);

        countdown.text = "Starts in 3..";
        yield return new WaitForSeconds(1);

        countdown.text = "Starts in 2..";
        yield return new WaitForSeconds(1);

        countdown.text = "Starts in 1..";
        yield return new WaitForSeconds(1);

        countdown.text = "Start!";
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
