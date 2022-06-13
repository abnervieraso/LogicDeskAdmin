using LogicDeskAdmin.Forms.Utils;
using LogicDeskAdmin.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.Remote
{
    public static class Utils
    {
        public static ResponseWrapper<T?>? ProcessResponse<T>(this RestResponse<ResponseWrapper<T?>> response)
        {
            var statusCode = (uint)response.StatusCode;
            if (statusCode >= 500 && statusCode <= 599)
            {
                if (response.Content is string content)
                    new Forms.RawResponsePreview(content, statusCode).ShowDialog(FormUtils.MainForm);
                //return default;
            }

            if (response.Data?.RMessage is string msg)
            {
                TaskDialogIcon icon;

                switch (response.Data!.RMessageIcon) {
                    case 1:
                        icon = TaskDialogIcon.Error;
                        break;
                    case 2:
                        icon = TaskDialogIcon.Warning;
                        break;
                    default:
                        icon = TaskDialogIcon.Information;
                        break;
                };

                var tdp = new TaskDialogPage()
                {
                    Text = msg,
                    Caption = "Respuesta del servidor",
                    Icon = icon,
                    AllowCancel = true
                };

                TaskDialog.ShowDialog(FormUtils.MainForm!, tdp);
            }

            if (response.ErrorMessage is not null)
            {
                var tdp = new TaskDialogPage()
                {
                    Heading = "Error de la aplicación",
                    Caption = "Notificación",
                    Text = response.ErrorMessage,
                    Icon = TaskDialogIcon.Error,
                    AllowCancel = true
                };
                
                TaskDialog.ShowDialog(FormUtils.MainForm!, tdp);
            }
            //TODO: Check de IsValidResponse y mostrar diálogo.
            return response.Data;
        }
    }
}
