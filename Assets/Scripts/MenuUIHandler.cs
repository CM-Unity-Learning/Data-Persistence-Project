using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField playerInput;
    public GameController controller;

    private void Awake()
    {
        controller = FindObjectOfType<GameController>();
    }
    private void Start()
    {
        playerInput.text = controller.PlayerName;
    }

    public void OnStartClick()
    {
        controller.SetPlayerName(playerInput.text);
        SceneManager.LoadScene("main");
    }

    public void ExitButtonClick()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif

    }
}
