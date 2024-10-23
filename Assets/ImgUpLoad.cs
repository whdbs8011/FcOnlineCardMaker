using UnityEngine;
using System.IO;
using SFB;
using UnityEngine.UI; // StandaloneFileBrowser 네임스페이스 추가

public class ImageLoader : MonoBehaviour
{
    public RawImage displayImage; // 이미지를 표시할 UI 요소

    // 파일을 선택하는 함수
    public void LoadImage()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Select Image", "", "png,jpg,jpeg", false); // 파일 선택 창 띄우기
        if (paths.Length > 0) // 파일 선택이 되었을 때
        {
            string path = paths[0]; // 선택된 파일 경로 가져오기
            byte[] imageData = File.ReadAllBytes(path); // 이미지 파일 읽기
            Texture2D texture = new Texture2D(2, 2); // 빈 Texture2D 생성
            texture.LoadImage(imageData); // 이미지 데이터로 텍스처 채우기

            displayImage.texture = texture; // RawImage에 텍스처 적용
        }
    }
}