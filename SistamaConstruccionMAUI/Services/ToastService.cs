using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistamaConstruccionMAUI.Services
{
    public enum ToastType { Success, Error, Info }

    public sealed record ToastMessage(ToastType Type, string Text);

    public sealed class ToastService
    {
        public event Action<ToastMessage>? OnShow;

        public void Success(string text) => OnShow?.Invoke(new ToastMessage(ToastType.Success, text));
        public void Error(string text) => OnShow?.Invoke(new ToastMessage(ToastType.Error, text));
        public void Info(string text) => OnShow?.Invoke(new ToastMessage(ToastType.Info, text));
    }
}
