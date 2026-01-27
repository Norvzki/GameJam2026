using UnityEngine;
using UnityEngine.UI;

public class Navigation : MonoBehaviour
{
    public Button next, back;
    public GameObject[] locations;
    private int currentLocation = 0;

    void Start()
    {
        // Validate setup
        if (!ValidateSetup()) return;

        // Initialize - show only first location
        ShowLocation(currentLocation);

        // Add listeners
        next.onClick.AddListener(NextLocation);
        back.onClick.AddListener(PreviousLocation);
    }

    bool ValidateSetup()
    {
        if (next == null || back == null)
        {
            Debug.LogError("Navigation buttons not assigned!");
            return false;
        }

        if (locations == null || locations.Length == 0)
        {
            Debug.LogError("No locations assigned!");
            return false;
        }

        return true;
    }

    void NextLocation()
    {
        int previousLocation = currentLocation;
        currentLocation = (currentLocation + 1) % locations.Length; // Wraps around
        SwitchLocation(previousLocation, currentLocation);
    }

    void PreviousLocation()
    {
        int previousLocation = currentLocation;
        currentLocation = (currentLocation - 1 + locations.Length) % locations.Length; // Wraps around
        SwitchLocation(previousLocation, currentLocation);
    }

    void SwitchLocation(int from, int to)
    {
        if(to == 3)
        {
            back.gameObject.SetActive(false);
        } else
        {
            back.gameObject.SetActive(true);
        }
        locations[from].SetActive(false);
        locations[to].SetActive(true);
    }

    void ShowLocation(int index)
    {
        for (int i = 0; i < locations.Length; i++)
        {
            locations[i].SetActive(i == index);
        }
    }
}