using System;

namespace WinFormsCommandBinding.Models.Service
{
    public static class ServiceProviderExtension
    {
        static public T GetRequiredService<T>(this IServiceProvider serviceProvider)
        {
            return (T)serviceProvider.GetService(typeof(T))!;
        }
    }
}
