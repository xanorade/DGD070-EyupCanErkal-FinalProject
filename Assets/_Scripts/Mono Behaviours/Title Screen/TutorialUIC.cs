using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialUIC : MonoBehaviour
{
    [SerializeField] private GameObject startButton;
    private GameContext _gameContext;

    private void Awake()
    {
        if (_gameContext == null)
        {
            _gameContext = Contexts.sharedInstance.game;
        }
    }

    public void StartButtonClick()
    {
        GameEntity player = _gameContext.playerEntity;
        player.isAlive = true;
    }
    
    public void ExitButtonClick()
    {
        Application.Quit();
    }
}