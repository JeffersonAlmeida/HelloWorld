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

namespace HelloWorld.json
{
    public static class JsonString
    {
        public static string getJsonString()
        {
            return @"[
  {
    'bill': {
      'state': 'overdue',
      'id': '55256cd0-10f7-4fd3-a3be-213bfe01857d',
      'summary': {
        'due_date': '2015-04-20',
        'close_date': '2015-04-07',
        'past_balance': 0,
        'total_balance': 38933,
        'interest': 0,
        'total_cumulative': 38933,
        'paid': 38933,
        'minimum_payment': 5840,
        'open_date': '2015-03-17'
      },
      '_links': {
        'self': {
          'href': 'https://prod-accounts.nubank.com.br/api/bills/55256cd0-10f7-4fd3-a3be-213bfe01857d'
        },
        'boleto_email': {
          'href': 'https://prod-accounts.nubank.com.br/api/bills/55256cd0-10f7-4fd3-a3be-213bfe01857d/boleto/email'
        },
        'barcode': {
          'href': 'https://prod-accounts.nubank.com.br/api/bills/55256cd0-10f7-4fd3-a3be-213bfe01857d/boleto/barcode'
        }
      },
      'barcode': '03394643200000389339646532300000001745800102',
      'linha_digitavel': '03399.64652  32300.000000  17458.001025  4  64320000038933',
      'line_items': [
        {
          'post_date': '2015-03-31',
          'amount': 3850,
          'title': 'Rest Bolinha',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/551585a8-244c-4ab8-9dce-0113d465ad8e'
        },
        {
          'post_date': '2015-03-31',
          'amount': 12505,
          'title': 'Posto de Servico Dinam',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/55152410-5315-4aeb-b7f3-263170767191'
        },
        {
          'post_date': '2015-04-02',
          'amount': 4180,
          'title': 'Brunetto Massa e Risot',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/551ac6d1-3c44-4f68-a404-788083f00955'
        },
        {
          'post_date': '2015-04-07',
          'amount': 18398,
          'title': 'Pao de Acucar Lj',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/55219aaa-2b9d-40bc-a8d3-bb31f14d2382'
        }
      ]
    }
  }]";
        }
    }
        
}