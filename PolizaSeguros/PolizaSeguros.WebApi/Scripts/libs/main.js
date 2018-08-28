(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./src/$$_lazy_route_resource lazy recursive":
/*!**********************************************************!*\
  !*** ./src/$$_lazy_route_resource lazy namespace object ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./src/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./src/app/app.component.css":
/*!***********************************!*\
  !*** ./src/app/app.component.css ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/app.component.html":
/*!************************************!*\
  !*** ./src/app/app.component.html ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!--The content below is only a placeholder and can be replaced.-->\n<app-polizas></app-polizas>\n"

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var AppComponent = /** @class */ (function () {
    function AppComponent() {
        this.title = 'polizasApp';
    }
    AppComponent = __decorate([
        core_1.Component({
            selector: 'app-root',
            template: __webpack_require__(/*! ./app.component.html */ "./src/app/app.component.html"),
            styles: [__webpack_require__(/*! ./app.component.css */ "./src/app/app.component.css")]
        })
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;


/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_1 = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
var core_1 = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var http_1 = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
var app_component_1 = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
var polizas_component_1 = __webpack_require__(/*! ./polizas/polizas.component */ "./src/app/polizas/polizas.component.ts");
var polizas_service_1 = __webpack_require__(/*! ./services/polizas.service */ "./src/app/services/polizas.service.ts");
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                polizas_component_1.PolizasComponent
            ],
            imports: [
                http_1.HttpClientModule,
                platform_browser_1.BrowserModule
            ],
            providers: [polizas_service_1.PolizasService],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;


/***/ }),

/***/ "./src/app/polizas/polizas.component.css":
/*!***********************************************!*\
  !*** ./src/app/polizas/polizas.component.css ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/polizas/polizas.component.html":
/*!************************************************!*\
  !*** ./src/app/polizas/polizas.component.html ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<form class=\"form validate-form\" id=\"form-main\">\r\n\t<span class=\"form-title\">\r\n\t\tNueva p�liza\r\n\t</span>\r\n\r\n\t<div class=\"wrap-input\">\r\n\t\t<span class=\"label-input\">Nombre p�liza *</span>\r\n\t\t<input class=\"input\" type=\"text\" id=\"nombrepoliza\" placeholder=\"Ingrese el nombre\">\r\n\t</div>\r\n\r\n\t<div class=\"wrap-input\">\r\n\t\t<span class=\"label-input\">Descripci�n de la p�liza *</span>\r\n\t\t<textarea class=\"input\" id=\"descpoliza\" placeholder=\"Ingrese la descripci�n\"></textarea>\r\n\t</div>\r\n\t<div class=\"wrap-input\">\r\n\t\t<span class=\"label-input\">Tipo cubrimiento *</span>\r\n\t\t<select multiple id=\"selectTipoCubrimiento\"></select>\r\n\t</div>\r\n\r\n\t<div class=\"wrap-input\">\r\n\t\t<span class=\"label-input\">Fecha inicio vigencia *</span>\r\n\t\t<input type=\"date\" id=\"fechavigencia\" />\r\n\t</div>\r\n\t<div class=\"wrap-input\">\r\n\t\t<span class=\"label-input\">Precio de la p�liza *</span>\r\n\t\t<input type=\"number\" id=\"precio\" />\r\n\t</div>\r\n\t<div class=\"wrap-input\">\r\n\t\t<span class=\"label-input\">Tipo riesgo *</span>\r\n\t\t<select id=\"selectTipoRiesgo\" *ngFor=\"let risk of risks\">\r\n\t\t\t<option value=\"{{risk.IdTipoRiesgo}}\">{{risk.NombreTipoRiesgo}}</option>\r\n\t\t</select>\r\n\t</div>\r\n\r\n\t<div class=\"container-form-btn\">\r\n\t\t<div class=\"wrap-form-btn\">\r\n\t\t\t<div class=\"form-bgbtn\"></div>\r\n\t\t\t<input type=\"submit\" value=\"Guardar\" class=\"btn btn-primary\" />\r\n\t\t\t<input type=\"submit\" value=\"Cancelar\" class = \"btn btn-secondary\" />\r\n\t\t</div>\r\n\t</div>\r\n</form>"

/***/ }),

/***/ "./src/app/polizas/polizas.component.ts":
/*!**********************************************!*\
  !*** ./src/app/polizas/polizas.component.ts ***!
  \**********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

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
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var polizas_service_1 = __webpack_require__(/*! ../services/polizas.service */ "./src/app/services/polizas.service.ts");
var global_1 = __webpack_require__(/*! ../utilities/global */ "./src/app/utilities/global.ts");
var PolizasComponent = /** @class */ (function () {
    function PolizasComponent(_polizasService) {
        this._polizasService = _polizasService;
    }
    PolizasComponent.prototype.ngOnInit = function () {
        this.LoadRisks();
    };
    PolizasComponent.prototype.LoadRisks = function () {
        var _this = this;
        this._polizasService.getRisk(global_1.Global.RISKS_ENDPOINT)
            .subscribe(function (risks) { return _this.risk = risks; }, function (error) { return _this.msg = error; });
    };
    PolizasComponent = __decorate([
        core_1.Component({
            selector: 'app-polizas',
            template: __webpack_require__(/*! ./polizas.component.html */ "./src/app/polizas/polizas.component.html"),
            styles: [__webpack_require__(/*! ./polizas.component.css */ "./src/app/polizas/polizas.component.css")]
        }),
        __metadata("design:paramtypes", [polizas_service_1.PolizasService])
    ], PolizasComponent);
    return PolizasComponent;
}());
exports.PolizasComponent = PolizasComponent;


/***/ }),

/***/ "./src/app/services/polizas.service.ts":
/*!*********************************************!*\
  !*** ./src/app/services/polizas.service.ts ***!
  \*********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

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
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var http_1 = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
var rxjs_1 = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
var operators_1 = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");
var PolizasService = /** @class */ (function () {
    function PolizasService(_http) {
        this._http = _http;
    }
    PolizasService.prototype.getRisk = function (url) {
        return this._http.get(url).pipe(operators_1.catchError(this.handleError));
    };
    PolizasService.prototype.handleError = function (error) {
        if (error.error instanceof ErrorEvent) {
            console.error('Ha ocurrido un error:', error.error.message);
        }
        return rxjs_1.throwError('Ha ocurrido un error interno. Intente m�s tarde.');
    };
    PolizasService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.HttpClient])
    ], PolizasService);
    return PolizasService;
}());
exports.PolizasService = PolizasService;


/***/ }),

/***/ "./src/app/utilities/global.ts":
/*!*************************************!*\
  !*** ./src/app/utilities/global.ts ***!
  \*************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var Global = /** @class */ (function () {
    function Global() {
    }
    Global.RISKS_ENDPOINT = 'http://localhost:51333/api/RiskType/GetAll';
    return Global;
}());
exports.Global = Global;


/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
Object.defineProperty(exports, "__esModule", { value: true });
exports.environment = {
    production: false
};
/*
 * In development mode, for easier debugging, you can ignore zone related error
 * stack frames such as `zone.run`/`zoneDelegate.invokeTask` by importing the
 * below file. Don't forget to comment it out in production mode
 * because it will have a performance impact when errors are thrown
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var platform_browser_dynamic_1 = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
var app_module_1 = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
var environment_1 = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");
if (environment_1.environment.production) {
    core_1.enableProdMode();
}
platform_browser_dynamic_1.platformBrowserDynamic().bootstrapModule(app_module_1.AppModule)
    .catch(function (err) { return console.log(err); });


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! D:\PolizasSeguros\TechnicalTest\PolizaSeguros\PolizaSeguros.WebApi\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map