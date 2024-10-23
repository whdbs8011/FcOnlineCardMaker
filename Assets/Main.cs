using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject imageObj;
    public GameObject LogoImg;
    public GameObject LogoImg2;
    public GameObject text;

    public GameObject cost;
    //이미지
    public Button ShowButton; //보여주기
    public Button CloseButton; //닫기

    public Button first;
    public Button second;
    public InputField inputField; // 사용자가 텍스트를 입력할 InputField
    public Text displayText;
    // Start is called before the first frame update
    void Start()
    {
        //처음에 안보이게 하는거
        imageObj.SetActive(false);
        LogoImg.SetActive(false);
        LogoImg2.SetActive(false);
        cost.SetActive(false);
        text.SetActive(false);
        
        //버튼 클릭 이밴트
        ShowButton.onClick.AddListener(ShowImage);
        CloseButton.onClick.AddListener(HideImage);
        
        first.onClick.AddListener(firstLogo);
        second.onClick.AddListener(secondLogo);
    }

    void ShowImage()
    {
        imageObj.SetActive(true);
        cost.SetActive(true);
        text.SetActive(true);
    }

    void firstLogo()
    {
        LogoImg.SetActive(true);
        LogoImg2.SetActive(false);
    }

    void HideImage()
    {
        imageObj.SetActive(false);
        LogoImg.SetActive(false);
        LogoImg2.SetActive(false);
        cost.SetActive(false);
        text.SetActive(false);
    }
    void secondLogo()
    {
        LogoImg.SetActive(false);
        LogoImg2.SetActive(true);
    }
}
