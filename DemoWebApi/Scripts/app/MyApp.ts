﻿/// <reference path="../typings/jquery/jquery.d.ts" />
/// <reference path="../ClientApi/WebApiClientAuto.ts"/>
/// <reference path="../ClientApi/HttpClient.ts" />
namespace MyApp {

    export class First {
        getPerson() {
            var api = new DemoWebApi_Controllers_Client.Entities();
            api.GetPerson(100, (data) => { $('#nameTag').html("<pre>" + data.Name + "</pre>"); });
        }

        getArrayLastMember() {
            var api = new DemoWebApi_Controllers_Client.SuperDemo();
            api.GetIntArray((data) => { $('#nameTag').html("<pre>" + data[7] + "</pre>"); });
        }
    }
        
}

var first = new MyApp.First();