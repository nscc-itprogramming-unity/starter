using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void GameStateEvent(bool successful);

    public static event GameStateEvent OnGameStateChange;

    public static void ChangeGameState(bool successful)
    {
        if (OnGameStateChange != null)
        {
            OnGameStateChange.Invoke(successful);
        }
    }
}
