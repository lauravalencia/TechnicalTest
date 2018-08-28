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
var core_1 = require("@angular/core");
var http_1 = require("@angular/common/http");
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
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
//# sourceMappingURL=polizas.service.js.map