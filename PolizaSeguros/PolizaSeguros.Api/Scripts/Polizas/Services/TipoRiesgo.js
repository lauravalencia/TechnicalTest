(function () {
    angular.module("AppModulePolicy")
        .factory("TipoRiesgoService", ["baseSvc", function (baseService) {
            var getAll = function () {
                var query = "/api/RiskType/GetAll";
                return baseService.getRequest(query);
            };
            return {
                getAll: getAll
            };
        }]);
})();