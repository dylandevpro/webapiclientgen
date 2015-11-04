﻿/// <reference path="../typings/jquery/jquery.d.ts" />

class HttpClient {
    /**
    **/
    get(url: string,
        callback: (data: any) => any,
        errorCalback: (xhr: JQueryXHR, ajaxOptions: string, thrown: string) => any,
        statusCodeCallback: Object
    ) {
        $.get(url, callback);
    }

    /** something to say
     * @param {string} url very good
     * @return {void}
     */
    post(url: string,
        dataToSave: any,
        callback: (data: any) => any,
        errorCalback: (xhr: JQueryXHR, ajaxOptions: string, thrown: string) => any,
        statusCodeCallback: { [key: string]: any; }
    ) {
        this.executeAjax(url, dataToSave, "POST", callback, errorCalback, statusCodeCallback);
    }

    put(url: string,
        dataToSave: any,
        callback: (data: any) => any,
        errorCalback: (xhr: JQueryXHR, ajaxOptions: string, thrown: string) => any,
        statusCodeCallback: { [key: string]: any; }
    ) {
        this.executeAjax(url, dataToSave, "PUT", callback, errorCalback, statusCodeCallback);
    }

    delete(url: string,
        callback: (data: any) => any,
        errorCalback: (xhr: JQueryXHR, ajaxOptions: string, thrown: string) => any,
        statusCodeCallback: { [key: string]: any; }
    ) {
        this.executeAjax(url, null, "DELETE", callback, errorCalback, statusCodeCallback);
    }

    private executeAjax(url: string,
        dataToSave: any,
        httpVerb: string,
        callback: (data: any) => any,
        errorCallback: (xhr, ajaxOptions, thrown) => any,
        statusCodeCallback: { [key: string]: any; }
    ) {
        //http://api.jquery.com/jquery.ajax/
        $.ajax(url,
            {
                data: dataToSave,
                type: httpVerb,
                success: (data: any, textStatus: string, jqXHR: JQueryXHR): any => {
                    if (callback !== null) {
                        callback(data);
                    }
                },
                error: (xhr, ajaxOptions, thrown) => {
                    if (errorCallback != null) {
                        errorCallback(xhr, ajaxOptions, thrown);
                    }
                },

                statusCode: statusCodeCallback,

            });
    }
}