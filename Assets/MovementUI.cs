using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovementUI : MonoBehaviour
{
    public BallMovement ball;
    private Image leftImage;
    private Image rightImage;
    private Image upImage;
    private Image downImage;
    private void Start()
    {
        leftImage = transform.Find("LeftImage").GetComponent<Image>();
        rightImage = transform.Find("RightImage").GetComponent<Image>();
        upImage = transform.Find("UpImage").GetComponent<Image>();
        downImage = transform.Find("DownImage").GetComponent<Image>();
    }
    private void IsMouseOverUIElement(List<RaycastResult> raycastResults) {
        for (int i = 0; i < raycastResults.Count; i++) {
            RaycastResult currentRaycastResult = raycastResults[i];
            if (currentRaycastResult.gameObject == leftImage.gameObject)
            {
                ball.MoveLeft();
            }
            else if (currentRaycastResult.gameObject == rightImage.gameObject) 
            {
                ball.MoveRight();
            }
            else if (currentRaycastResult.gameObject == upImage.gameObject)
            {
                ball.MoveUp();
            }
            else if (currentRaycastResult.gameObject == downImage.gameObject)
            {
                ball.MoveDown();
            }
        }
    }
    private void Update()
    {
        IsMouseOverUIElement(GetEventSystemRaycastResults());
    }
    static List<RaycastResult> GetEventSystemRaycastResults()
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = Input.mousePosition;
        List<RaycastResult> raysastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raysastResults);
        return raysastResults;
    }
}
