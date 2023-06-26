using Profile;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

internal class EntryPoint : MonoBehaviour
{
    private const float SpeedCar = 15f;
    private const GameState InitialState = GameState.Start;

    [SerializeField] private Transform _placeForUi;

    private MainController _mainController;


    private void Start()
    {
        var profilePlayer = new ProfilePlayer(SpeedCar, InitialState);
        _mainController = new MainController(_placeForUi, profilePlayer);

        Analytics.CustomEvent("MainMenuOpened");


        //Analytics.CustomEvent("MainMenuOpened", new Dictionary<string, object>()
        //{
         //   ["speed"] = 5,
         //   ["player_name"] = "Jack"
       // });
    }

    private void OnDestroy()
    {
        _mainController.Dispose();
    }
}
