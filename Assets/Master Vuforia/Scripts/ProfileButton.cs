using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProfileButton : MonoBehaviour
{
    [Header("Profile")]
    [SerializeField] private ProfileDataSO profileData;
    // Start is called before the first frame update

    [Header("References")]
    [SerializeField] private TextMeshProUGUI profileTxt;
    [SerializeField] private Image profileImg;

    private void Start()
    {
        //Consume
        profileImg.sprite = profileData.profileSprite;

        if(profileData.useProfileText && profileTxt != null)
        {
            profileTxt.text = profileData.profileText;
        }
    }

    public void Execute(){
        Application.OpenURL(profileData.GetURL());
    }

}
