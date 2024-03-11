using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseSettings : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("gameScene");
    }
}
