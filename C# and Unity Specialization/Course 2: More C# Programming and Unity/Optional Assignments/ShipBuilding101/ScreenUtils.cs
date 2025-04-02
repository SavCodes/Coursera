using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public static class ScreenUtils
{

    #region Fields
    static float screenLeft;
    static float screenRight;
    static float screenTop;
    static float screenBottom;
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
        get {  return screenTop; }
    }

    public static float ScreenBottom
    {
        get { return screenBottom; }
    }
    
    #endregion

    /// <summary>
    /// Gets the screen boundaries based off of the camera's viewport at game launch
    /// </summary>
    public static void Initialize()
    {
        Vector3 screenTopRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Camera.main.nearClipPlane));
        Vector3 screenBottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));

        screenLeft = screenBottomLeft.x;
        screenBottom = screenBottomLeft.y;
        screenRight = screenTopRight.x;
        screenTop = screenTopRight.y;
    }

}
