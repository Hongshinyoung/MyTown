using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter:MonoBehaviour
{
    //원하는 이미지 클릭 시, 원하는 이미지가 대표이미지로 변경되도록.
    public Image[] characterSprite; //선택할 캐릭터 이미지
    public Image selectedImage; //선택된 이미지


    //인덱스에 맞는 스프라이트 출력
    public void ReplaceImage(int selectIndex)
    {
        if(selectedImage != null)
        {
            selectedImage.sprite = characterSprite[selectIndex].sprite;
        }

        GameManager.Instance.CharacterIndex = selectIndex;
    }

}
