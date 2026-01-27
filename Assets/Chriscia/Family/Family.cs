using UnityEngine;
using UnityEngine.TextCore.Text;

public class Family : MonoBehaviour
{
    public CharacterUpdate Father;
    public CharacterUpdate Mother;
    public CharacterUpdate Ate;
    public CharacterUpdate Kuya;

    void Awake()
    {
        if (Father != null) Father.Member = new Person("Ted"); Father.aid_toggle.gameObject.SetActive(false);
        if (Mother != null) Mother.Member = new Person("Sylvia"); Mother.aid_toggle.gameObject.SetActive(false);
        if (Ate != null) Ate.Member = new Person("Zerika"); Ate.aid_toggle.gameObject.SetActive(false);
        if (Kuya != null) Kuya.Member = new Person("Zachary"); Kuya.aid_toggle.gameObject.SetActive(false);

    }


}
