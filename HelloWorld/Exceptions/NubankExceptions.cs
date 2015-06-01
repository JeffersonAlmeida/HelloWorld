using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace HelloWorld.Exceptions
{
    public class NubankExceptions
    {
        private static string notFound = "Parece que você está sem internet! Por favor, verifique a sua conexão e tente novamente.";
        private static string xx4 = "Houve algum erro com o seu pedido";
        private static string xx5 = "Desculpe, estamos enfrentando problemas técnicos. Por favor, tente novamente mais tarde.";

        private WebException e;
        public NubankExceptions(WebException exception)
        {
            e = exception;
        }

        public void handle()
        {
            HttpWebResponse response = (System.Net.HttpWebResponse) e.Response;
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                MessageBox.Show(notFound);
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.ExpectationFailed
                || response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.Gone
                || response.StatusCode == HttpStatusCode.LengthRequired || response.StatusCode == HttpStatusCode.ProxyAuthenticationRequired
                || response.StatusCode == HttpStatusCode.RequestEntityTooLarge)
            {
                MessageBox.Show(xx4);
            }
            else if (response.StatusCode == HttpStatusCode.BadGateway || response.StatusCode == HttpStatusCode.Conflict
                || response.StatusCode == HttpStatusCode.GatewayTimeout || response.StatusCode == HttpStatusCode.HttpVersionNotSupported
                || response.StatusCode == HttpStatusCode.InternalServerError || response.StatusCode == HttpStatusCode.ServiceUnavailable)
            {
                MessageBox.Show(xx5);
            }
        }
    }
}
