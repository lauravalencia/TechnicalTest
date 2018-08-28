"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var polizas_service_1 = require("./polizas.service");
describe('PolizasService', function () {
    beforeEach(function () {
        testing_1.TestBed.configureTestingModule({
            providers: [polizas_service_1.PolizasService]
        });
    });
    it('should be created', testing_1.inject([polizas_service_1.PolizasService], function (service) {
        expect(service).toBeTruthy();
    }));
});
//# sourceMappingURL=polizas.service.spec.js.map