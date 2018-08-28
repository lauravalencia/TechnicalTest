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
var polizas_service_1 = require("../services/polizas.service");
var global_1 = require("../utilities/global");
var PolizasComponent = /** @class */ (function () {
    function PolizasComponent(_polizasService) {
        this._polizasService = _polizasService;
    }
    PolizasComponent.prototype.ngOnInit = function () {
        var _this = this;
        //this.risks = [{ Id: "1", Name: "Numero 1" }, { Id: "2", Name: "Numero 2" }];
        // this.LoadRisks();
        this._polizasService.getRisk(global_1.Global.RISKS_ENDPOINT)
            .subscribe(function (risks) { _this.risks = risks.OprationSuccess ? risks.ObjectResponse.TiposRiesgo : []; }, function (error) { return _this.msg = error; });
    };
    PolizasComponent.prototype.LoadRisks = function () {
    };
    PolizasComponent = __decorate([
        core_1.Component({
            selector: 'app-polizas',
            templateUrl: './polizas.component.html',
            styleUrls: ['./polizas.component.css']
        }),
        __metadata("design:paramtypes", [polizas_service_1.PolizasService])
    ], PolizasComponent);
    return PolizasComponent;
}());
exports.PolizasComponent = PolizasComponent;
//# sourceMappingURL=polizas.component.js.map