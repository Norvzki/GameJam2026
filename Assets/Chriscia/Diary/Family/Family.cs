using UnityEngine;

public class Family : MonoBehaviour
{
    public CharacterUpdate Father;
    public CharacterUpdate Mother;
    public CharacterUpdate Ate;
    public CharacterUpdate Kuya;

    void Awake()
    {
        if (Father != null) Father.Member = new Person("Ted");
        if (Mother != null) Mother.Member = new Person("Sylvia");
        if (Ate != null) Ate.Member = new Person("Zerika");
        if (Kuya != null) Kuya.Member = new Person("Zachary");
    }
}
