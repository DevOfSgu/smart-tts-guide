namespace TravelSystem.Mobile.Services;

public static class ApiConstants
{
    // Khi chạy ngrok, bạn sẽ copy URL từ ngrok vào đây
    // Ví dụ: "https://a1b2-c3d4.ngrok-free.app"
    public const string BaseApiUrl = "https://YOUR_NGROK_URL_HERE.ngrok-free.app";

    public const string LoginEndpoint = "api/auth/login";
    public const string ToursEndpoint = "api/tours";
}
