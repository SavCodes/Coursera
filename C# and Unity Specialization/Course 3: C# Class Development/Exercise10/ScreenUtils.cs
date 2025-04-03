using UnityEngine;

public class ScreenUtils : MonoBehaviour
{

    static public Vector2 ScreenLeftTop = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
    static public Vector2 ScreenRightBottom = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Camera.main.transform.position.z));

    #region Fields
    static float screenLeft = ScreenLeftTop.x;
    static float screenRight = ScreenRightBottom.x;
    static float screenTop = ScreenLeftTop.y;
    static float screenBottom = ScreenRightBottom.y;
    #endregion

    #region Properties
    public static float ScreenLeft
    {
        get { return screenLeft; }
    }

    public static float ScreenRight
    {
        get { return screenRight; }
    }

    public static float ScreenTop
    {
        get { return screenTop; }
    }

    public static float ScreenBottom
    {
        get { return screenBottom; }
    }
    #endregion

}
