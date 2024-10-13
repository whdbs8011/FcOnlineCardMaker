using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject imageObj; //이미지
    public Button ShowButton; //보여주기
    public Button CloseButton; //닫기
    // Start is called before the first frame update
    void Start()
    {
        //처음에 안보이게 하는거
        imageObj.SetActive(false);
        
        //버튼 클릭 이밴트
        ShowButton.onClick.AddListener(ShowImage);
        CloseButton.onClick.AddListener(HideImage);
    }

    void ShowImage()
    {
        imageObj.SetActive(true);
    }

    void HideImage()
    {
        imageObj.SetActive(false);
    }
}
