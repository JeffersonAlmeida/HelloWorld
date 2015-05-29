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
        },
 {
          'post_date': '2015-04-07',
          'amount': 18398,
          'title': 'Pao de Acucar Lj',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/55219aaa-2b9d-40bc-a8d3-bb31f14d2382'
        },
 {
          'post_date': '2015-04-07',
          'amount': 18398,
          'title': 'Pao de Acucar Lj',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/55219aaa-2b9d-40bc-a8d3-bb31f14d2382'
        },
 {
          'post_date': '2015-04-07',
          'amount': 18398,
          'title': 'Pao de Acucar Lj',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/55219aaa-2b9d-40bc-a8d3-bb31f14d2382'
        },
 {
          'post_date': '2015-04-07',
          'amount': 18398,
          'title': 'Pao de Acucar Lj',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/55219aaa-2b9d-40bc-a8d3-bb31f14d2382'
        },
 {
          'post_date': '2015-04-07',
          'amount': 18398,
          'title': 'Pao de Acucar Lj',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/55219aaa-2b9d-40bc-a8d3-bb31f14d2382'
        },
 {
          'post_date': '2015-04-07',
          'amount': 18398,
          'title': 'Pao de Acucar Lj',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/55219aaa-2b9d-40bc-a8d3-bb31f14d2382'
        },
{
          'post_date': '2015-04-11',
          'amount': 17270,
          'title': 'Eolo Restaurante e Caf',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/5526abd4-7439-4749-a39b-1ac6b1914d60'
        },
        {
          'post_date': '2015-04-14',
          'amount': 11162,
          'title': 'Centreville Serv',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/552b044e-acd3-4fc7-be52-07ff1624aa1e'
        },
        {
          'post_date': '2015-04-14',
          'amount': 4299,
          'title': 'Coisa Boa',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/5527ffc3-ce31-4797-8edf-112dfebb30df'
        },
        {
          'post_date': '2015-04-14',
          'amount': 8200,
          'title': 'Purpurina Of de Pizzas',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/5528642e-324a-4518-a970-261d2dd7f8be'
        },
        {
          'post_date': '2015-04-15',
          'amount': 10856,
          'title': 'la da Venda',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/552ad24a-ee6d-41ae-9163-1d5bc05ad05d'
        },
        {
          'post_date': '2015-04-18',
          'amount': 1500,
          'title': 'Stop Green',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/55302f74-34f7-4dfa-927a-623c1b8de677'
        },
        {
          'post_date': '2015-04-18',
          'amount': 6674,
          'title': 'Supermercados Mambo',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/553037ae-a115-46dc-97cc-cb61385575da'
        },
        {
          'post_date': '2015-04-21',
          'amount': 858,
          'title': 'Schoenberger Sorv',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/55341952-3916-47df-8fad-7bce92626a97'
        },
        {
          'post_date': '2015-04-21',
          'amount': 1274,
          'title': 'Schoenberger Sorv',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/55342ed2-0402-491d-8d46-13fd62953be8'
        },
        {
          'post_date': '2015-04-21',
          'amount': 5306,
          'title': 'Auto Posto Playgas',
          'index': 0,
          'charges': 1,
          'href': 'nuapp://transaction/5532c42f-5d22-426a-94f9-15ac615fc367'
        }
      ]
    }
  }]";
        }
    }
        
}