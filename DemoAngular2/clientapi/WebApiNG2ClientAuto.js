"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var http_1 = require('@angular/http');
require('rxjs/add/operator/toPromise');
var DemoWebApi_DemoData_Client;
(function (DemoWebApi_DemoData_Client) {
    (function (AddressType) {
        AddressType[AddressType["Postal"] = 0] = "Postal";
        AddressType[AddressType["Residential"] = 1] = "Residential";
    })(DemoWebApi_DemoData_Client.AddressType || (DemoWebApi_DemoData_Client.AddressType = {}));
    var AddressType = DemoWebApi_DemoData_Client.AddressType;
    (function (Days) {
        Days[Days["Sat"] = 1] = "Sat";
        Days[Days["Sun"] = 2] = "Sun";
        Days[Days["Mon"] = 3] = "Mon";
        Days[Days["Tue"] = 4] = "Tue";
        Days[Days["Wed"] = 5] = "Wed";
        Days[Days["Thu"] = 6] = "Thu";
        Days[Days["Fri"] = 7] = "Fri";
    })(DemoWebApi_DemoData_Client.Days || (DemoWebApi_DemoData_Client.Days = {}));
    var Days = DemoWebApi_DemoData_Client.Days;
})(DemoWebApi_DemoData_Client = exports.DemoWebApi_DemoData_Client || (exports.DemoWebApi_DemoData_Client = {}));
var DemoWebApi_Controllers_Client;
(function (DemoWebApi_Controllers_Client) {
    var SuperDemo = (function () {
        function SuperDemo(baseUri, http) {
            if (baseUri === void 0) { baseUri = location.protocol + '//' + location.hostname + (location.port ? ':' + location.port : '') + '/'; }
            this.baseUri = baseUri;
            this.http = http;
        }
        /**
         * GET api/SuperDemo/int?d={d}
         * @param {number} d
         * @return {number}
         */
        SuperDemo.prototype.getIntSquare = function (d) {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/int?d=' + d)).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/decimal?d={d}
         * @param {number} d
         * @return {number}
         */
        SuperDemo.prototype.getDecimalSquare = function (d) {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/decimal?d=' + d)).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/NullableDatetime?hasValue={hasValue}
         * @param {boolean} hasValue
         * @return {Date}
         */
        SuperDemo.prototype.getDateTime = function (hasValue) {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/NullableDatetime?hasValue=' + hasValue)).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/DateTimeOffset
         * @return {Date}
         */
        SuperDemo.prototype.getDateTimeOffset = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/DateTimeOffset')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * DateTime and DateTimeOffset may not be represented well in URL, so must put them into the POST body.
         * POST api/SuperDemo/DateTimeOffset
         * @param {Date} d
         * @return {boolean}
         */
        SuperDemo.prototype.postDateTimeOffset = function (d) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/DateTimeOffset'), JSON.stringify(d), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/DateTimeOffsetNullable
         * @param {Date} d
         * @return {boolean}
         */
        SuperDemo.prototype.postDateTimeOffsetNullable = function (d) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/DateTimeOffsetNullable'), JSON.stringify(d), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/NullableDecimal?hasValue={hasValue}
         * @param {boolean} hasValue
         * @return {number}
         */
        SuperDemo.prototype.getNullableDecimal = function (hasValue) {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/NullableDecimal?hasValue=' + hasValue)).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/FloatZero
         * @return {number}
         */
        SuperDemo.prototype.getFloatZero = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/FloatZero')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/DoubleZero
         * @return {number}
         */
        SuperDemo.prototype.getDoubleZero = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/DoubleZero')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/DecimalZero
         * @return {number}
         */
        SuperDemo.prototype.getDecimalZero = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/DecimalZero')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/NullString
         * @return {string}
         */
        SuperDemo.prototype.getNullString = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/NullString')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/EmptyString
         * @return {string}
         */
        SuperDemo.prototype.getEmptyString = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/EmptyString')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/NullObject
         * @return {DemoWebApi_DemoData_Client.Person}
         */
        SuperDemo.prototype.getNullPerson = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/NullObject')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/TextStream
         * @return {any}
         */
        SuperDemo.prototype.getTextStream = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/TextStream')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/ByteArray
         * @return {Array<number>}
         */
        SuperDemo.prototype.getByteArray = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/ByteArray')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/ActionResult
         * @return {any}
         */
        SuperDemo.prototype.getActionResult = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/ActionResult')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/byte
         * @return {number}
         */
        SuperDemo.prototype.getbyte = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/byte')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/sbyte
         * @return {number}
         */
        SuperDemo.prototype.getsbyte = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/sbyte')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/short
         * @return {number}
         */
        SuperDemo.prototype.getShort = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/short')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/ushort
         * @return {number}
         */
        SuperDemo.prototype.getUShort = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/ushort')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/uint
         * @return {number}
         */
        SuperDemo.prototype.getUint = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/uint')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/ulong
         * @return {number}
         */
        SuperDemo.prototype.getulong = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/ulong')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/doulbe
         * @return {number}
         */
        SuperDemo.prototype.getdouble = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/doulbe')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/decimal
         * @return {number}
         */
        SuperDemo.prototype.getDecimal = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/decimal')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/char
         * @return {string}
         */
        SuperDemo.prototype.getChar = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/char')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/bool
         * @return {boolean}
         */
        SuperDemo.prototype.getBool = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/bool')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/int2d
         * @return {number[][]}
         */
        SuperDemo.prototype.getInt2D = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/int2d')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/int2dJagged
         * @return {Array<Array<number>>}
         */
        SuperDemo.prototype.getInt2DJagged = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/int2dJagged')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/int2d
         * @param {number[][]} a
         * @return {boolean}
         */
        SuperDemo.prototype.postInt2D = function (a) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/int2d'), JSON.stringify(a), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/int2djagged
         * @param {Array<Array<number>>} a
         * @return {boolean}
         */
        SuperDemo.prototype.postInt2DJagged = function (a) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/int2djagged'), JSON.stringify(a), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/intArray
         * @param {Array<number>} a
         * @return {boolean}
         */
        SuperDemo.prototype.postIntArray = function (a) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/intArray'), JSON.stringify(a), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/intArray
         * @return {Array<number>}
         */
        SuperDemo.prototype.getIntArray = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/intArray')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/AnonymousDynamic
         * @return {any}
         */
        SuperDemo.prototype.getAnonymousDynamic = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/AnonymousDynamic')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/AnonymousObject
         * @return {any}
         */
        SuperDemo.prototype.getAnonymousObject = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/AnonymousObject')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/AnonymousObject
         * @param {any} obj
         * @return {any}
         */
        SuperDemo.prototype.postAnonymousObject = function (obj) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/AnonymousObject'), JSON.stringify(obj), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/StringStringDic
         * @return {{[id: string]: string }}
         */
        SuperDemo.prototype.getDictionary = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/StringStringDic')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/StringPersonDic
         * @return {{[id: string]: DemoWebApi_DemoData_Client.Person }}
         */
        SuperDemo.prototype.getDictionaryOfPeople = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/StringPersonDic')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/StringPersonDic
         * @param {{[id: string]: DemoWebApi_DemoData_Client.Person }} dic
         * @return {number}
         */
        SuperDemo.prototype.postDictionary = function (dic) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/StringPersonDic'), JSON.stringify(dic), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/KeyValuePair
         * @return {{key: string, value: DemoWebApi_DemoData_Client.Person }}
         */
        SuperDemo.prototype.getKeyhValuePair = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/KeyValuePair')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/ICollection
         * @return {Array<DemoWebApi_DemoData_Client.Person>}
         */
        SuperDemo.prototype.getICollection = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/ICollection')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/IList
         * @return {Array<DemoWebApi_DemoData_Client.Person>}
         */
        SuperDemo.prototype.getIList = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/IList')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/IReadOnlyList
         * @return {Array<DemoWebApi_DemoData_Client.Person>}
         */
        SuperDemo.prototype.getIReadOnlyList = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/IReadOnlyList')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/IReadOnlyCollection
         * @return {Array<DemoWebApi_DemoData_Client.Person>}
         */
        SuperDemo.prototype.getIReadOnlyCollection = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/IReadOnlyCollection')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/List
         * @return {Array<DemoWebApi_DemoData_Client.Person>}
         */
        SuperDemo.prototype.getList = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/List')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/Collection
         * @return {Array<DemoWebApi_DemoData_Client.Person>}
         */
        SuperDemo.prototype.getCollection = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/Collection')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/ICollection
         * @param {Array<DemoWebApi_DemoData_Client.Person>} list
         * @return {number}
         */
        SuperDemo.prototype.postICollection = function (list) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/ICollection'), JSON.stringify(list), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/IList
         * @param {Array<DemoWebApi_DemoData_Client.Person>} list
         * @return {number}
         */
        SuperDemo.prototype.postIList = function (list) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/IList'), JSON.stringify(list), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/IReadOnlyList
         * @param {Array<DemoWebApi_DemoData_Client.Person>} list
         * @return {number}
         */
        SuperDemo.prototype.postIReadOnlyList = function (list) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/IReadOnlyList'), JSON.stringify(list), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/IReadOnlyCollection
         * @param {Array<DemoWebApi_DemoData_Client.Person>} list
         * @return {number}
         */
        SuperDemo.prototype.postIReadOnlyCollection = function (list) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/IReadOnlyCollection'), JSON.stringify(list), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/List
         * @param {Array<DemoWebApi_DemoData_Client.Person>} list
         * @return {number}
         */
        SuperDemo.prototype.postList = function (list) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/List'), JSON.stringify(list), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/Collection
         * @param {Array<DemoWebApi_DemoData_Client.Person>} list
         * @return {number}
         */
        SuperDemo.prototype.postCollection = function (list) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/Collection'), JSON.stringify(list), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/SuperDemo/PostEmpty?s={s}&i={i}
         * @param {string} s
         * @param {number} i
         * @return {{item1:string, item2:number}}
         */
        SuperDemo.prototype.postWithQueryButEmptyBody = function (s, i) {
            return this.http.post(encodeURI(this.baseUri + 'api/SuperDemo/PostEmpty?s=' + s + '&i=' + i), JSON.stringify(null), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        SuperDemo.prototype.handleError = function (error) {
            return Promise.reject(error.message || error);
        };
        SuperDemo = __decorate([
            core_1.Injectable(), 
            __metadata('design:paramtypes', [String, http_1.Http])
        ], SuperDemo);
        return SuperDemo;
    }());
    DemoWebApi_Controllers_Client.SuperDemo = SuperDemo;
    var Entities = (function () {
        function Entities(baseUri, http) {
            if (baseUri === void 0) { baseUri = location.protocol + '//' + location.hostname + (location.port ? ':' + location.port : '') + '/'; }
            this.baseUri = baseUri;
            this.http = http;
        }
        /**
         * PUT api/SuperDemo/link?id={id}&relationship={relationship}
         * @param {number} id
         * @param {string} relationship
         * @param {DemoWebApi_DemoData_Client.Person} person
         * @return {boolean}
         */
        Entities.prototype.linkPerson = function (id, relationship, person) {
            return this.http.put(encodeURI(this.baseUri + 'api/SuperDemo/link?id=' + id + '&relationship=' + relationship), JSON.stringify(person), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/SuperDemo/Company?id={id}
         * @param {number} id
         * @return {DemoWebApi_DemoData_Client.Company}
         */
        Entities.prototype.getCompany = function (id) {
            return this.http.get(encodeURI(this.baseUri + 'api/SuperDemo/Company?id=' + id)).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * Get a person
         * GET api/Entities/{id}
         * @param {number} id unique id of that guy
         * @return {DemoWebApi_DemoData_Client.Person} person in db
         */
        Entities.prototype.getPerson = function (id) {
            return this.http.get(encodeURI(this.baseUri + 'api/Entities/' + id)).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Entities
         * @param {DemoWebApi_DemoData_Client.Person} p
         * @return {number}
         */
        Entities.prototype.createPerson = function (p) {
            return this.http.post(encodeURI(this.baseUri + 'api/Entities'), JSON.stringify(p), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * PUT api/Entities
         * @param {DemoWebApi_DemoData_Client.Person} person
         * @return {void}
         */
        Entities.prototype.updatePerson = function (person) {
            return this.http.put(encodeURI(this.baseUri + 'api/Entities'), JSON.stringify(person), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * DELETE api/Entities/{id}
         * @param {number} id
         * @return {void}
         */
        Entities.prototype.delete = function (id) {
            return this.http.delete(encodeURI(this.baseUri + 'api/Entities/' + id)).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        Entities.prototype.handleError = function (error) {
            return Promise.reject(error.message || error);
        };
        Entities = __decorate([
            core_1.Injectable(), 
            __metadata('design:paramtypes', [String, http_1.Http])
        ], Entities);
        return Entities;
    }());
    DemoWebApi_Controllers_Client.Entities = Entities;
    var Tuple = (function () {
        function Tuple(baseUri, http) {
            if (baseUri === void 0) { baseUri = location.protocol + '//' + location.hostname + (location.port ? ':' + location.port : '') + '/'; }
            this.baseUri = baseUri;
            this.http = http;
        }
        /**
         * POST api/Tuple/PersonCompany1
         * @param {{item1:DemoWebApi_DemoData_Client.Person, item2:DemoWebApi_DemoData_Client.Company}} peopleAndCompany
         * @return {DemoWebApi_DemoData_Client.Person}
         */
        Tuple.prototype.linkPersonCompany1 = function (peopleAndCompany) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/PersonCompany1'), JSON.stringify(peopleAndCompany), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/PeopleCompany2
         * @param {{item1:DemoWebApi_DemoData_Client.Person, item2:DemoWebApi_DemoData_Client.Company}} peopleAndCompany
         * @return {DemoWebApi_DemoData_Client.Person}
         */
        Tuple.prototype.linkPeopleCompany2 = function (peopleAndCompany) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/PeopleCompany2'), JSON.stringify(peopleAndCompany), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/PeopleCompany3
         * @param {{item1:DemoWebApi_DemoData_Client.Person, item2:DemoWebApi_DemoData_Client.Person, item3:DemoWebApi_DemoData_Client.Company}} peopleAndCompany
         * @return {DemoWebApi_DemoData_Client.Person}
         */
        Tuple.prototype.linkPeopleCompany3 = function (peopleAndCompany) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/PeopleCompany3'), JSON.stringify(peopleAndCompany), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/PeopleCompany4
         * @param {{item1:DemoWebApi_DemoData_Client.Person, item2:DemoWebApi_DemoData_Client.Person, item3:DemoWebApi_DemoData_Client.Person, item4:DemoWebApi_DemoData_Client.Company}} peopleAndCompany
         * @return {DemoWebApi_DemoData_Client.Person}
         */
        Tuple.prototype.linkPeopleCompany4 = function (peopleAndCompany) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/PeopleCompany4'), JSON.stringify(peopleAndCompany), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Tuple/PeopleCompany4
         * @return {{item1:DemoWebApi_DemoData_Client.Person, item2:DemoWebApi_DemoData_Client.Person, item3:DemoWebApi_DemoData_Client.Person, item4:DemoWebApi_DemoData_Client.Company}}
         */
        Tuple.prototype.getPeopleCompany4 = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/Tuple/PeopleCompany4')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/PeopleCompany5
         * @param {{item1:DemoWebApi_DemoData_Client.Person, item2:DemoWebApi_DemoData_Client.Person, item3:DemoWebApi_DemoData_Client.Person, item4:DemoWebApi_DemoData_Client.Person, item5:DemoWebApi_DemoData_Client.Company}} peopleAndCompany
         * @return {DemoWebApi_DemoData_Client.Person}
         */
        Tuple.prototype.linkPeopleCompany5 = function (peopleAndCompany) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/PeopleCompany5'), JSON.stringify(peopleAndCompany), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Tuple/PeopleCompany5
         * @return {{item1:DemoWebApi_DemoData_Client.Person, item2:DemoWebApi_DemoData_Client.Person, item3:DemoWebApi_DemoData_Client.Person, item4:DemoWebApi_DemoData_Client.Person, item5:DemoWebApi_DemoData_Client.Company}}
         */
        Tuple.prototype.getPeopleCompany5 = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/Tuple/PeopleCompany5')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/PeopleCompany6
         * @param {{item1:DemoWebApi_DemoData_Client.Person, item2:DemoWebApi_DemoData_Client.Person, item3:DemoWebApi_DemoData_Client.Person, item4:DemoWebApi_DemoData_Client.Person, item5:DemoWebApi_DemoData_Client.Person, item6:DemoWebApi_DemoData_Client.Company}} peopleAndCompany
         * @return {DemoWebApi_DemoData_Client.Person}
         */
        Tuple.prototype.linkPeopleCompany6 = function (peopleAndCompany) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/PeopleCompany6'), JSON.stringify(peopleAndCompany), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/PeopleCompany7
         * @param {{item1:DemoWebApi_DemoData_Client.Person, item2:DemoWebApi_DemoData_Client.Person, item3:DemoWebApi_DemoData_Client.Person, item4:DemoWebApi_DemoData_Client.Person, item5:DemoWebApi_DemoData_Client.Person, item6:DemoWebApi_DemoData_Client.Person, item7:DemoWebApi_DemoData_Client.Company}} peopleAndCompany
         * @return {DemoWebApi_DemoData_Client.Person}
         */
        Tuple.prototype.linkPeopleCompany7 = function (peopleAndCompany) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/PeopleCompany7'), JSON.stringify(peopleAndCompany), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/PeopleCompany8
         * @param {{item1:DemoWebApi_DemoData_Client.Person, item2:DemoWebApi_DemoData_Client.Person, item3:DemoWebApi_DemoData_Client.Person, item4:DemoWebApi_DemoData_Client.Person, item5:DemoWebApi_DemoData_Client.Person, item6:DemoWebApi_DemoData_Client.Person, item7:DemoWebApi_DemoData_Client.Person, rest:DemoWebApi_DemoData_Client.Company}} peopleAndCompany
         * @return {DemoWebApi_DemoData_Client.Person}
         */
        Tuple.prototype.linkPeopleCompany8 = function (peopleAndCompany) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/PeopleCompany8'), JSON.stringify(peopleAndCompany), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Tuple/Tuple1
         * @return {{item1:number}}
         */
        Tuple.prototype.getTuple1 = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/Tuple/Tuple1')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/Tuple1
         * @param {{item1:number}} tuple
         * @return {number}
         */
        Tuple.prototype.postTuple1 = function (tuple) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/Tuple1'), JSON.stringify(tuple), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Tuple/Tuple2
         * @return {{item1:string, item2:number}}
         */
        Tuple.prototype.getTuple2 = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/Tuple/Tuple2')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/Tuple2
         * @param {{item1:string, item2:number}} tuple
         * @return {string}
         */
        Tuple.prototype.postTuple2 = function (tuple) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/Tuple2'), JSON.stringify(tuple), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Tuple/Tuple3
         * @return {{item1:string, item2:string, item3:number}}
         */
        Tuple.prototype.getTuple3 = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/Tuple/Tuple3')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/Tuple3
         * @param {{item1:string, item2:string, item3:number}} tuple
         * @return {string}
         */
        Tuple.prototype.postTuple3 = function (tuple) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/Tuple3'), JSON.stringify(tuple), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Tuple/Tuple4
         * @return {{item1:string, item2:string, item3:string, item4:number}}
         */
        Tuple.prototype.getTuple4 = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/Tuple/Tuple4')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/Tuple4
         * @param {{item1:string, item2:string, item3:string, item4:number}} tuple
         * @return {string}
         */
        Tuple.prototype.postTuple4 = function (tuple) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/Tuple4'), JSON.stringify(tuple), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Tuple/Tuple5
         * @return {{item1:string, item2:string, item3:string, item4:string, item5:number}}
         */
        Tuple.prototype.getTuple5 = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/Tuple/Tuple5')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/Tuple5
         * @param {{item1:string, item2:string, item3:string, item4:string, item5:number}} tuple
         * @return {string}
         */
        Tuple.prototype.postTuple5 = function (tuple) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/Tuple5'), JSON.stringify(tuple), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Tuple/Tuple6
         * @return {{item1:string, item2:string, item3:string, item4:string, item5:string, item6:number}}
         */
        Tuple.prototype.getTuple6 = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/Tuple/Tuple6')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/Tuple6
         * @param {{item1:string, item2:string, item3:string, item4:string, item5:string, item6:number}} tuple
         * @return {string}
         */
        Tuple.prototype.postTuple6 = function (tuple) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/Tuple6'), JSON.stringify(tuple), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Tuple/Tuple7
         * @return {{item1:string, item2:string, item3:string, item4:string, item5:string, item6:number, item7:number}}
         */
        Tuple.prototype.getTuple7 = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/Tuple/Tuple7')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/Tuple7
         * @param {{item1:string, item2:string, item3:string, item4:string, item5:string, item6:number, item7:number}} tuple
         * @return {string}
         */
        Tuple.prototype.postTuple7 = function (tuple) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/Tuple7'), JSON.stringify(tuple), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Tuple/Tuple8
         * @return {{item1:string, item2:string, item3:string, item4:string, item5:string, item6:string, item7:number, rest:{item1:string, item2:string, item3:string}}}
         */
        Tuple.prototype.getTuple8 = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/Tuple/Tuple8')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Tuple/Tuple8
         * @param {{item1:string, item2:string, item3:string, item4:string, item5:string, item6:string, item7:string, rest:{item1:string, item2:string, item3:string}}} tuple
         * @return {string}
         */
        Tuple.prototype.postTuple8 = function (tuple) {
            return this.http.post(encodeURI(this.baseUri + 'api/Tuple/Tuple8'), JSON.stringify(tuple), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        Tuple.prototype.handleError = function (error) {
            return Promise.reject(error.message || error);
        };
        Tuple = __decorate([
            core_1.Injectable(), 
            __metadata('design:paramtypes', [String, http_1.Http])
        ], Tuple);
        return Tuple;
    }());
    DemoWebApi_Controllers_Client.Tuple = Tuple;
    var Values = (function () {
        function Values(baseUri, http) {
            if (baseUri === void 0) { baseUri = location.protocol + '//' + location.hostname + (location.port ? ':' + location.port : '') + '/'; }
            this.baseUri = baseUri;
            this.http = http;
        }
        /**
         * GET api/Values
         * @return {Array<string>}
         */
        Values.prototype.get = function () {
            return this.http.get(encodeURI(this.baseUri + 'api/Values')).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Values/{id}?name={name}
         * @param {number} id
         * @param {string} name
         * @return {string}
         */
        Values.prototype.getByIdAndName = function (id, name) {
            return this.http.get(encodeURI(this.baseUri + 'api/Values/' + id + '?name=' + name)).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * GET api/Values?name={name}
         * @param {string} name
         * @return {string}
         */
        Values.prototype.getByName = function (name) {
            return this.http.get(encodeURI(this.baseUri + 'api/Values?name=' + name)).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * POST api/Values
         * @param {string} value
         * @return {string}
         */
        Values.prototype.post = function (value) {
            return this.http.post(encodeURI(this.baseUri + 'api/Values'), JSON.stringify(value), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * PUT api/Values/{id}
         * @param {number} id
         * @param {string} value
         * @return {void}
         */
        Values.prototype.put = function (id, value) {
            return this.http.put(encodeURI(this.baseUri + 'api/Values/' + id), JSON.stringify(value), { headers: new http_1.Headers({ 'Content-Type': 'application/json' }) }).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        /**
         * DELETE api/Values/{id}
         * @param {number} id
         * @return {void}
         */
        Values.prototype.delete = function (id) {
            return this.http.delete(encodeURI(this.baseUri + 'api/Values/' + id)).toPromise().then(function (response) { return response.json(); }).catch(this.handleError);
        };
        Values.prototype.handleError = function (error) {
            return Promise.reject(error.message || error);
        };
        Values = __decorate([
            core_1.Injectable(), 
            __metadata('design:paramtypes', [String, http_1.Http])
        ], Values);
        return Values;
    }());
    DemoWebApi_Controllers_Client.Values = Values;
})(DemoWebApi_Controllers_Client = exports.DemoWebApi_Controllers_Client || (exports.DemoWebApi_Controllers_Client = {}));
//# sourceMappingURL=WebApiNG2ClientAuto.js.map