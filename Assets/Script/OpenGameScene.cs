using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenGameScene : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("gameScene");
    }
}
