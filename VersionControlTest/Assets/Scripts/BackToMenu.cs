using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{

    [SerializeField] private Button back;
    // Start is called before the first frame update

    public void BackToManu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
