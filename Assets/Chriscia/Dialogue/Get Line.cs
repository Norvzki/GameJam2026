using UnityEngine;
using System.IO;


public class GetstatusLine : MonoBehaviour
{

    public Person person;
    
    public static int RNG(int lines)
    {
        return Random.Range(0,lines);
    }

    public int FileNumber(string category)
    {
        if (category == "Hunger")
        {
            switch (person.hunger)
            {
                case 100: return 0;
                case 80: return 0;
                case 60: return 1;
                case 40: return 2;
                case 20: return 3; 
                default: return 0;
            }
        } else if (category == "Thirst")
        {
            switch (person.thirst)
            {
                case 100: return 0;
                case 75: return 0;
                case 50: return 1;
                case 25: return 2;
                default: return 0;
            }
        }else
        {
            return -1;
        }
        
    }

    public string Getline(string category)
    {
        string path = Path.Combine(Application.dataPath, "Chriscia", "Dialogue", category);

        if (Directory.Exists(path))
        {
            Debug.Log("Directory Found");
        }
       
        string[] files = Directory.GetFiles(path, "*.txt");

        
        int a = FileNumber(category);
        if (a == -1)
        {
            Debug.Log("Cant determine hunger/thirst lvl");
        }

        string[] lines = File.ReadAllLines(files[a]);
        int index = RNG(lines.Length);

        return lines[index];
    }

    
}
