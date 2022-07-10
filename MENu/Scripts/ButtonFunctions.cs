using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    public string StartSceneName;
    public GameObject Curtain;

    public float CurtainDropTime = 5f;

    private Image curtain;

    private bool fade = false;

    private void Start()
    {
        curtain = Curtain.GetComponent<Image>();
    }

    private void Update()
    {
        DropCurtain();
    }

    public void QuitFunc()
    {
        Application.Quit();
    }

    public void StartFunc()
    {
        Curtain.SetActive(true);
        fade = true;
    }

    private void DropCurtain()
    {
        if (fade)
        {
            if (curtain.color.a < 1)
            {
                curtain.color = new Color(0, 0, 0, curtain.color.a + CurtainDropTime * Time.deltaTime);
            }
            else
            {
                SceneManager.LoadScene(StartSceneName, LoadSceneMode.Single);
            }
        }
    }
}
