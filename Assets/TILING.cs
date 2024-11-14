using UnityEngine;

public class TILING : MonoBehaviour
{
    public Material backgroundMaterial; // Material for the background
    public Camera mainCamera;           // Reference to the main camera
    private float backgroundWidth;      // Width of the background image
    private float backgroundHeight;     // Height of the background image

    void Start()
    {
        // Get the dimensions of the background texture (assuming it's a texture)
        backgroundWidth = backgroundMaterial.mainTexture.width;
        backgroundHeight = backgroundMaterial.mainTexture.height;
    }

    void Update()
    {
        // Get the camera's orthographic size and aspect ratio
        float screenWidth = mainCamera.orthographicSize * 2 * Screen.width / Screen.height;
        float screenHeight = mainCamera.orthographicSize * 2;

        // Calculate the tiling factors based on the screen size
        float tileX = screenWidth / backgroundWidth;
        float tileY = screenHeight / backgroundHeight;

        // Apply tiling to the background material
        backgroundMaterial.mainTextureScale = new Vector2(tileX, tileY);
    }
}
