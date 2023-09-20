using Microsoft.JSInterop;

namespace BlazorWeb_Server.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToaStrSuccess(this IJSRuntime jSRuntime,string message)
        {
            await jSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async ValueTask ToaStrFail(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("ShowToastr",  "error", message);
        }
    }
}
