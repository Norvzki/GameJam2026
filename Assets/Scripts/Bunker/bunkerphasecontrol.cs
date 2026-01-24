using UnityEngine;  //main control for phase 2 loop, conditionals n calls n stuff

public class BunkerPhaseController : MonoBehaviour
{
    private BunkerPhase currentPhase;

    private GameState gameState;
    private JournalSystem journalSystem;
    private RandomEncounterSystem encounterSystem;
    private RouteSystem routeSystem;

    private EncounterData currentEncounter;

    void Start()
    {
        gameState = new GameState();
        journalSystem = new JournalSystem();
        encounterSystem = new RandomEncounterSystem();
        routeSystem = new RouteSystem();

        StartDay();
    }

    private void StartDay()
    {
        currentPhase = BunkerPhase.Journal;
        Debug.Log($"--- DAY {gameState.Day} START ---");
        journalSystem.ShowJournal(gameState.Day);
    }

    // jack this to a UI button later ask norvel
    public void OnJournalClosed()
    {
        TriggerEncounter();
    }

    private void TriggerEncounter()
    {
        currentPhase = BunkerPhase.Encounter;

        currentEncounter = routeSystem.TryTriggerRoute(gameState);

        if (currentEncounter == null)
            currentEncounter = encounterSystem.GetDailyEncounter();

        Debug.Log($"Encounter: {currentEncounter.Title}");
        Debug.Log(currentEncounter.Description);
    }

    // jack this to a UI button later ask norvel
    public void OnEncounterResolved()
    {
        ResolveEndOfDay();
    }

    private void ResolveEndOfDay()
    {
        currentPhase = BunkerPhase.EndOfDay;

        ResolveFoodAndWater();
        CheckWinLoss();

        if (currentPhase != BunkerPhase.GameOver)
            AdvanceDay();
    }

    private void ResolveFoodAndWater()
    {
        if (gameState.Inventory.Food <= 0)
            gameState.DaysWithoutFood++;
        else
            gameState.DaysWithoutFood = 0;

        if (gameState.Inventory.Water <= 0)
            gameState.DaysWithoutWater++;
        else
            gameState.DaysWithoutWater = 0;

        if (gameState.DaysWithoutFood >= 7 || gameState.DaysWithoutWater >= 5)
            gameState.AllSurvivorsDead = true;
    }

    private void CheckWinLoss()
    {
        if (gameState.IsRescued)
        {
            Debug.Log("RESCUED — YOU WIN");
            currentPhase = BunkerPhase.GameOver;
        }
        else if (gameState.AllSurvivorsDead)
        {
            Debug.Log("ALL DEAD — GAME OVER");
            currentPhase = BunkerPhase.GameOver;
        }
    }

    private void AdvanceDay()
    {
        routeSystem.AdvanceRoutes(gameState);
        gameState.Day++;
        StartDay();
    }
}
